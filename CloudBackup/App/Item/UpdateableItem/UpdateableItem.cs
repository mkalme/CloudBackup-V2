using System;
using System.IO;
using System.Text;
using CloudServiceProvider;
using CommonUtilities;

namespace CloudBackup {
    public abstract class UpdateableItem : Item {
        public UpdateableItemID UpdateableItemID { get; }

        public CloudApplication Application { get; private set; }

        public string Password {
            get => _password;
            set {
                if (_password == value) return;

                _password = value;
                RaiseOnContentsChanged(true);
            }
        }
        private string _password;

        public DateTimeHistory UpdateHistory { get; private set; }

        protected UpdateableItem(CloudApplication application, UpdateableItemID fileId) : base(ItemID.UpdateableItem) {
            UpdateableItemID = fileId;
            Application = application;
            _password = string.Empty;
            UpdateHistory = new DateTimeHistory(new DateTime[0]);
            UpdateHistory.OnContentsChanged += UpdateHistory_OnContentsChanged;
        }

        private void UpdateHistory_OnContentsChanged(object sender, EventArgs e) {
            RaiseOnContentsChanged(false);
        }

        public bool Update(IProgress<ProgressReport> progress) {
            return Application.Updater.Update(this, progress);
        }
        public abstract CompressionResult ProvideFinishedLocalFile(IProgress<float> progress);

        public bool Download(string outputDirectory, IProgress<ProgressReport> progress) {
            return Application.Updater.Download(this, outputDirectory, progress);
        }
        public bool Delete() {
            return Application.Updater.Delete(this);
        }

        protected void CloneToObject(UpdateableItem item) {
            base.CloneToObject(item);

            item._password = Password;
        }
        protected bool ObjectEquals(UpdateableItem item) {
            return base.ObjectEquals(item) && UpdateableItemID != item.UpdateableItemID && Password == item.Password;
        }
    }
}
