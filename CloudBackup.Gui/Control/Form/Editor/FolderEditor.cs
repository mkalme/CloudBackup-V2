using System;
using System.IO;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class FolderEditor : Form {
        public Folder Folder { get; private set; }

        public FolderEditor(Folder folder) {
            InitializeComponent();

            Folder = folder;

            SetInputs();
        }

        private void SetInputs() {
            Text = $"{Folder.Name} | Folder";

            NameTextBox.Text = Folder.Name;
            PathTextBox.Text = Folder.FolderPath;
            PasswordLinkEditor.SetInput(Folder.Name, Folder.Password, Folder.Link);
        }

        private void BrowseButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog.ShowDialog();
            PathTextBox.Text = FolderBrowserDialog.SelectedPath;
        }

        //DragDrop
        private void FolderEditor_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void FolderEditor_DragDrop(object sender, DragEventArgs e) {
            string[] folders = (string[])e.Data.GetData(DataFormats.FileDrop);

            PathTextBox.Text = folders[0];
            NameTextBox.Text = Path.GetFileName(folders[0]);
        }

        //Save
        private bool _close = false;
        private void SaveButton_Click(object sender, EventArgs e) {
            if (!ValidateContent()) return;
            SaveChanges();

            _close = true;
            Close();
        }
        private void FolderCancelButton_Click(object sender, EventArgs e) {
            _close = true;
            Close();
        }

        private void FolderEditor_FormClosing(object sender, FormClosingEventArgs e) {
            if (_close || !CheckForChanges()) return;

            SaveConfirmation result = CustomDialog.ShowSaveConfirmation();
            if (result == SaveConfirmation.Close || result == SaveConfirmation.Cancel) {
                e.Cancel = true;
                return;
            }
            if (result == SaveConfirmation.DontSave) return;

            if (!ValidateContent()) {
                e.Cancel = true;
                return;
            }

            SaveChanges();
        }

        private bool CheckForChanges() {
            if (NameTextBox.Text != Folder.Name || PasswordLinkEditor.Password != Folder.Password || PasswordLinkEditor.Link != Folder.Link) return true;

            return PathTextBox.Text != Folder.FolderPath;
        }
        private bool ValidateContent() {
            return NameUtilities.ValidateName(Folder.GetTypeString(), NameTextBox.Text);
        }
        private void SaveChanges() {
            Folder.ApplyUpdateMode();

            Folder.Name = NameTextBox.Text;
            Folder.Password = PasswordLinkEditor.Password;
            Folder.Link = PasswordLinkEditor.Link;

            Folder.FolderPath = PathTextBox.Text;

            Folder.SuspendUpdateMode();
        }
    }
}
