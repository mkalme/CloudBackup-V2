using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class UpdateableItemDeserializer : IObjectDeserializer<UpdateableItem> {
        public IObjectDeserializer<Folder> FolderDeserializer { get; set; }
        public IObjectDeserializer<FilteredFolder> FilteredFolderDeserializer { get; set; }
        public IObjectDeserializer<ItemBundle> ItemBundleDeserializer { get; set; }

        public UpdateableItemDeserializer(IObjectDeserializer<Folder> folderDeserializer, IObjectDeserializer<FilteredFolder> filteredFolderDeserializer, IObjectDeserializer<ItemBundle> itemBundleDeserializer) {
            FolderDeserializer = folderDeserializer;
            FilteredFolderDeserializer = filteredFolderDeserializer;
            ItemBundleDeserializer = itemBundleDeserializer;
        }

        public UpdateableItem Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;

            UpdateableItemID fileID = (UpdateableItemID)(byte)obj["UpdateableItemID"];
            Tag child = obj["Child"];

            UpdateableItem output;
            switch (fileID) {
                case UpdateableItemID.Folder:
                    output = FolderDeserializer.Deserialize(child);
                    break;
                case UpdateableItemID.FilteredFolder:
                    output = FilteredFolderDeserializer.Deserialize(child);
                    break;
                case UpdateableItemID.ItemBundle:
                    output = ItemBundleDeserializer.Deserialize(child);
                    break;
                default:
                    output = null;
                    break;
            }

            output.Password = obj["Password"];

            foreach (DateTime date in (DateTime[])obj["UpdateHistory"]) {
                output.UpdateHistory.Dates.Add(date);
            }

            return output;
        }
    }
}
