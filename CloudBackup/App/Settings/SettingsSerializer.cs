using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class SettingsSerializer : IObjectSerializer<Settings> {
        public Tag Serialize(Settings item) {
            return new ObjectTag() {
                { "FolderName", item.FolderName },
                { "ZipPath", item.ZipPath }
            };
        }
    }
}
