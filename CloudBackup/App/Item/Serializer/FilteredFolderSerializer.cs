using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class FilteredFolderSerializer : IObjectSerializer<FilteredFolder> {
        public Tag Serialize(FilteredFolder item) {
            return new ObjectTag() {
                { "FolderPath", item.FolderPath },
                { "Filter", item.Filter },
                { "Exclude", item.Exclude },
                { "CaseSensitive", item.CaseSensitive }
            };
        }
    }
}
