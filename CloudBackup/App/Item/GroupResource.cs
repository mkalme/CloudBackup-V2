using System;
using System.IO;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class GroupResource : SerializeableResource {
        public Group Group { get; private set; }
        public CloudApplication Application { get; private set; }

        public GroupResource(CloudApplication application, IStreamProvider streamProvider) : base(streamProvider) { 
            Application = application;
        }

        protected override void SetDefaultState() {
            Group = new Group() {
                Name = "Home"
            };
        }
        protected override void SetState(Stream inputStream) {
            Group = new ItemDeserializer(Application).Deserialize(Tag.FromStream(inputStream)) as Group;
        }
        protected override void Serialize(Stream outputStream) {
            new ItemSerializer().Serialize(Group).WriteToStream(outputStream);
        }
    }
}
