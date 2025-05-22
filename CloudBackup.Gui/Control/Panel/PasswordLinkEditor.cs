using System;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class PasswordLinkEditor : UserControl {
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Link { get; set; }

        public PasswordLinkEditor() {
            InitializeComponent();
        }

        public void SetInput(string displayName, string password, string link) {
            DisplayName = displayName;
            Password = password;
            Link = link;
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e) {
            InputResult<string> result = DialogUtilities.ShowPasswordInput(DisplayName, Password);
            if (result.DialogClosed) return;

            Password = result.Value;
        }
        private void ChangeLinkButton_Click(object sender, EventArgs e) {
            InputResult<string> result = DialogUtilities.ShowLinkInput(DisplayName, Link);
            if (result.DialogClosed) return;

            Link = result.Value;
        }
    }
}
