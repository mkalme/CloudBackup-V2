using System;
using CommonUtilities;

namespace CloudBackup {
    public class Settings : ObservableResource {
        public string FolderName {
            get => _folderName;
            set {
                if (_folderName == value) return;

                _folderName = value;
                RaiseOnContentsChanged();
            }
        }
        private string _folderName;

        public string ZipPath {
            get => _zipPath;
            set {
                if (_zipPath == value) return;

                _zipPath = value;
                RaiseOnContentsChanged();
            }
        }
        private string _zipPath;

        public Settings() {
            _folderName = string.Empty;
            _zipPath = string.Empty;
        }
    }
}
