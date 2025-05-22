using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class FilteredFolderDeserializer : IObjectDeserializer<FilteredFolder> {
        public CloudApplication Application { get; set; }

        public FilteredFolderDeserializer(CloudApplication application) {
            Application = application;
        }

        public FilteredFolder Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;

            return new FilteredFolder(Application) {
                FolderPath = obj["FolderPath"],
                Filter = obj["Filter"],
                Exclude = obj["Exclude"],
                CaseSensitive = obj["CaseSensitive"]
            };
        }
    }
}
