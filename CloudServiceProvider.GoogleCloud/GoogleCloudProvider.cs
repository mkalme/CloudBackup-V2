using System;
using System.IO;
using System.Threading;
using System.Text;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using CloudServiceProvider.GoogleCloud.Common;
using CustomDialogs;

namespace CloudServiceProvider.GoogleCloud {
    public class GoogleCloudProvider : ICloudProvider {
        public Credentials Credentials { get; private set; }
        public StorageClient StorageClient { get; private set; }

        private GoogleCredential _googleCredential;

        private Thread _credentialsThread;

        public GoogleCloudProvider(Credentials credentials) {
            Credentials = credentials;
            Credentials.OnCredentialsJsonStringChanged += Credentials_OnCredentialsJsonStringChanged;

            CreateStorageClient();
        }

        private void Credentials_OnCredentialsJsonStringChanged(object sender, EventArgs e) {
            if (StorageClient != null) StorageClient.Dispose();
            CreateStorageClient();
        }
        private void CreateStorageClient() {
            _credentialsThread = new Thread(() => {
                try {

                    _googleCredential = GoogleCredential.FromStream(new MemoryStream(Encoding.UTF8.GetBytes(Credentials.CredentialsJsonString)));
                    StorageClient = StorageClient.Create(_googleCredential);

                } catch { }
            });

            _credentialsThread.Start();
        }

        public void Upload(UploadFileRequest uploadFileRequest) {
            if (!ValidateCredentials()) {
                uploadFileRequest.Progress.Report(new ByteProgressReport(RequestStatus.OtherError, 0));
            }

            try {
                Google.Apis.Storage.v1.Data.Object obj = new Google.Apis.Storage.v1.Data.Object();
                obj.Bucket = Credentials.BucketName;
                obj.Name = uploadFileRequest.CloudObjectPath;

                uploadFileRequest.InputStream.Position = 0;

                UploadProgressAdapter progressAdapter = new UploadProgressAdapter(uploadFileRequest.Progress, uploadFileRequest.InputStream.Length);
                var uploadedObject = StorageClient.UploadObject(obj, uploadFileRequest.InputStream, null, progressAdapter);

                if (uploadFileRequest.ShareLink) uploadFileRequest.SharedLink = uploadedObject.MediaLink;
            } catch (Exception e) {
                RequestStatus error = RequestStatus.OtherError;

                if (e is System.Net.Http.HttpRequestException) {
                    error = RequestStatus.NoInternetConnection;
                }

                uploadFileRequest.Progress.Report(new ByteProgressReport(error, 0));
            }
        }
        public void Download(DownloadFileRequest downloadFileRequest) {
            if (!ValidateCredentials()) {
                downloadFileRequest.Progress.Report(new ByteProgressReport(RequestStatus.OtherError, 0));
            }

            try {
                Google.Apis.Storage.v1.Data.Object obj = StorageClient.GetObject(Credentials.BucketName, downloadFileRequest.CloudObjectPath);

                DownloadProgressAdapter progressAdapter = new DownloadProgressAdapter(downloadFileRequest.Progress, (long)obj.Size);
                StorageClient.DownloadObject(obj, downloadFileRequest.OutputStream, null, progressAdapter);
            } catch (Exception e) {
                RequestStatus error = RequestStatus.OtherError;

                if (e is System.Net.Http.HttpRequestException) {
                    error = RequestStatus.NoInternetConnection;
                } else if (e is Google.GoogleApiException apiExcepion && apiExcepion.HttpStatusCode == System.Net.HttpStatusCode.NotFound) {
                    error = RequestStatus.FileNotFound;
                }

                downloadFileRequest.Progress.Report(new ByteProgressReport(error, 0));
            }
        }
        public RequestStatus Delete(ObjectRequest objectRequest) {
            if (!ValidateCredentials()) return RequestStatus.OtherError;

            try {
                StorageClient.DeleteObject(Credentials.BucketName, objectRequest.CloudObjectPath);
                
                return RequestStatus.Successfull;
            } catch(Exception e) {
                RequestStatus error = RequestStatus.OtherError;

                if (e is System.Net.Http.HttpRequestException) {
                    error = RequestStatus.NoInternetConnection;
                } else if (e is Google.GoogleApiException apiExcepion && apiExcepion.HttpStatusCode == System.Net.HttpStatusCode.NotFound) {
                    error = RequestStatus.FileNotFound;
                }

                return error;
            }
        }

        private bool ValidateCredentials() {
            bool json = string.IsNullOrEmpty(Credentials.CredentialsJsonString);
            bool bucketName = string.IsNullOrEmpty(Credentials.BucketName);

            if (json && !bucketName) {
                CustomDialog.ShowError("Google Cloud Error", "Credentials json string is empty.");
            } else if (!json && bucketName) {
                CustomDialog.ShowError("Google Cloud Error", "Bucket name is empty.");
            } else if (json && bucketName) {
                CustomDialog.ShowError("Google Cloud Error", "Credentials json string and bucket name are empty.");
            }

            _credentialsThread.Join();

            return !json && !bucketName;
        }
    }
}
