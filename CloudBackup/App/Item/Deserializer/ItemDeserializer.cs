using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class ItemDeserializer : IObjectDeserializer<Item> {
        public IObjectDeserializer<Group> GroupDeserializer { get; set; }
        public IObjectDeserializer<UpdateableItem> UpdateableItemDeserializer { get; set; }

        public ItemDeserializer(CloudApplication application) {
            GroupDeserializer = new GroupDeserializer(this);
            UpdateableItemDeserializer = new UpdateableItemDeserializer(new FolderDeserializer(application), new FilteredFolderDeserializer(application), new ItemBundleDeserializer(application));
        }

        public Item Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;

            ItemID fileID = (ItemID)(byte)obj["ID"];
            Tag child = obj["Child"];

            Item output;
            switch (fileID) {
                case ItemID.Group:
                    output = GroupDeserializer.Deserialize(child);
                    break;
                case ItemID.UpdateableItem:
                    output = UpdateableItemDeserializer.Deserialize(child);
                    break;
                default:
                    output = null;
                    break;
            }

            output.GeneratedID = obj["GeneratedID"];
            output.Name = obj["Name"];
            output.Link = obj["Link"];
            output.CreationDate = obj["CreationDate"];
            output.LastModificationDate = obj["LastModificationDate"];

            return output;
        }
    }
}
