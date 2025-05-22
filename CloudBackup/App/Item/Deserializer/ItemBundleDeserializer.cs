using System;
using System.Collections.Generic;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class ItemBundleDeserializer : IObjectDeserializer<ItemBundle> {
        public CloudApplication Application { get; set; }

        public ItemBundleDeserializer(CloudApplication application) {
            Application = application;
        }

        public ItemBundle Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;

            return new ItemBundle(Application, new List<string>((string[])obj["Folders"]), new List<string>((string[])obj["Files"]));
        }
    }
}
