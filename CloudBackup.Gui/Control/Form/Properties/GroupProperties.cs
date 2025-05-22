using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class GroupProperties : Form {
        public Group Group { get; }
        public Usersheet Usersheet { get; }
        
        public GroupProperties(Group group, Usersheet usersheet) {
            InitializeComponent();

            Group = group;
            Usersheet = usersheet;

            Icon = ImageToIconConverter.Convert(Group.GetIcon(), 64, 64);

            LoadDialog();
        }

        private void LoadDialog() {
            NameTextBox.Text = Group.Name;
            LocationTextBox.Text = Group.Parent?.GetPath();

            int groupA = CountGroups(Group);
            int folderA = CountUpdateableItems(Group, typeof(Folder));
            int filteredFolderA = CountUpdateableItems(Group, typeof(FilteredFolder));
            int fileFileBundleA = CountUpdateableItems(Group, typeof(ItemBundle));

            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{groupA} group{(groupA != 1 ? "s" : "")}");
            builder.AppendLine($"{folderA} folder{(folderA != 1 ? "s" : "")}");
            builder.AppendLine($"{filteredFolderA} filtered folder{(filteredFolderA != 1 ? "s" : "")}");
            builder.Append($"{fileFileBundleA} file bundle{(fileFileBundleA != 1 ? "s" : "")}");

            ContainsRichTextBox.Text = builder.ToString();

            List<UpdateableItem> updateableItems = new List<UpdateableItem>();
            Group.Items.GetUpdateableItems(updateableItems);

            long size = updateableItems.GetSize(Usersheet);
            SizeTextBox.Text = $"{size.ConvertToStorage()} ({size.ToString("N0")} bytes)";

            CreationDateTextBox.Text = Group.CreationDate.ToPropertyString();
            ModifiedTextBox.Text = Group.LastModificationDate.ToPropertyString();

            CloseButton.Select();
        }

        private static int CountGroups(Group group) {
            int output = 0;

            foreach (var item in group.Items) {
                if (item.GetType() == typeof(Group)) {
                    output += 1 + CountGroups(item as Group);
                }
            }

            return output;
        }
        private static int CountUpdateableItems(Group group, Type type) {
            int output = 0;

            foreach (var item in group.Items) {
                if (item.GetType() == type) {
                    output++;
                } else if (item.GetType() == typeof(Group)) {
                    output += CountUpdateableItems(item as Group, type);
                }
            }

            return output;
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
