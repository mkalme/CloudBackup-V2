using System;
using System.IO;
using System.Text;
using CloudServiceProvider;
using CommonUtilities;

namespace CloudBackup {
    public class Updater : IUpdater {
        public CloudApplication Application { get; set; }
        
        private static readonly string _temporaryFolder = $"{AppDomain.CurrentDomain.BaseDirectory}\\Storage\\Temporary";
        private static readonly string _usersheetName = "Usersheet.7z";

        public Updater(CloudApplication application) {
            Application = application;
        }

        public bool Update(UpdateableItem updateableItem, IProgress<ProgressReport> progress) {
            ZipProgressAdapter zipProgressAdapter = new ZipProgressAdapter(progress) {
                Title = "Creating archive"
            };

            CompressionResult compressionResult = updateableItem.ProvideFinishedLocalFile(zipProgressAdapter);
            if (!compressionResult.Successfull) return false;

            try {
                using (FileStream outputStream = File.OpenRead(compressionResult.Output)) {
                    ByteProgressAdapter adapter = new ByteProgressAdapter(progress, outputStream.Length) {
                        Title = "Uploading archive",
                        FinishOnEnd = false
                    };
                    UploadFileRequest uploadFileRequest = new UploadFileRequest() {
                        CloudObjectPath = $"{Application.Settings.FolderName}/{updateableItem.CreateCloudPath()}{Path.GetExtension(compressionResult.Output)}",
                        InputStream = outputStream,
                        ShareLink = true,
                        Progress = adapter
                    };

                    CorrectIfMoved(uploadFileRequest.CloudObjectPath, updateableItem);
                    Application.CloudServiceProvider.CloudProvider.Upload(uploadFileRequest);

                    updateableItem.ApplyUpdateMode();

                    updateableItem.Link = uploadFileRequest.SharedLink;
                    updateableItem.UpdateHistory.Dates.Add(DateTime.Now);

                    Application.Usersheet.Update(updateableItem, uploadFileRequest);
                    updateableItem.SuspendUpdateMode();

                    UpdateUserSheet(progress);
                }

                File.Delete(compressionResult.Output);
            } catch {
                return false;
            }

            return true;
        }
        public void UpdateUserSheet(IProgress<ProgressReport> progress) {
            string usersheetPath = $"{_temporaryFolder}\\{_usersheetName}";
            try {
                SheetUtilities.CreateSheet(Application.Usersheet, usersheetPath, Encoding.UTF8.GetString(Application.Key), Application.Settings.ZipPath);
            } catch { }

            try {
                using (FileStream usersheetStream = File.OpenRead(usersheetPath)) {
                    ByteProgressAdapter adapter = new ByteProgressAdapter(progress, usersheetStream.Length) {
                        Title = "Uploading user sheet"
                    };
                    UploadFileRequest uploadFileRequest = new UploadFileRequest() {
                        CloudObjectPath = $"{Application.Settings.FolderName}/{Path.GetFileName(usersheetPath)}",
                        InputStream = usersheetStream,
                        ShareLink = true,
                        Progress = adapter
                    };
                    Application.CloudServiceProvider.CloudProvider.Upload(uploadFileRequest);

                    Application.Usersheet.Link = uploadFileRequest.SharedLink;
                }
            } catch { }

            File.Delete(usersheetPath);
        }

        public bool Download(UpdateableItem updateableItem, string outputDirectory, IProgress<ProgressReport> progress) {
            string sourcePath = $"{_temporaryFolder}\\{updateableItem.GeneratedID}.7z";
            try {
                ItemInformation info = Application.Usersheet.ReceiveItemInformation(updateableItem);

                using (FileStream outputStream = File.OpenWrite(sourcePath)) {
                    ByteProgressAdapter adapter = new ByteProgressAdapter(progress, info.LastLength) {
                        Title = "Downloading archive"
                    };
                    DownloadFileRequest downloadFileRequest = new DownloadFileRequest() {
                        CloudObjectPath = info.LastPath,
                        OutputStream = outputStream,
                        Progress = adapter
                    };

                    Application.CloudServiceProvider.CloudProvider.Download(downloadFileRequest);
                }

                ZipProgressAdapter unzipAdapter = new ZipProgressAdapter(progress) {
                    Title = "Extracting archive"
                };
                Zip zip = new Zip() {
                    FileName = Application.Settings.ZipPath
                };
                UnzipOperation operation = new UnzipOperation() {
                    ArchivePath = sourcePath,
                    OutputDirectory = outputDirectory,
                    Password = info.LastPassword,
                    Progress = unzipAdapter
                };

                operation.Execute(zip);
            } catch {
                return false;
            }

            File.Delete(sourcePath);
            return true;
        }

        public bool Delete(UpdateableItem updateableItem) {
            try {
                ObjectRequest objectRequest = new ObjectRequest() {
                    CloudObjectPath = Application.Usersheet.ReceiveItemInformation(updateableItem).LastPath
                };

                RequestStatus status = Application.CloudServiceProvider.CloudProvider.Delete(objectRequest);
                if (status == RequestStatus.Successfull) {
                    updateableItem.Parent.Items.Remove(updateableItem);
                    return true;
                }
            } catch { }

            return false;
        }
        private void CorrectIfMoved(string outputPath, UpdateableItem updateableItem) {
            ItemInformation info = Application.Usersheet.ReceiveItemInformation(updateableItem);
            if (info == null || info.LastPath == outputPath) return;

            ObjectRequest objectRequest = new ObjectRequest() {
                CloudObjectPath = info.LastPath
            };

            Application.CloudServiceProvider.CloudProvider.Delete(objectRequest);
        }
    }
}
