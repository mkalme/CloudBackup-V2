using System;
using CommonUtilities;

namespace CloudBackup {
    public abstract class Item : ICloneable {
        public ItemID ID { get; }
        public Group Parent { get; internal set; }

        public string GeneratedID { get; internal set; }

        public string Name {
            get => _name;
            set {
                if (_name == value) return;

                _name = value;
                RaiseOnContentsChanged(true);
                RaiseOnNameChanged();
            }
        }
        private string _name;

        public string Link {
            get => _link;
            set {
                if (_link == value) return;

                _link = value;
                RaiseOnContentsChanged(true);
                RaiseOnNameChanged();
            }
        }
        private string _link;

        public DateTime CreationDate {
            get => _creationDate;
            set {
                if (_creationDate == value) return;

                _creationDate = value;
                RaiseOnContentsChanged(false);
            }
        }
        private DateTime _creationDate;

        public DateTime LastModificationDate { get; set; }

        public event EventHandler OnContentsChanged;
        public event EventHandler OnNameChanged;
        public event EventHandler OnIdChanged;
        public event EventHandler OnDeletion;

        private bool _updateModeActivated = false;
        private bool _updateOccured = false;
        private bool _modifyDate = false;

        protected Item(ItemID id) {
            ID = id;
            GeneratedID = ShortIdUtilities.GenerateShortId();
            _name = string.Empty;
            _link = string.Empty;
            _creationDate = DateTime.Now;
            LastModificationDate = DateTime.Now;
        }

        internal void RaiseOnContentsChanged(bool modifyDate) {
            if (_updateModeActivated) {
                _updateOccured = true;
                if (modifyDate) _modifyDate = true;
            } else {
                if (modifyDate) LastModificationDate = DateTime.Now;

                OnContentsChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        internal void RaiseOnNameChanged() {
            OnNameChanged?.Invoke(this, EventArgs.Empty);
        }
        internal void RaiseOnIdChanged() {
            OnIdChanged?.Invoke(this, EventArgs.Empty);
        }
        internal void RaiseOnDeletion() {
            OnDeletion?.Invoke(this, EventArgs.Empty);
        }

        public void ApplyUpdateMode() {
            _updateModeActivated = true;
        }
        public void SuspendUpdateMode() {
            _updateModeActivated = false;

            if (_updateOccured) {
                _updateOccured = false;

                bool modifyDate = _modifyDate;
                _modifyDate = false;

                RaiseOnContentsChanged(modifyDate);
            }
        }

        public void ChangeID(string uniqueID) {
            if (GeneratedID == uniqueID) return;

            GeneratedID = uniqueID;
            RaiseOnContentsChanged(true);
            RaiseOnIdChanged();
        }
        public string CreateCloudPath() {
            return Parent == null ? GeneratedID : $"{Parent.CreateCloudPath()}/{GeneratedID}";
        }
        public string CreatePathInProgram() {
            return Parent == null ? Name : $"{Parent.CreatePathInProgram()}/{Name}";
        }

        public abstract object Clone();
        protected virtual void CloneToObject(Item item) {
            item._name = Name;
            item._link = Link;
        }

        public abstract bool Equals(Item other);
        protected bool ObjectEquals(Item item) {
            return Name == item.Name && Link == item.Link && CreationDate == item.CreationDate && LastModificationDate == item.LastModificationDate;
        }
    }
}
