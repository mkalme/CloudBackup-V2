using System;
using System.Linq;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class ItemBundleSerializer : IObjectSerializer<ItemBundle> {
        public Tag Serialize(ItemBundle item) {
            return new ObjectTag() {
                { "Folders", item.Folders.ToArray() },
                { "Files", item.Files.ToArray() }
            };
        }
    }
}