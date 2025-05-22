using System;
using System.IO;
using CommonUtilities;

namespace CloudBackup {
    public sealed class Folder : UpdateableItem {
        public string FolderPath {
            get => _folderPath;
            set {
                if (value == _folderPath) return;

                _folderPath = value;
                RaiseOnContentsChanged(true);
            }
        }
        public string _folderPath;

        public Folder(CloudApplication application) : base(application, UpdateableItemID.Folder) {
            _folderPath = string.Empty;
        }

        public override CompressionResult ProvideFinishedLocalFile(IProgress<float> progress) {
            Zip zip = new Zip() {
                FileName = Application.Settings.ZipPath
            };
            ZipOperation operation = new ZipOperation() {
                Folders = new string[] { _folderPath },
                OutputArchivePath = $"Storage\\Temporary\\{GeneratedID}.7z",
                Password = Password,
                Progress = progress
            };

            return new CompressionResult(operation.Execute(zip) == ExitCode.NoError, operation.OutputArchivePath);
        }

        public override object Clone() {
            Folder output = new Folder(Application) { 
                FolderPath = FolderPath,
            };

            CloneToObject(output);

            return output;
        }
        public override bool Equals(Item other) {
            if (ID != other.ID) return false;
            if (!ObjectEquals(other as UpdateableItem)) return false;

            Folder folder = other as Folder;

            return FolderPath == folder.FolderPath;
        }
    }
}
