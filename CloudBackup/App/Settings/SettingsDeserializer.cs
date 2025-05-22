using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class SettingsDeserializer : IObjectDeserializer<Settings> {
        public Settings Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;

            return new Settings() { 
                FolderName = obj["FolderName"],
                ZipPath = obj["ZipPath"]
            };
        }
    }
}
