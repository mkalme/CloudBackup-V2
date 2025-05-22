using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class ItemBundleEditor : Form {
        public ItemBundle ItemBundle { get; private set; }

        private HashSet<string> _folders;
        private HashSet<string> _files;

        private Func<string, Image> _getFolderIconFunction;
        private Func<string, Image> _getFileIconFunction;

        public ItemBundleEditor(ItemBundle itemBundle) {
            InitializeComponent();

            ItemBundle = itemBundle;

            _folders = new HashSet<string>(ItemBundle.Folders);
            _files = new HashSet<string>(ItemBundle.Files);

            _getFolderIconFunction = (value) => {
                return Properties.Resources._22pxDirectory.Resize(20, 20);
            };
            _getFileIconFunction = (value) => {
                return Icon.ExtractAssociatedIcon(value).ToBitmap().Resize(20, 20);
            };

            SetInputs();
        }

        private void SetInputs() {
            Text = $"{ItemBundle.Name} | Item bundle";

            NameTextBox.Text = ItemBundle.Name;
            PasswordLinkEditor.SetInput(ItemBundle.Name, ItemBundle.Password, ItemBundle.Link);

            LoadGridView(FolderGridView, _folders, _getFolderIconFunction);
            LoadGridView(FileGridView, _files, _getFileIconFunction);
        }
        private void LoadGridView(DataGridView gridView, IEnumerable<string> items, Func<string, Image> getIconFunction) {
            gridView.Rows.Clear();

            foreach (var item in items) {
                gridView.Rows.Add(item);
                gridView.Rows[gridView.Rows.Count - 1].DisplayImage(gridView.Columns[0], getIconFunction(item), 25);
            }

            gridView.ClearSelection();
        }

        private void AddFoldersButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog.ShowDialog();
            if (string.IsNullOrEmpty(FolderBrowserDialog.SelectedPath)) return;

            _folders.Add(FolderBrowserDialog.SelectedPath);
            LoadGridView(FolderGridView, _folders, _getFolderIconFunction);
        }
        private void AddFilesButton_Click(object sender, EventArgs e) {
            OpenFileDialog.ShowDialog();
            if (OpenFileDialog.FileNames.Length < 1) return;

            foreach (var file in OpenFileDialog.FileNames) {
                if (File.Exists(file)) _files.Add(file);
            }

            LoadGridView(FileGridView, _files, _getFileIconFunction);
        }

        private void OpenFoldersView_Click(object sender, EventArgs e) {
            Icon icon = ImageToIconConverter.Convert(Properties.Resources._22pxDirectory, 22, 22);

            Func<IEnumerable<string>> addFunction = () => {
                FolderBrowserDialog.ShowDialog();
                if (string.IsNullOrEmpty(FolderBrowserDialog.SelectedPath)) return new string[0];

                return new string[] { FolderBrowserDialog.SelectedPath };
            };

            InputResult<ISet<string>> results = CustomDialog.ShowTextCollectionEditor(_folders, "Folders", addFunction, _getFolderIconFunction, icon);
            if (results.DialogClosed) return;

            _folders = new HashSet<string>(results.Value);

            LoadGridView(FolderGridView, _folders, _getFolderIconFunction);
        }
        private void OpenFilesView_Click(object sender, EventArgs e) {
            Func<IEnumerable<string>> addFunction = () => {
                OpenFileDialog.ShowDialog();

                List<string> fileNames = new List<string>(OpenFileDialog.FileNames.Length);
                foreach (var file in OpenFileDialog.FileNames) {
                    if (File.Exists(file)) fileNames.Add(file);
                }

                return fileNames;
            };

            InputResult<ISet<string>> results = CustomDialog.ShowTextCollectionEditor(_files, "Files", addFunction, _getFileIconFunction, Properties.Resources._64pxDocumentIcon);
            if (results.DialogClosed) return;

            _files = new HashSet<string>(results.Value);

            LoadGridView(FileGridView, _files, _getFileIconFunction);
        }

        private void RemoveFoldersLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            foreach (DataGridViewRow folder in FolderGridView.SelectedRows) {
                _folders.Remove((string)folder.Cells[0].Value);
            }

            LoadGridView(FolderGridView, _folders, _getFolderIconFunction);
        }
        private void RemoveFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            foreach (DataGridViewRow file in FileGridView.SelectedRows) {
                _files.Remove((string)file.Cells[0].Value);
            }

            LoadGridView(FileGridView, _files, _getFileIconFunction);
        }

        //Save
        private bool _close = false;
        private void ItemBundleEditor_FormClosing(object sender, FormClosingEventArgs e) {
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
        private void ItemCancelButton_Click(object sender, EventArgs e) {
            _close = true;
            Close();
        }

        private bool CheckForChanges() {
            if (NameTextBox.Text != ItemBundle.Name || PasswordLinkEditor.Password != ItemBundle.Password || PasswordLinkEditor.Link != ItemBundle.Link) return true;

            if (!_folders.SetEquals(new HashSet<string>(ItemBundle.Folders))) return true;
            return !_files.SetEquals(new HashSet<string>(ItemBundle.Files));
        }
        private bool ValidateContent() {
            return NameUtilities.ValidateName(ItemBundle.GetTypeString(), NameTextBox.Text);
        }
        private void SaveChanges() {
            ItemBundle.ApplyUpdateMode();

            ItemBundle.Folders.Clear();
            foreach (var folder in _folders) {
                ItemBundle.Folders.Add(folder);
            }

            ItemBundle.Files.Clear();
            foreach (var file in _files) {
                ItemBundle.Files.Add(file);
            }

            ItemBundle.Name = NameTextBox.Text;
            ItemBundle.Password = PasswordLinkEditor.Password;
            ItemBundle.Link = PasswordLinkEditor.Link;

            ItemBundle.SuspendUpdateMode();
        }
    }
}
