using System;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.ComponentModel;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class ItemExplorer : Form {
        public GuiApplication GuiApplication { get; set; }
        public CloudApplication Application { get; set; }

        public Group CurrentGroup => CurrentView.ViewNode.Node as Group;
        public IView CurrentView => ViewControl.ViewController.CurrentView;

        public ItemGridControl GridControl { get; set; }
        public DataGridView GridView {
            get => GridControl.DataGridView;
        }

        public ViewControl ViewControl { get; set; }

        public ItemExplorer(GuiApplication guiApplication, CloudApplication application, Group group = null) {
            InitializeComponent();

            GuiApplication = guiApplication;
            Application = application;

            ViewController viewController = new ViewController(new GroupViewNode(group ?? Application.Group));
            GridControl = new ItemGridControl(Application.Usersheet, viewController);

            ViewControl = new ViewControl() {
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            StandardVerticalViewControl viewControl = new StandardVerticalViewControl(ViewControl, GridControl);
            viewControl.HeaderToolBar.ViewController = viewController;
            viewControl.HeaderToolBar.NodeCreator = item => new GroupNode(item as Group);

            ViewControl.Initialize(viewController, viewControl);
            GlobalContainer.Controls.Add(ViewControl, 0, 0);

            GridView.ContextMenuStrip = MenuStrip;

            MenuStrip.Renderer = new CustomToolStripRenderer(new CustomMenuStripColors() {
                BorderColor = Color.FromArgb(120, 120, 120),
                InnerBorderColor = Color.FromArgb(55, 55, 55),
                HoverColor = Color.FromArgb(70, 70, 70),
                DisabledHoverColor = Color.FromArgb(90, 90, 90)
            });

            MoreMenuStrip.Renderer = new CustomToolStripRenderer(new CustomMenuStripColors() {
                BackColor = Color.FromArgb(35, 35, 35),
                BorderColor = Color.FromArgb(80, 80, 80),
                InnerBorderColor = Color.FromArgb(35, 35, 35),
                HoverColor = Color.FromArgb(70, 70, 70),
                DisabledHoverColor = Color.FromArgb(90, 90, 90)
            });
            InitializeMoreMenuStrip();
        }

        //Load
        private void ItemExplorer_Load(object sender, EventArgs e) {
            ViewControl.UpdateView();
        }
        private void ItemExplorer_FormClosing(object sender, FormClosingEventArgs e) {
            ViewControl.ViewController.Dispose();
        }

        private void InitializeMoreMenuStrip() {
            StorageProviderMenuItem.Text = $"{Application.CloudServiceProvider.Name}     ";
            StorageProviderMenuItem.Image = Application.CloudServiceProvider.Icon;

            foreach (var command in Application.CloudServiceProvider.Commands) {
                ToolStripMenuItem dropdownItem = CreateMenuItem();

                dropdownItem.Text = command.Name;
                dropdownItem.Image = command.Image;
                dropdownItem.Click += (sender, e) => {
                    try {
                        command.Execute();
                    } catch (Exception exception) {
                        CustomDialog.ShowError(exception);
                    }
                };

                StorageProviderMenuItem.DropDown.Width = MoreMenuStrip.Width;
                StorageProviderMenuItem.DropDown.BackColor = Color.FromArgb(35, 35, 35);

                StorageProviderMenuItem.DropDownItems.Add(dropdownItem);
            }
        }
        private static ToolStripMenuItem CreateMenuItem() {
            return new ToolStripMenuItem() {
                BackColor = Color.FromArgb(35, 35, 35),
                ForeColor = SystemColors.HighlightText
            };
        }

        private void DownloadUsersheetMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.DownloadUsersheet(Application);
        }
        private void UpdateSchemesMenuItem_Click(object sender, EventArgs e) {
            new UpdateSchemesViewer(Application, GuiApplication).ShowDialog();
        }

        //Bottom buttons
        private void MoreButton_Click(object sender, EventArgs e) {
            Point lowerleft = new Point(0, MoreButton.Height);
            lowerleft = MoreButton.PointToScreen(lowerleft);
            lowerleft.Offset(-(MoreMenuStrip.Width - MoreButton.Width) / 2, -MoreButton.Height - MoreMenuStrip.Height - 5);

            MoreMenuStrip.Show(lowerleft);
        }

        private void SettingsButton_Click(object sender, EventArgs e) {
            new SettingsEditor(Application.Settings, GuiApplication.GuiSettings).ShowDialog();
        }

        private void MoveUpButton_Click(object sender, EventArgs e) {
            if (GridView.SelectedRows.Count < 1) return;

            CurrentGroup.MoveUp(CurrentView.SelectedItems.Cast<Item>().ToList());
        }
        private void MoveDownButton_Click(object sender, EventArgs e) {
            if (GridView.SelectedRows.Count < 1) return;

            CurrentGroup.MoveDown(CurrentView.SelectedItems.Cast<Item>().ToList());
        }

        private void InformationButton_Click(object sender, EventArgs e) {
            ItemUtilities.ShowInformation(GuiApplication);
        }
        private void ChangeKeyButton_Click(object sender, EventArgs e) {
            ItemUtilities.ChangeKey(GuiApplication);
        }

        private void DeselectButton_Click(object sender, EventArgs e) {
            GridView.ClearSelection();
        }
        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }

        //ContextMenuStrip
        private void MenuStrip_Opening(object sender, CancelEventArgs e) {
            Item item = GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item;

            bool onlyUpdateableItemSelected = item != null && item.ID == ItemID.UpdateableItem && CurrentView.SelectedItems.Count == 1;

            OpenInNewWindowMenuItem.Enabled = (item != null && item.ID != ItemID.UpdateableItem) || CurrentView.SelectedItems.Count < 1;

            UpdateMenuItem.Enabled = CurrentView.SelectedItems.Count > 0;
            DownloadMenuItem.Enabled = onlyUpdateableItemSelected;

            ChangePasswordMenuItem.Enabled = onlyUpdateableItemSelected;
            ChangeLinkMenuItem.Enabled = onlyUpdateableItemSelected;

            CopyMenuItem.Enabled = item != null;
            PasteMenuItem.Enabled = GuiApplication.Clipboard.CopiedItems.Count > 0;

            MoveMenuItem.Enabled = item != null && CurrentView.SelectedItems.Count > 0;
            EditMenuItem.Visible = onlyUpdateableItemSelected;
            RenameMenuItem.Enabled = CurrentView.SelectedItems.Count < 2;
            DeleteMenuItem.Enabled = item != null && CurrentView.SelectedItems.Count > 0;

            PropertiesMenuItem.Enabled = CurrentView.SelectedItems.Count < 2;
        }

        private void NewGroupMenuItem_Click(object sender, EventArgs e) {
            Group group = new Group() {
                Name = "New group",
            };

            AddNewItem(group);
        }
        private void NewFolderMenuItem_Click(object sender, EventArgs e) {
            Folder folder = new Folder(Application) {
                Name = "New folder",
            };

            if (GuiApplication.GuiSettings.DefaultPasswordLength > 0) {
                folder.Password = PasswordGeneratorDialogProfile.NewPassword.PasswordGenerator.Generate(GuiApplication.GuiSettings.DefaultPasswordLength);
            }

            AddNewItem(folder);
        }
        private void NewFilteredFolderMenuItem_Click(object sender, EventArgs e) {
            FilteredFolder filteredFolder = new FilteredFolder(Application) {
                Name = "New filtered folder",
            };

            if (GuiApplication.GuiSettings.DefaultPasswordLength > 0) {
                filteredFolder.Password = PasswordGeneratorDialogProfile.NewPassword.PasswordGenerator.Generate(GuiApplication.GuiSettings.DefaultPasswordLength);
            }

            AddNewItem(filteredFolder);
        }
        private void NewItemBundleMenuItem_Click(object sender, EventArgs e) {
            ItemBundle filteredFolder = new ItemBundle(Application) {
                Name = "New item bundle",
            };

            if (GuiApplication.GuiSettings.DefaultPasswordLength > 0) {
                filteredFolder.Password = PasswordGeneratorDialogProfile.NewPassword.PasswordGenerator.Generate(GuiApplication.GuiSettings.DefaultPasswordLength);
            }

            AddNewItem(filteredFolder);
        }

        private void OpenInNewWindowMenuItem_Click(object sender, EventArgs e) {
            Group group = GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Group;

            new ItemExplorer(GuiApplication, Application, group ?? CurrentGroup).Show();
        }

        private void UpdateMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.UpdateItems(CurrentView.SelectedItems.Cast<Item>().ToList(), GuiApplication.GuiSettings.ProgressBarColor);
        }
        private void DownloadMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.DownloadItem(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as UpdateableItem, GuiApplication.GuiSettings.ProgressBarColor);
        }

        private void ChangePasswordMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.ChangeUpdateableItemPassword(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as UpdateableItem);
        }
        private void ChangeLinkMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.ChangeItemLink(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as UpdateableItem);
        }

        private void CopyMenuItem_Click(object sender, EventArgs e) {
            GuiApplication.Clipboard.SetClipboard(CurrentView.SelectedItems.Cast<Item>().ToList());
        }
        private void PasteMenuItem_Click(object sender, EventArgs e) {
            Group parent = CurrentGroup;

            Item item = GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item;
            if (item != null && item.ID == ItemID.Group) parent = item as Group;

            ItemUtilities.Paste(GuiApplication.Clipboard.CopiedItems.Cast<Item>(), parent);
        }

        private void MoveMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.Move(CurrentView.SelectedItems.Cast<Item>().ToList(), CurrentGroup);
        }
        private void EditMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.EditItem(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item);
        }
        private void RenameMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.RenameItem(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item ?? CurrentGroup);
        }
        private void DeleteMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.Delete(CurrentView.SelectedItems.Cast<Item>().ToList(), CurrentGroup);
        }

        private void PropertiesMenuItem_Click(object sender, EventArgs e) {
            if (CurrentView.SelectedItems.Count < 1) {
                ItemUtilities.OpenGroupProperties(CurrentGroup, Application.Usersheet);
                return;
            }

            ItemUtilities.OpenProperties(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item, Application.Usersheet);
        }

        //Functions
        private void AddNewItem(Item item) {
            CurrentGroup.Items.Add(item);

            GridView.ClearSelection();
            GridControl.SelectRow(item);

            ItemUtilities.EditItem(item);
        }
    }
}
