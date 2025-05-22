using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class UpdateableItemCollectionEditor : Form {
        public IList<UpdateableItem> UpdateableItems { get; set; }
        public Group Root { get; set; }

        public bool DialogClosed { get; private set; } = true;

        private IList<object> _selectedItems = new List<object>();

        public UpdateableItemCollectionEditor(IEnumerable<UpdateableItem> updateableItems, Group root) {
            InitializeComponent();

            UpdateableItems = new List<UpdateableItem>(updateableItems);
            Root = root;
        }

        private void UpdateableItemCollectionEditor_Load(object sender, EventArgs e) {
            LoadDialog();
            GridView.ClearSelection();
        }

        //Update
        private ImageCache _imageCache = new ImageCache();
        private bool _inUpdate = false;
        
        private void LoadDialog() {
            _inUpdate = true;

            GridView.Rows.Clear();
            foreach (var item in UpdateableItems) {
                AddUpdateableItemRow(item);

                GridView.Rows[GridView.Rows.Count - 1].Tag = item;
                GridView.Rows[GridView.Rows.Count - 1].Selected = _selectedItems.Contains(item);
            }

            SetButtonAvailability();

            _inUpdate = false;
        }
        private void AddUpdateableItemRow(UpdateableItem item) {
            GridView.Rows.Add(item.Name);
            DataGridViewRow row = GridView.Rows[GridView.Rows.Count - 1];

            ((TextAndImageCell)row.Cells[NameCol.Index]).XOffet = item.UpdateableItemID == UpdateableItemID.Folder || item.UpdateableItemID == UpdateableItemID.FilteredFolder ? 4 : 3;
            row.DisplayImage(NameCol, _imageCache.GetImage(item.GetImageChacheKey(), item.GetIcon(), 16, 16), 27);
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
            RemoveButton.Enabled = GridView.SelectedRows.Count > 0;
        }

        //Buttons
        private void RemoveButton_Click(object sender, EventArgs e) {
            Remove();
        }
        private void AddButton_Click(object sender, EventArgs e) {
            Add();
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            DialogClosed = false;
            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void MenuStrip_Opening(object sender, CancelEventArgs e) {
            RemoveMenuItem.Enabled = GridView.SelectedRows.Count > 0;
        }

        private void AddMenuItem_Click(object sender, EventArgs e) {
            Add();
        }
        private void RemoveMenuItem_Click(object sender, EventArgs e) {
            Remove();
        }

        //Functions
        private void Add() {
            InputResult<IList<object>> selectionResult = ItemSelectorUtilities.ShowSelector(Root, new ItemSelectorProfile() {
                SelectedItemValidator = item => ((Item)item).ID == ItemID.UpdateableItem && !UpdateableItems.Contains(item),
                SingleSelection = false
            }, item => !UpdateableItems.Contains(item));
            if (selectionResult.DialogClosed) return;

            UpdateableItems = UpdateableItems.Concat(selectionResult.Value.Cast<UpdateableItem>()).ToList();

            LoadDialog();
        }
        private void Remove() {
            if (CustomDialog.ShowDeletionConfirmation("Remove")) {
                foreach (DataGridViewRow row in GridView.SelectedRows) {
                    UpdateableItems.Remove(row.Tag as UpdateableItem);
                }

                LoadDialog();
            }
        }
    }
}
