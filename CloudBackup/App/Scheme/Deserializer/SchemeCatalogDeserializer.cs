using System;
using System.Collections.Generic;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class SchemeCatalogDeserializer : IObjectDeserializer<SchemeCatalog> {
        public IObjectDeserializer<Scheme> SchemeDeserializer { get; set; }

        public SchemeCatalogDeserializer(Group group) {
            List<UpdateableItem> updateableItems = new List<UpdateableItem>();
            group.GetUpdateableItems(updateableItems);

            SchemeDeserializer = new SchemeDeserializer(updateableItems);
        }

        public SchemeCatalog Deserialize(Tag tag) {
            Tag[] schemeTags = tag;

            SchemeCatalog output = new SchemeCatalog();
            for (int i = 0; i < schemeTags.Length; i++) {
                output.Schemes.Add(SchemeDeserializer.Deserialize(schemeTags[i]));
            }

            return output;
        }
    }
}
