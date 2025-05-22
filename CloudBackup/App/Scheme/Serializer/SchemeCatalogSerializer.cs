using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class SchemeCatalogSerializer : IObjectSerializer<SchemeCatalog> {
        public IObjectSerializer<Scheme> SchemeSerializer { get; set; }

        public SchemeCatalogSerializer() {
            SchemeSerializer = new SchemeSerializer();
        }

        public Tag Serialize(SchemeCatalog item) {
            Tag[] schemeTags = new Tag[item.Schemes.Count];

            for (int i = 0; i < item.Schemes.Count; i++) { 
                schemeTags[i] = SchemeSerializer.Serialize(item.Schemes[i]);
            }

            return schemeTags;
        }
    }
}
