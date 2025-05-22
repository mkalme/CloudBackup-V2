using System;
using System.IO;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class FilteredFolderEditor : Form {
        public FilteredFolder FilteredFolder { get; private set; }

        public FilteredFolderEditor(FilteredFolder filteredFolder) {
            InitializeComponent();

            FilteredFolder = filteredFolder;

            SetInputs();
        }

        private void SetInputs() {
            Text = $"{FilteredFolder.Name} | Filtered folder";

            NameTextBox.Text = FilteredFolder.Name;
            PathTextBox.Text = FilteredFolder.FolderPath;
            FilterTextBox.Text = FilteredFolder.Filter;
            ExcludeCheckBox.Checked = FilteredFolder.Exclude;
            CaseSensitiveCheckBox.Checked = FilteredFolder.CaseSensitive;

            PasswordLinkEditor.SetInput(FilteredFolder.Name, FilteredFolder.Password, FilteredFolder.Link);
        }

        private void BrowseButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog.ShowDialog();
            PathTextBox.Text = FolderBrowserDialog.SelectedPath;
        }

        //DragDrop
        private void FilteredFolderEditor_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void FilteredFolderEditor_DragDrop(object sender, DragEventArgs e) {
            string[] folders = (string[])e.Data.GetData(DataFormats.FileDrop);

            PathTextBox.Text = folders[0];
            NameTextBox.Text = Path.GetFileName(folders[0]);
        }

        //Save
        private bool _close = false;
        private void FilteredFolderEditor_FormClosing(object sender, FormClosingEventArgs e) {
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

        private void SaveButton_Click(object sender, EventArgs e) {
            if (!ValidateContent()) return;
            SaveChanges();

            _close = true;
            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e) {
            _close = true;
            Close();
        }

        private bool CheckForChanges() {
            if (NameTextBox.Text != FilteredFolder.Name || PasswordLinkEditor.Password != FilteredFolder.Password || PasswordLinkEditor.Link != FilteredFolder.Link) return true;
            if (FilterTextBox.Text != FilteredFolder.Filter || ExcludeCheckBox.Checked != FilteredFolder.Exclude ||
                CaseSensitiveCheckBox.Checked != FilteredFolder.CaseSensitive) return true;

            return PathTextBox.Text != FilteredFolder.FolderPath;
        }
        private bool ValidateContent() {
            return NameUtilities.ValidateName(FilteredFolder.GetTypeString(), NameTextBox.Text);
        }
        private void SaveChanges() {
            FilteredFolder.ApplyUpdateMode();

            FilteredFolder.Name = NameTextBox.Text;
            FilteredFolder.Password = PasswordLinkEditor.Password;
            FilteredFolder.Link = PasswordLinkEditor.Link;

            FilteredFolder.Filter = FilterTextBox.Text;
            FilteredFolder.Exclude = ExcludeCheckBox.Checked;
            FilteredFolder.CaseSensitive = CaseSensitiveCheckBox.Checked;

            FilteredFolder.FolderPath = PathTextBox.Text;

            FilteredFolder.SuspendUpdateMode();
        }
    }
}
