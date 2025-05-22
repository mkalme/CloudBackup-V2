using System;
using System.IO;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup.Gui {
    public class GuiSettingsResource : SerializeableResource {
        public GuiSettings GuiSettings { get; private set; }

        public GuiSettingsResource(IStreamProvider streamProvider) : base(streamProvider) {}

        protected override void SetDefaultState() {
            GuiSettings = new GuiSettings();
        }
        protected override void SetState(Stream inputStream) {
            GuiSettings = new GuiSettingsDeserializer().Deserialize(Tag.FromStream(inputStream));
        }
        protected override void Serialize(Stream outputStream) {
            new GuiSettingsSerializer().Serialize(GuiSettings).WriteToStream(outputStream);
        }
    }
}
