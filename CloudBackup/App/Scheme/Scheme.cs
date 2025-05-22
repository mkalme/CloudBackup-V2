using System;
using CommonUtilities;

namespace CloudBackup {
    public class Scheme : ObservableResource {
        public ObservableCollection<UpdateableItem> Items { get; private set; }
        
        public string Name {
            get => _name;
            set {
                if (_name == value) return;

                _name = value;
                RaiseOnContentsChanged();
            }
        }
        private string _name;

        public Scheme(int count = 0) { 
            Items = new ObservableList<UpdateableItem>(count);
            Items.OnItemsAdd += (sender, items) => {
                foreach (var item in items) {
                    item.OnDeletion += Item_OnDeletion;
                }

                RaiseOnContentsChanged();
            };
            Items.OnItemsRemove += (sender, items) => {
                foreach (var item in items) {
                    item.OnDeletion -= Item_OnDeletion;
                }

                RaiseOnContentsChanged();
            };

            _name = string.Empty;
        }

        private void Item_OnDeletion(object sender, EventArgs e) {
            Items.Remove(sender as UpdateableItem);
        }
    }
}
