using System;
using System.IO;
using CommonUtilities;

namespace CloudBackup {
    public sealed class FilteredFolder : UpdateableItem {
        public string FolderPath {
            get => _folderPath;
            set {
                if (value == _folderPath) return;

                _folderPath = value;
                RaiseOnContentsChanged(true);
            }
        }
        public string _folderPath;

        public string Filter {
            get => _filter;
            set {
                if (value == _filter) return;

                _filter = value;
                RaiseOnContentsChanged(true);
            }
        }
        public string _filter;

        public bool Exclude {
            get => _exclude;
            set {
                if (value == _exclude) return;

                _exclude = value;
                RaiseOnContentsChanged(true);
            }
        }
        public bool _exclude;

        public bool CaseSensitive {
            get => _caseSensitive;
            set {
                if (value == _caseSensitive) return;

                _caseSensitive = value;
                RaiseOnContentsChanged(true);
            }
        }
        public bool _caseSensitive;

        public FilteredFolder(CloudApplication application) : base(application, UpdateableItemID.FilteredFolder) {
            _folderPath = string.Empty;
            _filter = "*";
            _exclude = false;
            _caseSensitive = false;
        }

        public override CompressionResult ProvideFinishedLocalFile(IProgress<float> progress) {
            Zip zip = new Zip() {
                FileName = Application.Settings.ZipPath
            };
            FilteredZipOperation operation = new FilteredZipOperation() {
                FolderPath = FolderPath,
                Filter = Filter,
                Exclude = Exclude,
                CaseSensitive = CaseSensitive,
                OutputArchivePath = $"Storage\\Temporary\\{GeneratedID}.7z",
                Password = Password,
                Progress = progress
            };

            return new CompressionResult(operation.Execute(zip) == ExitCode.NoError, operation.OutputArchivePath);
        }

        public override object Clone() {
            FilteredFolder output = new FilteredFolder(Application) {
                FolderPath = FolderPath,
                Filter = Filter,
                Exclude = Exclude,
                CaseSensitive = CaseSensitive
            };

            CloneToObject(output);

            return output;
        }
        public override bool Equals(Item other) {
            if (ID != other.ID) return false;
            if (!ObjectEquals(other as UpdateableItem)) return false;

            FilteredFolder filteredFolder = other as FilteredFolder;

            if(FolderPath != filteredFolder.FolderPath || Filter != filteredFolder.Filter) return false;
            return Exclude == filteredFolder.Exclude && CaseSensitive == filteredFolder.CaseSensitive;
        }
    }
}
