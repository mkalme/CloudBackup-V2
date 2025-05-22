using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class ItemGridControl : DataGridViewControl {
        public ViewController ViewController { get; set; }
        public Usersheet Usersheet { get; set; }

        public ItemGridControl(Usersheet usersheet, ViewController viewController) {
            Initialize();

            Usersheet = usersheet;
            ViewController = viewController;
        }

        public override DataGridViewTextBoxColumn[] CreateColumns() {
            return new DataGridViewTextBoxColumn[] {
                new TextAndImageColumn(){
                    HeaderText = "Name",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    Width = 220
                },
                new TextAndImageColumn(){
                    HeaderText = "Id",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    AlignmentToRight = true,
                    Width = 280,
                    DefaultCellStyle = new DataGridViewCellStyle(){
                        Font = new Font("Consolas", 9),
                        ForeColor = Color.FromArgb(190, 190, 190),
                        Padding = new Padding(4, 1, 0, 0)
                    }
                },
                new DataGridViewTextBoxColumn(){
                    HeaderText = "Size",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    MinimumWidth = 85,
                    DefaultCellStyle = new DataGridViewCellStyle(){
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        ForeColor = Color.FromArgb(175, 175, 175),
                        Padding = new Padding(0, 0, 5, 0)
                    }
                },
                new TextAndImageColumn(){
                    HeaderText = "Last updated",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 120,
                    DefaultCellStyle = new DataGridViewCellStyle(){
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        Padding = new Padding(0, 0, 5, 0)
                    }
                }
            };
        }

        //Update
        private ImageCache _imageCache = new ImageCache();

        protected override bool SetRow(DataGridViewRow row, object item) {
            if (((Item)item).ID == ItemID.Group) SetGroupRow(row, item as Group);
            else SetUpdateableItemRow(row, item as UpdateableItem);

            return true;
        }

        private void SetGroupRow(DataGridViewRow row, Group group) {
            List<UpdateableItem> updateableItems = new List<UpdateableItem>();
            group.Items.GetUpdateableItems(updateableItems);

            row.SetValues(group.Name, group.GeneratedID, updateableItems.GetSize(Usersheet).ConvertToShortStorage());
            row.DisplayImage(DataGridView.Columns[0], _imageCache.GetImage(group.GetImageChacheKey(), group.GetIcon(), 22, 22), 27);
        }
        private void SetUpdateableItemRow(DataGridViewRow row, UpdateableItem item) {
            row.SetValues(item.Name, item.GeneratedID, new UpdateableItem[] { item }.GetSize(Usersheet).ConvertToShortStorage(), item.GetLastUpdatedString());

            ((TextAndImageCell)row.Cells[0]).XOffet = item.UpdateableItemID == UpdateableItemID.Folder || item.UpdateableItemID == UpdateableItemID.FilteredFolder ? 4 : 3;
            row.DisplayImage(DataGridView.Columns[0], _imageCache.GetImage(item.GetImageChacheKey(), item.GetIcon(), 16, 16), 27);

            if (!string.IsNullOrEmpty(item.Password)) {
                row.DisplayImage(DataGridView.Columns[1], Properties.Resources._16pxKey);
            }
        }

        //Double click
        protected override void GridDoubleClick(DataGridViewCellEventArgs e, object item) {
            ItemID id = ((Item)item).ID;

            if (id == ItemID.Group) {
                ViewController.OpenChild(item as Group);
            } else {
                ItemUtilities.EditItem(item as Item);
            }
        }
    }
}
