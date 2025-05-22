using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class FolderDeserializer : IObjectDeserializer<Folder> {
        public CloudApplication Application { get; set; }

        public FolderDeserializer(CloudApplication application) {
            Application = application;
        }

        public Folder Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;

            return new Folder(Application) { 
                FolderPath = obj["FolderPath"]
            };
        }
    }
}
