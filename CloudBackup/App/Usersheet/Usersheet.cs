using System;
using System.Linq;
using System.Collections.Generic;
using CloudServiceProvider;
using CommonUtilities;

namespace CloudBackup {
    public class Usersheet : ObservableResource {
        public ObservableDictionary<string, ItemInformation> Items { get; private set; }

        public string Link {
            get => _link;
            set {
                if (_link == value) return;

                _link = value;
                RaiseOnContentsChanged();
            }
        }
        private string _link;

        public Usersheet() { 
            Items = new ObservableDictionary<string, ItemInformation>();
            Items.OnItemsAdd += (sender, pairs) => {
                foreach (KeyValuePair<string, ItemInformation> pair in pairs) {
                    pair.Value.OnContentsChanged += ItemInformation_OnContentsChanged;
                    pair.Value.Item.OnIdChanged += Item_OnIdChanged;
                    pair.Value.Item.OnDeletion += Item_OnDeletion;
                }

                RaiseOnContentsChanged();
            };
            Items.OnItemsRemove += (sender, pairs) => {
                foreach (KeyValuePair<string, ItemInformation> pair in pairs) {
                    pair.Value.OnContentsChanged -= ItemInformation_OnContentsChanged;
                    pair.Value.Item.OnIdChanged -= Item_OnIdChanged;
                    pair.Value.Item.OnDeletion -= Item_OnDeletion;
                }

                RaiseOnContentsChanged();
            };

            _link = string.Empty;
        }

        private void ItemInformation_OnContentsChanged(object sender, EventArgs e) {
            RaiseOnContentsChanged();
        }
        
        private void Item_OnIdChanged(object sender, EventArgs e) {
            string oldId = Items.FirstOrDefault(x => x.Value.Item == sender).Key;

            ApplyUpdateMode();
            ItemInformation info = Items[oldId];
            
            Items.Remove(oldId);
            Items.Add(info.Item.GeneratedID, info);

            SuspendUpdateMode();
        }
        private void Item_OnDeletion(object sender, EventArgs e) {
            Items.Remove(((Item)sender).GeneratedID);
        }

        public void Update(UpdateableItem item, UploadFileRequest uploadFileRequest) {
            ApplyUpdateMode();

            ItemInformation information = ReceiveItemInformation(item);
            if (information == null) {
                information = new ItemInformation(item);
                Items.Add(item.GeneratedID, information);
            }

            information.UpdateInformation(uploadFileRequest);

            SuspendUpdateMode();
        }
        public ItemInformation ReceiveItemInformation(UpdateableItem item) {
            Items.TryGetValue(item.GeneratedID, out ItemInformation info);
            return info;
        }
    }
}
