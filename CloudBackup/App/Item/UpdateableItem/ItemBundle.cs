using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CommonUtilities;

namespace CloudBackup {
    public sealed class ItemBundle : UpdateableItem {
        public ObservableCollection<string> Folders { get; private set; }
        public ObservableCollection<string> Files { get; private set; }

        public ItemBundle(CloudApplication application) : this(application, new List<string>(), new List<string>()) {}
        public ItemBundle(CloudApplication application, IList<string> folders, IList<string> files) : base(application, UpdateableItemID.ItemBundle) {
            Folders = new ObservableList<string>(folders);
            Files = new ObservableList<string>(files);

            Folders.OnItemsAdd += ObservableCollection_ContentsChanged;
            Folders.OnItemsRemove += ObservableCollection_ContentsChanged;

            Files.OnItemsAdd -= ObservableCollection_ContentsChanged;
            Files.OnItemsRemove -= ObservableCollection_ContentsChanged;
        }

        private void ObservableCollection_ContentsChanged(object sender, string[] items) {
            RaiseOnContentsChanged(true);
        }

        public override CompressionResult ProvideFinishedLocalFile(IProgress<float> progress) {
            Zip zip = new Zip() {
                FileName = Application.Settings.ZipPath
            };
            ZipOperation operation = new ZipOperation() {
                Folders = Folders,
                Files = Files,
                OutputArchivePath = $"Storage\\Temporary\\{GeneratedID}.7z",
                Password = Password,
                Progress = progress
            };

            return new CompressionResult(operation.Execute(zip) == ExitCode.NoError, operation.OutputArchivePath);
        }

        public override object Clone() {
            ItemBundle output = new ItemBundle(Application);

            foreach (string folder in Folders) {
                Folders.Add(folder);
            }
            foreach (string file in Files) {
                Folders.Add(file);
            }

            CloneToObject(output);

            return output;
        }
        public override bool Equals(Item other) {
            if (ID != other.ID) return false;
            if (!ObjectEquals(other as UpdateableItem)) return false;

            ItemBundle itemBundle = other as ItemBundle;
            return Folders.SequenceEqual(itemBundle.Folders) && Files.SequenceEqual(itemBundle.Files);
        }
    }
}
