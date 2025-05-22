using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup.Gui {
    public class GuiSettingsSerializer : IObjectSerializer<GuiSettings> {
        public Tag Serialize(GuiSettings item) {
            return new ObjectTag() {
                { "DefaultPasswordLength", item.DefaultPasswordLength },
                { "ProgressBarColor", item.ProgressBarColor.ToArgb() }
            };
        }
    }
}
