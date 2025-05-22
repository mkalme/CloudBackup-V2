using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class ItemSerializer : IObjectSerializer<Item> {
        public IObjectSerializer<Group> GroupSerializer { get; set; }
        public IObjectSerializer<UpdateableItem> UpdateableItemSerializer { get; set; }

        public ItemSerializer() {
            GroupSerializer = new GroupSerializer(this);
            UpdateableItemSerializer = new UpdateableItemSerializer(new FolderSerializer(), new FilteredFolderSerializer(), new ItemBundleSerializer());
        }

        public Tag Serialize(Item item) {
            Tag child;

            switch (item.ID) {
                case ItemID.Group:
                    child = GroupSerializer.Serialize(item as Group);
                    break;
                case ItemID.UpdateableItem:
                    child = UpdateableItemSerializer.Serialize(item as UpdateableItem);
                    break;
                default:
                    child = null;
                    break;
            }

            return new ObjectTag() {
                { "ID", (byte)item.ID },
                { "GeneratedID", item.GeneratedID },
                { "Name", item.Name },
                { "Link", item.Link},
                { "CreationDate", item.CreationDate },
                { "LastModificationDate", item.LastModificationDate },
                { "Child", child }
            };
        }
    }
}
