using System;
using System.Drawing;

namespace CloudBackup.Gui {
    public class ProgramInformationPanel : CustomDialogs.ProgramInformationPanel {
        public override string HeaderText { get; set; } = "Cloud Backup";
        public override Image Icon { get; set; } = Properties.Resources._64pxGroup;

        public override string ProgramName { get; set; } = "Instance";

        public ProgramInformationPanel(GuiApplication application) {
            ProgramCreated = application.AppInformation.CreationDate.ToString();
            ProgramLocatedIn = BuildInformationPanel.Assembly.Location;
        }
    }
}
