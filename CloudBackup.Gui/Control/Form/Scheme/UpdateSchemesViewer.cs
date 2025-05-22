using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class UpdateSchemesViewer : Form {
        public CloudApplication Application { get; set; }
        public GuiApplication GuiApplication { get; set; }

        private IList<object> _selectedItems = new List<object>();

        public UpdateSchemesViewer(CloudApplication cloudApplication, GuiApplication guiApplication) {
            InitializeComponent();

            Application = cloudApplication;
            GuiApplication = guiApplication;

            MenuStrip.Renderer = new CustomToolStripRenderer(new CustomMenuStripColors() {
                BorderColor = Color.FromArgb(120, 120, 120),
                InnerBorderColor = Color.FromArgb(55, 55, 55),
                HoverColor = Color.FromArgb(70, 70, 70),
                DisabledHoverColor = Color.FromArgb(90, 90, 90)
            });
        }

        private void UpdateSchemesViewer_Load(object sender, EventArgs e) {
            LoadDialog();
            GridView.ClearSelection();
        }

        private bool _inUpdate = false;
        private void LoadDialog() {
            _inUpdate = true;

            GridView.Rows.Clear();

            for (int i = 0; i < Application.SchemeCatalog.Schemes.Count; i++) {
                Scheme scheme = Application.SchemeCatalog.Schemes[i];

                GridView.Rows.Add(scheme.Name, scheme.Items.Count);

                var row = GridView.Rows[i];
                row.Tag = scheme;
                row.Selected = _selectedItems.Contains(scheme);

                row.DisplayImage(NameCol, Properties.Resources._64pxCloudUpload.Resize(21, 21, InterpolationMode.HighQualityBicubic), 29);
            }

            SetButtonAvailability();

            _inUpdate = false;
        }

        private void GridView_SelectionChanged(object sender, EventArgs e) {
            if (_inUpdate) return;

            SetButtonAvailability();

            _selectedItems.Clear();
            foreach (DataGridViewRow row in GridView.SelectedRows) {
                _selectedItems.Add(row.Tag);
            }
        }
        private void SetButtonAvailability() {
            RenameButton.Enabled = GridView.SelectedRows.Count == 1;
            RemoveButton.Enabled = GridView.SelectedRows.Count > 0;
        }

        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            OpenScheme(GridView.Rows[e.RowIndex].Tag as Scheme);
            LoadDialog();
        }

        private void SelectRow(Scheme scheme) {
            foreach (DataGridViewRow row in GridView.Rows) {
                if (row.Tag == scheme) {
                    row.Selected = true;
                    return;
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e) {
            UpdateSeelctedItems();
        }

        private void AddButton_Click(object sender, EventArgs e) {
            CreateNewScheme();
        }
        private void RenameButton_Click(object sender, EventArgs e) {
            Scheme scheme = GridView.SelectedRows[0].Tag as Scheme;
            RenameScheme(scheme);

            LoadDialog();
        }
        private void RemoveButton_Click(object sender, EventArgs e) {
            List<Scheme> schemes = new List<Scheme>(GridView.SelectedRows.Count);

            foreach (DataGridViewRow row in GridView.SelectedRows) {
                schemes.Add(row.Tag as Scheme);
            }

            RemoveSchemes(schemes);
            LoadDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }

        //MenuStrip
        private void MenuStrip_Opening(object sender, CancelEventArgs e) {
            UpdateMenuItem.Enabled = GridView.SelectedRows.Count > 0;
            RenameMenuItem.Enabled = GridView.SelectedRows.Count == 1;
            RemoveMenuItem.Enabled = GridView.SelectedRows.Count > 0;
        }

        private void NewMenuItem_Click(object sender, EventArgs e) {
            CreateNewScheme();
        }

        private void UpdateMenuItem_Click(object sender, EventArgs e) {
            UpdateSeelctedItems();
        }
        private void RenameMenuItem_Click(object sender, EventArgs e) {
            Scheme scheme = GridView.SelectedRows[0].Tag as Scheme;
            RenameScheme(scheme);

            LoadDialog();
        }
        private void RemoveMenuItem_Click(object sender, EventArgs e) {
            List<Scheme> schemes = new List<Scheme>(GridView.SelectedRows.Count);

            foreach (DataGridViewRow row in GridView.SelectedRows) {
                schemes.Add(row.Tag as Scheme);
            }

            RemoveSchemes(schemes);
            LoadDialog();
        }

        private void MoveUpButton_Click(object sender, EventArgs e) {
            if (GridView.SelectedRows.Count != 1) return;

            int rowIndex = GridView.SelectedRows[0].Index;
            if (rowIndex < 1) return;

            Scheme item = GridView.SelectedRows[0].Tag as Scheme;
            Application.SchemeCatalog.SwapChildItems(item, GridView.Rows[rowIndex - 1].Tag as Scheme);
            LoadDialog();
        }
        private void MoveDownButton_Click(object sender, EventArgs e) {
            if (GridView.SelectedRows.Count != 1) return;

            int rowIndex = GridView.SelectedRows[0].Index;
            if (rowIndex >= GridView.Rows.Count - 1) return;

            Scheme item = GridView.SelectedRows[0].Tag as Scheme;
            Application.SchemeCatalog.SwapChildItems(item, GridView.Rows[rowIndex + 1].Tag as Scheme);

            LoadDialog();
        }

        //Functions
        private void CreateNewScheme() {
            Scheme scheme = new Scheme() {
                Name = "New scheme"
            };

            Application.SchemeCatalog.Schemes.Add(scheme);

            LoadDialog();

            SelectRow(scheme);
            RenameScheme(scheme);

            LoadDialog();
        }
        private void UpdateSeelctedItems() {
            List<Item> items = new List<Item>();

            foreach (DataGridViewRow row in GridView.SelectedRows) {
                Scheme scheme = row.Tag as Scheme;
                items.AddRange(scheme.Items.Cast<Item>());
            }

            if(items.Count > 0) ItemUtilities.UpdateItems(items, GuiApplication.GuiSettings.ProgressBarColor);
        }

        private void RenameScheme(Scheme scheme) {
            InputResult<string> result = CustomDialog.ShowTextInput("Scheme's name", "Edit the scheme's name.",
                scheme.Name, Properties.Resources._64pxRename);
            if (result.DialogClosed) return;

            if (string.IsNullOrEmpty(result.Value)) {
                CustomDialog.ShowError("Error", "Group's name cannot be empty.");
            } else {
                scheme.Name = result.Value;
            }
        }
        private void RemoveSchemes(IEnumerable<Scheme> schemes) {
            if (CustomDialog.ShowDeletionConfirmation("Remove")) {
                Application.SchemeCatalog.ApplyUpdateMode();
                
                foreach (Scheme scheme in schemes) {
                    Application.SchemeCatalog.Schemes.Remove(scheme);
                }

                Application.SchemeCatalog.SuspendUpdateMode();
            }
        }

        private void OpenScheme(Scheme scheme) {
            UpdateableItemCollectionEditor editor = new UpdateableItemCollectionEditor(scheme.Items, Application.Group);
            editor.ShowDialog();

            if (editor.DialogClosed) return;

            Application.SchemeCatalog.ApplyUpdateMode();

            scheme.Items.Clear();
            foreach (var item in editor.UpdateableItems) {
                scheme.Items.Add(item);
            }

            Application.SchemeCatalog.SuspendUpdateMode();
        }
    }
}
