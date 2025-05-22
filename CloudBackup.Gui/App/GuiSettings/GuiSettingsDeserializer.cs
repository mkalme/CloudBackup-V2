using System;
using System.Drawing;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup.Gui {
    public class GuiSettingsDeserializer : IObjectDeserializer<GuiSettings> {
        public GuiSettings Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;

            return new GuiSettings() { 
                DefaultPasswordLength = obj["DefaultPasswordLength"],
                ProgressBarColor = Color.FromArgb(obj["ProgressBarColor"])
            };
        }
    }
}
