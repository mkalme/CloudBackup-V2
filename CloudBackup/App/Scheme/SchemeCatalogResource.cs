using System;
using System.IO;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class SchemeCatalogResource : SerializeableResource {
        public SchemeCatalog SchemeCatalog { get; private set; }
        public Group Group { get; private set; }

        public SchemeCatalogResource(Group group, IStreamProvider streamProvider) : base(streamProvider) { 
            Group = group;
        }

        protected override void SetDefaultState() {
            SchemeCatalog = new SchemeCatalog();
        }
        protected override void SetState(Stream inputStream) {
            SchemeCatalog = new SchemeCatalogDeserializer(Group).Deserialize(Tag.FromStream(inputStream));
        }
        protected override void Serialize(Stream outputStream) {
            new SchemeCatalogSerializer().Serialize(SchemeCatalog).WriteToStream(outputStream);
        }
    }
}
