using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class FolderSerializer : IObjectSerializer<Folder> {
        public Tag Serialize(Folder item) {
            return new ObjectTag() {
                { "FolderPath", item.FolderPath }
            };
        }
    }
}
