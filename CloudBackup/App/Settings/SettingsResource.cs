using System;
using System.IO;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class SettingsResource : SerializeableResource {
        public Settings Settings { get; private set; }

        public SettingsResource(IStreamProvider streamProvider) : base(streamProvider) { }

        protected override void SetDefaultState() {
            Settings = new Settings() { 
                ZipPath = "7z.exe"
            };
        }
        protected override void SetState(Stream inputStream) {
            Settings = new SettingsDeserializer().Deserialize(Tag.FromStream(inputStream));
        }
        protected override void Serialize(Stream outputStream) {
            new SettingsSerializer().Serialize(Settings).WriteToStream(outputStream);
        }
    }
}
