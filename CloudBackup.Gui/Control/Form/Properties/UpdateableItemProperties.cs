using System;
using System.Windows.Forms;
using System.Media;
using System.Linq;
using System.Collections.Generic;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class UpdateableItemProperties : Form {
        public UpdateableItem UpdateableItem { get; }

        public UpdateableItemProperties(UpdateableItem updateableItem) {
            InitializeComponent();

            UpdateableItem = updateableItem;
            Icon = ImageToIconConverter.Convert(UpdateableItem.GetIcon(), 64, 64);

            LoadDialog();
        }

        private void LoadDialog() {
            Text = UpdateableItem.GetTypeString();

            PictureBox.Image = UpdateableItem.GetIcon();
            NameTextBox.Text = UpdateableItem.Name;

            TypeTextBox.Text = UpdateableItem.GetTypeString();
            LocationTextBox.Text = UpdateableItem.Parent?.GetPath();

            long size =  new UpdateableItem[] { UpdateableItem }.GetSize(UpdateableItem.Application.Usersheet);
            SizeTextBox.Text = $"{size.ConvertToStorage()} ({size.ToString("N0")} bytes)";

            if (UpdateableItem.UpdateHistory.Dates.Count < 1) {
                LastUpdatedTextBox.Text = "Never";
            } else {
                DateTime date = UpdateableItem.UpdateHistory.Dates[UpdateableItem.UpdateHistory.Dates.Count - 1];

                LastUpdatedTextBox.Text = $"{date.ToPropertyString()} ({UpdateableItem.GetLastUpdatedString()})";
            }

            IdTextBox.Text = UpdateableItem.GeneratedID;
            PathInDriveTextBox.Text = UpdateableItem.GetPath();

            CreationDateTextBox.Text = UpdateableItem.CreationDate.ToPropertyString();
            ModifiedTextBox.Text = UpdateableItem.LastModificationDate.ToPropertyString();

            CloseButton.Select();
        }

        private void SeeFullLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            CustomDialog.ShowMessage($"ID | {UpdateableItem.Name}", UpdateableItem.GeneratedID);
        }
        private void CopyIdLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Clipboard.SetText(UpdateableItem.GeneratedID);
        }
        private void AcquireExistingID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            InputResult<IList<object>> selectionResult = ItemSelectorUtilities.ShowSelector(UpdateableItem.Parent, new ItemSelectorProfile() {
                SelectedItemValidator = i => ((Item)i).ID == ItemID.UpdateableItem
            }, thisItem => thisItem != UpdateableItem);

            if (selectionResult.DialogClosed || selectionResult.Value.Count < 1) return;
            if (((Item)selectionResult.Value.ElementAt(0)).ID == ItemID.Group) {
                CustomDialog.ShowError("Error", "Selected item must be updateable.");
                return;
            }

            string result = CustomDialog.ShowMessage($"ID Change | {UpdateableItem.Name}", "Are you sure you want to change the ID of this item?",
                Properties.Resources._64pxId, SystemSounds.Hand, "Yes", "No");

            if (result == "No" || result == "Closed") return;

            UpdateableItem updateableItem = selectionResult.Value[0] as UpdateableItem;
            UpdateableItem.ChangeID(updateableItem.GeneratedID);

            updateableItem.Parent.Items.Remove(updateableItem);

            LoadDialog();
        }

        private void UpdateHistoryButton_Click(object sender, EventArgs e) {
            CustomDialog.ShowDateListViewer(UpdateableItem.UpdateHistory.Dates, Properties.Resources._64pxCalendar, "Update history", "Update date");
        }

        private void OpenInBrowserLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ItemUtilities.OpenInBrowser(UpdateableItem.Link);
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
