using System;
using CloudServiceProvider;
using CommonUtilities;

namespace CloudBackup {
    public class ItemInformation : ObservableResource {
        public UpdateableItem Item { get; private set; }

        public string LastPassword {
            get => _lastPassword;
            set {
                if (_lastPassword == value) return;

                _lastPassword = value;
                RaiseOnContentsChanged();
            }
        }
        private string _lastPassword;

        public string LastPathInProgram {
            get => _lastPathInProgram;
            set {
                if (_lastPathInProgram == value) return;

                _lastPathInProgram = value;
                RaiseOnContentsChanged();
            }
        }
        private string _lastPathInProgram;

        public string LastPath {
            get => _lastPath;
            set {
                if (_lastPath == value) return;

                _lastPath = value;
                RaiseOnContentsChanged();
            }
        }
        private string _lastPath;

        public string LastLink {
            get => _lastLink;
            set {
                if (_lastLink == value) return;

                _lastLink = value;
                RaiseOnContentsChanged();
            }
        }
        private string _lastLink;

        public long LastLength {
            get => _lastLength;
            set {
                if (_lastLength == value) return;

                _lastLength = value;
                RaiseOnContentsChanged();
            }
        }
        private long _lastLength;

        public DateTime LastUpdated {
            get => _lastUpdated;
            set {
                if (_lastUpdated == value) return;

                _lastUpdated = value;
                RaiseOnContentsChanged();
            }
        }
        private DateTime _lastUpdated;

        public ItemInformation(UpdateableItem item) {
            Item = item;

            _lastPassword = string.Empty;
            _lastLink = string.Empty;
            _lastUpdated= DateTime.MinValue;
            _lastLength = 0;
        }

        public void UpdateInformation(UploadFileRequest uploadFileRequest) {
            ApplyUpdateMode();

            LastPassword = Item.Password;
            LastPathInProgram = Item.CreatePathInProgram();
            LastPath = uploadFileRequest.CloudObjectPath;
            LastLink = Item.Link;
            LastLength = uploadFileRequest.InputStream.Length;
            LastUpdated = Item.UpdateHistory.Dates[Item.UpdateHistory.Dates.Count - 1];

            SuspendUpdateMode();
        }
    }
}
