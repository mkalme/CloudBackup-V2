using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class ItemInformationSerializer : IObjectSerializer<ItemInformation> {
        public Tag Serialize(ItemInformation item) {
            return new ObjectTag() {
                { "GeneratedID", item.Item.GeneratedID },
                { "LastPassword", item.LastPassword },
                { "LastPathInProgram", item.LastPathInProgram },
                { "LastPath", item.LastPath },
                { "LastLink", item.LastLink },
                { "LastLength", item.LastLength },
                { "LastUpdated", item.LastUpdated }
            };
        }
    }
}
