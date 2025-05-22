using System;
using System.Linq;

namespace CloudBackup.Gui {
    public class KeyInformationPanel : CustomDialogs.KeyInformationPanel {
        public KeyInformationPanel(GuiApplication application) {
            CurrentKeySince = application.AppInformation.KeyChangeHistory.Dates.Last().ToString();
            KeyHistory = application.AppInformation.KeyChangeHistory.Dates;
            KeyCellIcon = Properties.Resources._16pxKey;
        }
    }
}
