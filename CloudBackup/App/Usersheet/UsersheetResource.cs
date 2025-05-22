using System;
using System.IO;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class UsersheetResource : SerializeableResource {
        public Usersheet Usersheet { get; private set; }
        public Group Group { get; private set; }

        public UsersheetResource(Group group, IStreamProvider streamProvider) : base(streamProvider) {
            Group = group;
        }

        protected override void SetDefaultState() {
            Usersheet = new Usersheet();
        }
        protected override void SetState(Stream inputStream) {
            Usersheet = new UsersheetDeserializer(Group).Deserialize(Tag.FromStream(inputStream));
        }
        protected override void Serialize(Stream outputStream) {
            new UsersheetSerializer().Serialize(Usersheet).WriteToStream(outputStream);
        }
    }
}
