using System;
using System.Collections.Generic;
using System.Linq;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class SchemeDeserializer : IObjectDeserializer<Scheme> {
        public IList<UpdateableItem> UpdateableItems { get; set; }

        public SchemeDeserializer(IList<UpdateableItem> updateableItems) {
            UpdateableItems = updateableItems;
        }

        public Scheme Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;

            string[] ids = obj["IDs"];
            Scheme output = new Scheme(ids.Length);

            for (int i = 0; i < ids.Length; i++) {
                UpdateableItem item = UpdateableItems.Where(x => x.GeneratedID == ids[i]).FirstOrDefault();
                if (item != null) output.Items.Add(item);
            }

            output.Name = obj["Name"];

            return output;
        }
    }
}
