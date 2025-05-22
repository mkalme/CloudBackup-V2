using System;
using System.Linq;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class SchemeSerializer : IObjectSerializer<Scheme> {
        public Tag Serialize(Scheme item) {
            return new ObjectTag() {
                { "IDs", item.Items.Select(x => x.GeneratedID).ToArray() },
                { "Name", item.Name }
            };
        }
    }
}
