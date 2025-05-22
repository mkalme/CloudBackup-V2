using System;
using System.Linq;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup.Gui {
    public class AppInformationSerializer : IObjectSerializer<AppInformation> {
        public Tag Serialize(AppInformation item) {
            return new ObjectTag() {
                { "CreationDate", item.CreationDate },
                { "KeyChangeHistory", item.KeyChangeHistory.Dates.ToArray() }
            };
        }
    }
}
