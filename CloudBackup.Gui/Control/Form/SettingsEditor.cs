using System;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class SettingsEditor : Form {
        public Settings Settings { get; set; }
        public GuiSettings GuiSettings { get; set; }

        public SettingsEditor(Settings settings, GuiSettings guiSettings) {
            InitializeComponent();

            Settings = settings;
            GuiSettings = guiSettings;

            DefaultPasswordLengthTextBox.Text = GuiSettings.DefaultPasswordLength.ToString();
            ZipPathTextBox.Text = Settings.ZipPath;
            FolderNameTextBox.Text = Settings.FolderName;
            ProgressBarColorPanel.BackColor = GuiSettings.ProgressBarColor;
        }

        private void ProgressBarColorPanel_MouseDown(object sender, MouseEventArgs e) {
            ColorDialog colorDialog = new ColorDialog() {
                Color = ProgressBarColorPanel.BackColor
            };
            colorDialog.ShowDialog();

            ProgressBarColorPanel.BackColor = colorDialog.Color;
        }

        private bool _close = false;
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (_close) return;

            if (!ValidateContents(false) || CheckForChanges()) {
                SaveConfirmation result = CustomDialog.ShowSaveConfirmation();

                if (result == SaveConfirmation.Save) {
                    if (ValidateContents()) Save();
                    else e.Cancel = true;
                } else if (result == SaveConfirmation.Cancel) {
                    e.Cancel = true;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (!ValidateContents()) return;

            Save();
            Close();
        }
        private void Cancelbutton_Click(object sender, EventArgs e) {
            _close = true;
            Close();
        }

        private bool ValidateContents(bool showErrorMessage = true) {
            if (!int.TryParse(DefaultPasswordLengthTextBox.Text, out int result)) {
                if (showErrorMessage) {
                    CustomDialog.ShowError("Error", "Cannot parse default password length.");
                }

                return false;
            }

            return true;
        }
        private bool CheckForChanges() {
            if (GuiSettings.DefaultPasswordLength != int.Parse(DefaultPasswordLengthTextBox.Text) || Settings.ZipPath != ZipPathTextBox.Text) return true;
            return GuiSettings.ProgressBarColor != ProgressBarColorPanel.BackColor;
        }
        private void Save() {
            Settings.ZipPath = ZipPathTextBox.Text;

            GuiSettings.ApplyUpdateMode();

            GuiSettings.DefaultPasswordLength = int.Parse(DefaultPasswordLengthTextBox.Text);
            GuiSettings.ProgressBarColor = ProgressBarColorPanel.BackColor;

            GuiSettings.SuspendUpdateMode();
        }
    }
}
