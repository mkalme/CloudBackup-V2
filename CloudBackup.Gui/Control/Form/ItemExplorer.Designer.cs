
namespace CloudBackup.Gui {
    partial class ItemExplorer {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemExplorer));
            CustomDialogs.CustomToolStripRenderer customToolStripRenderer1 = new CustomDialogs.CustomToolStripRenderer();
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.BottomContainer = new System.Windows.Forms.TableLayoutPanel();
            this.MoreButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DeselectSeperatorLabel = new CustomDialogs.DarkLabel();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.UpDownSeperator = new CustomDialogs.DarkLabel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SettingsSeperator = new CustomDialogs.DarkLabel();
            this.SyncStatusLabel = new System.Windows.Forms.Label();
            this.DeselectButton = new System.Windows.Forms.Button();
            this.InformationSeperator = new CustomDialogs.DarkLabel();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.ChangeKeyButton = new System.Windows.Forms.Button();
            this.InformationButton = new System.Windows.Forms.Button();
            this.MenuStrip = new CustomDialogs.DarkContextMenuStrip(this.components);
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGroupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGroupSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.NewFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFilteredFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewItemBundleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.OpenInNewWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenInNewWindowSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.ChangePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeLinkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeLinkSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.MoveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.PropertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoreMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StorageProviderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloudServiceProviderSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.DownloadUsersheetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateSchemesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GlobalContainer.SuspendLayout();
            this.BottomContainer.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.MoreMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.BottomContainer, 0, 1);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(2, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.Padding = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.GlobalContainer.RowCount = 2;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.Size = new System.Drawing.Size(733, 428);
            this.GlobalContainer.TabIndex = 4;
            // 
            // BottomContainer
            // 
            this.BottomContainer.AutoSize = true;
            this.BottomContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BottomContainer.ColumnCount = 13;
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.Controls.Add(this.MoreButton, 1, 0);
            this.BottomContainer.Controls.Add(this.CloseButton, 12, 0);
            this.BottomContainer.Controls.Add(this.DeselectSeperatorLabel, 10, 0);
            this.BottomContainer.Controls.Add(this.MoveUpButton, 5, 0);
            this.BottomContainer.Controls.Add(this.UpDownSeperator, 4, 0);
            this.BottomContainer.Controls.Add(this.SettingsButton, 3, 0);
            this.BottomContainer.Controls.Add(this.SettingsSeperator, 2, 0);
            this.BottomContainer.Controls.Add(this.SyncStatusLabel, 0, 0);
            this.BottomContainer.Controls.Add(this.DeselectButton, 11, 0);
            this.BottomContainer.Controls.Add(this.InformationSeperator, 7, 0);
            this.BottomContainer.Controls.Add(this.MoveDownButton, 6, 0);
            this.BottomContainer.Controls.Add(this.ChangeKeyButton, 9, 0);
            this.BottomContainer.Controls.Add(this.InformationButton, 8, 0);
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomContainer.Location = new System.Drawing.Point(7, 402);
            this.BottomContainer.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.RowCount = 1;
            this.BottomContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomContainer.Size = new System.Drawing.Size(719, 23);
            this.BottomContainer.TabIndex = 4;
            // 
            // MoreButton
            // 
            this.MoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoreButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoreButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MoreButton.Image = ((System.Drawing.Image)(resources.GetObject("MoreButton.Image")));
            this.MoreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MoreButton.Location = new System.Drawing.Point(197, 0);
            this.MoreButton.Margin = new System.Windows.Forms.Padding(0);
            this.MoreButton.Name = "MoreButton";
            this.MoreButton.Size = new System.Drawing.Size(62, 23);
            this.MoreButton.TabIndex = 22;
            this.MoreButton.Text = "More";
            this.MoreButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoreButton.UseVisualStyleBackColor = true;
            this.MoreButton.Click += new System.EventHandler(this.MoreButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(654, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(65, 23);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DeselectSeperatorLabel
            // 
            this.DeselectSeperatorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeselectSeperatorLabel.AutoSize = true;
            this.DeselectSeperatorLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.DeselectSeperatorLabel.Location = new System.Drawing.Point(607, 3);
            this.DeselectSeperatorLabel.Margin = new System.Windows.Forms.Padding(9, 0, 7, 1);
            this.DeselectSeperatorLabel.Name = "DeselectSeperatorLabel";
            this.DeselectSeperatorLabel.Size = new System.Drawing.Size(10, 15);
            this.DeselectSeperatorLabel.TabIndex = 8;
            this.DeselectSeperatorLabel.Text = "|";
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MoveUpButton.BackgroundImage = global::CloudBackup.Gui.Properties.Resources._16pxMoveUp;
            this.MoveUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MoveUpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MoveUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveUpButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveUpButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MoveUpButton.Location = new System.Drawing.Point(391, 0);
            this.MoveUpButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(23, 23);
            this.MoveUpButton.TabIndex = 14;
            this.MoveUpButton.UseVisualStyleBackColor = false;
            this.MoveUpButton.Click += new System.EventHandler(this.MoveUpButton_Click);
            // 
            // UpDownSeperator
            // 
            this.UpDownSeperator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpDownSeperator.AutoSize = true;
            this.UpDownSeperator.ForeColor = System.Drawing.Color.DarkGray;
            this.UpDownSeperator.Location = new System.Drawing.Point(373, 3);
            this.UpDownSeperator.Margin = new System.Windows.Forms.Padding(9, 0, 8, 1);
            this.UpDownSeperator.Name = "UpDownSeperator";
            this.UpDownSeperator.Size = new System.Drawing.Size(10, 15);
            this.UpDownSeperator.TabIndex = 15;
            this.UpDownSeperator.Text = "|";
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettingsButton.Location = new System.Drawing.Point(286, 0);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(78, 23);
            this.SettingsButton.TabIndex = 16;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // SettingsSeperator
            // 
            this.SettingsSeperator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SettingsSeperator.AutoSize = true;
            this.SettingsSeperator.ForeColor = System.Drawing.Color.DarkGray;
            this.SettingsSeperator.Location = new System.Drawing.Point(268, 3);
            this.SettingsSeperator.Margin = new System.Windows.Forms.Padding(9, 0, 8, 1);
            this.SettingsSeperator.Name = "SettingsSeperator";
            this.SettingsSeperator.Size = new System.Drawing.Size(10, 15);
            this.SettingsSeperator.TabIndex = 21;
            this.SettingsSeperator.Text = "|";
            // 
            // SyncStatusLabel
            // 
            this.SyncStatusLabel.AutoSize = true;
            this.SyncStatusLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SyncStatusLabel.Location = new System.Drawing.Point(3, 0);
            this.SyncStatusLabel.Name = "SyncStatusLabel";
            this.SyncStatusLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.SyncStatusLabel.Size = new System.Drawing.Size(0, 19);
            this.SyncStatusLabel.TabIndex = 23;
            // 
            // DeselectButton
            // 
            this.DeselectButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeselectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeselectButton.BackgroundImage")));
            this.DeselectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeselectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DeselectButton.FlatAppearance.BorderSize = 0;
            this.DeselectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeselectButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeselectButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeselectButton.Location = new System.Drawing.Point(624, 0);
            this.DeselectButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.DeselectButton.Name = "DeselectButton";
            this.DeselectButton.Size = new System.Drawing.Size(23, 23);
            this.DeselectButton.TabIndex = 11;
            this.DeselectButton.UseVisualStyleBackColor = false;
            this.DeselectButton.Click += new System.EventHandler(this.DeselectButton_Click);
            // 
            // InformationSeperator
            // 
            this.InformationSeperator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InformationSeperator.AutoSize = true;
            this.InformationSeperator.ForeColor = System.Drawing.Color.DarkGray;
            this.InformationSeperator.Location = new System.Drawing.Point(453, 3);
            this.InformationSeperator.Margin = new System.Windows.Forms.Padding(9, 0, 7, 1);
            this.InformationSeperator.Name = "InformationSeperator";
            this.InformationSeperator.Size = new System.Drawing.Size(10, 15);
            this.InformationSeperator.TabIndex = 24;
            this.InformationSeperator.Text = "|";
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MoveDownButton.BackgroundImage = global::CloudBackup.Gui.Properties.Resources._16pxMoveDown;
            this.MoveDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MoveDownButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MoveDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveDownButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveDownButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MoveDownButton.Location = new System.Drawing.Point(421, 0);
            this.MoveDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(23, 23);
            this.MoveDownButton.TabIndex = 25;
            this.MoveDownButton.UseVisualStyleBackColor = false;
            this.MoveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // ChangeKeyButton
            // 
            this.ChangeKeyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ChangeKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeKeyButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeKeyButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangeKeyButton.Image = global::CloudBackup.Gui.Properties.Resources._16pxKey;
            this.ChangeKeyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeKeyButton.Location = new System.Drawing.Point(500, 0);
            this.ChangeKeyButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChangeKeyButton.Name = "ChangeKeyButton";
            this.ChangeKeyButton.Size = new System.Drawing.Size(98, 23);
            this.ChangeKeyButton.TabIndex = 26;
            this.ChangeKeyButton.Text = "Change key";
            this.ChangeKeyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeKeyButton.UseVisualStyleBackColor = true;
            this.ChangeKeyButton.Click += new System.EventHandler(this.ChangeKeyButton_Click);
            // 
            // InformationButton
            // 
            this.InformationButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InformationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InformationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.InformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InformationButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InformationButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.InformationButton.Image = global::CloudBackup.Gui.Properties.Resources._16pxInformation;
            this.InformationButton.Location = new System.Drawing.Point(470, 0);
            this.InformationButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(23, 23);
            this.InformationButton.TabIndex = 27;
            this.InformationButton.UseVisualStyleBackColor = false;
            this.InformationButton.Click += new System.EventHandler(this.InformationButton_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            customToolStripRenderer1.RoundedEdges = true;
            this.MenuStrip.CustomRenderer = customToolStripRenderer1;
            this.MenuStrip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.NewSeperator,
            this.OpenInNewWindowMenuItem,
            this.OpenInNewWindowSeperator,
            this.UpdateMenuItem,
            this.DownloadMenuItem,
            this.DownloadSeperator,
            this.ChangePasswordMenuItem,
            this.ChangeLinkMenuItem,
            this.ChangeLinkSeperator,
            this.CopyMenuItem,
            this.PasteMenuItem,
            this.PasteSeperator,
            this.MoveMenuItem,
            this.EditMenuItem,
            this.RenameMenuItem,
            this.DeleteMenuItem,
            this.DeleteSeperator,
            this.PropertiesMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(201, 326);
            this.MenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MenuStrip_Opening);
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGroupMenuItem,
            this.NewGroupSeperator,
            this.NewFolderMenuItem,
            this.NewFilteredFolderMenuItem,
            this.NewItemBundleMenuItem});
            this.NewMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxAdd;
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(200, 22);
            this.NewMenuItem.Text = "New                                  ";
            // 
            // NewGroupMenuItem
            // 
            this.NewGroupMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._64pxMenuStripGroup;
            this.NewGroupMenuItem.Name = "NewGroupMenuItem";
            this.NewGroupMenuItem.Size = new System.Drawing.Size(200, 22);
            this.NewGroupMenuItem.Text = "Group                               ";
            this.NewGroupMenuItem.Click += new System.EventHandler(this.NewGroupMenuItem_Click);
            // 
            // NewGroupSeperator
            // 
            this.NewGroupSeperator.Name = "NewGroupSeperator";
            this.NewGroupSeperator.Size = new System.Drawing.Size(197, 6);
            // 
            // NewFolderMenuItem
            // 
            this.NewFolderMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._64pxFolderClosed;
            this.NewFolderMenuItem.Name = "NewFolderMenuItem";
            this.NewFolderMenuItem.Size = new System.Drawing.Size(200, 22);
            this.NewFolderMenuItem.Text = "Folder";
            this.NewFolderMenuItem.Click += new System.EventHandler(this.NewFolderMenuItem_Click);
            // 
            // NewFilteredFolderMenuItem
            // 
            this.NewFilteredFolderMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._64pxFilteredFolder;
            this.NewFilteredFolderMenuItem.Name = "NewFilteredFolderMenuItem";
            this.NewFilteredFolderMenuItem.Size = new System.Drawing.Size(200, 22);
            this.NewFilteredFolderMenuItem.Text = "Filtered folder";
            this.NewFilteredFolderMenuItem.Click += new System.EventHandler(this.NewFilteredFolderMenuItem_Click);
            // 
            // NewItemBundleMenuItem
            // 
            this.NewItemBundleMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._64pxItemBundle;
            this.NewItemBundleMenuItem.Name = "NewItemBundleMenuItem";
            this.NewItemBundleMenuItem.Size = new System.Drawing.Size(200, 22);
            this.NewItemBundleMenuItem.Text = "Item bundle";
            this.NewItemBundleMenuItem.Click += new System.EventHandler(this.NewItemBundleMenuItem_Click);
            // 
            // NewSeperator
            // 
            this.NewSeperator.Name = "NewSeperator";
            this.NewSeperator.Size = new System.Drawing.Size(197, 6);
            // 
            // OpenInNewWindowMenuItem
            // 
            this.OpenInNewWindowMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxApplication;
            this.OpenInNewWindowMenuItem.Name = "OpenInNewWindowMenuItem";
            this.OpenInNewWindowMenuItem.Size = new System.Drawing.Size(200, 22);
            this.OpenInNewWindowMenuItem.Text = "Open in new window";
            this.OpenInNewWindowMenuItem.Click += new System.EventHandler(this.OpenInNewWindowMenuItem_Click);
            // 
            // OpenInNewWindowSeperator
            // 
            this.OpenInNewWindowSeperator.Name = "OpenInNewWindowSeperator";
            this.OpenInNewWindowSeperator.Size = new System.Drawing.Size(197, 6);
            // 
            // UpdateMenuItem
            // 
            this.UpdateMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxCloudUpload;
            this.UpdateMenuItem.Name = "UpdateMenuItem";
            this.UpdateMenuItem.Size = new System.Drawing.Size(200, 22);
            this.UpdateMenuItem.Text = "Update";
            this.UpdateMenuItem.Click += new System.EventHandler(this.UpdateMenuItem_Click);
            // 
            // DownloadMenuItem
            // 
            this.DownloadMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxDownload;
            this.DownloadMenuItem.Name = "DownloadMenuItem";
            this.DownloadMenuItem.Size = new System.Drawing.Size(200, 22);
            this.DownloadMenuItem.Text = "Download";
            this.DownloadMenuItem.Click += new System.EventHandler(this.DownloadMenuItem_Click);
            // 
            // DownloadSeperator
            // 
            this.DownloadSeperator.Name = "DownloadSeperator";
            this.DownloadSeperator.Size = new System.Drawing.Size(197, 6);
            // 
            // ChangePasswordMenuItem
            // 
            this.ChangePasswordMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxPasswordStrength;
            this.ChangePasswordMenuItem.Name = "ChangePasswordMenuItem";
            this.ChangePasswordMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ChangePasswordMenuItem.Text = "Change password";
            this.ChangePasswordMenuItem.Click += new System.EventHandler(this.ChangePasswordMenuItem_Click);
            // 
            // ChangeLinkMenuItem
            // 
            this.ChangeLinkMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxLink;
            this.ChangeLinkMenuItem.Name = "ChangeLinkMenuItem";
            this.ChangeLinkMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ChangeLinkMenuItem.Text = "Change link";
            this.ChangeLinkMenuItem.Click += new System.EventHandler(this.ChangeLinkMenuItem_Click);
            // 
            // ChangeLinkSeperator
            // 
            this.ChangeLinkSeperator.Name = "ChangeLinkSeperator";
            this.ChangeLinkSeperator.Size = new System.Drawing.Size(197, 6);
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxCopyItem;
            this.CopyMenuItem.Name = "CopyMenuItem";
            this.CopyMenuItem.Size = new System.Drawing.Size(200, 22);
            this.CopyMenuItem.Text = "Copy";
            this.CopyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // PasteMenuItem
            // 
            this.PasteMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxPaste;
            this.PasteMenuItem.Name = "PasteMenuItem";
            this.PasteMenuItem.Size = new System.Drawing.Size(200, 22);
            this.PasteMenuItem.Text = "Paste";
            this.PasteMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
            // 
            // PasteSeperator
            // 
            this.PasteSeperator.Name = "PasteSeperator";
            this.PasteSeperator.Size = new System.Drawing.Size(197, 6);
            // 
            // MoveMenuItem
            // 
            this.MoveMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._64pxRename;
            this.MoveMenuItem.Name = "MoveMenuItem";
            this.MoveMenuItem.Size = new System.Drawing.Size(200, 22);
            this.MoveMenuItem.Text = "Move";
            this.MoveMenuItem.Click += new System.EventHandler(this.MoveMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxEdit;
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(200, 22);
            this.EditMenuItem.Text = "Edit";
            this.EditMenuItem.Click += new System.EventHandler(this.EditMenuItem_Click);
            // 
            // RenameMenuItem
            // 
            this.RenameMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxRename;
            this.RenameMenuItem.Name = "RenameMenuItem";
            this.RenameMenuItem.Size = new System.Drawing.Size(200, 22);
            this.RenameMenuItem.Text = "Rename";
            this.RenameMenuItem.Click += new System.EventHandler(this.RenameMenuItem_Click);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxTrash;
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.Size = new System.Drawing.Size(200, 22);
            this.DeleteMenuItem.Text = "Delete";
            this.DeleteMenuItem.Click += new System.EventHandler(this.DeleteMenuItem_Click);
            // 
            // DeleteSeperator
            // 
            this.DeleteSeperator.Name = "DeleteSeperator";
            this.DeleteSeperator.Size = new System.Drawing.Size(197, 6);
            // 
            // PropertiesMenuItem
            // 
            this.PropertiesMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxProperty;
            this.PropertiesMenuItem.Name = "PropertiesMenuItem";
            this.PropertiesMenuItem.Size = new System.Drawing.Size(200, 22);
            this.PropertiesMenuItem.Text = "Properties";
            this.PropertiesMenuItem.Click += new System.EventHandler(this.PropertiesMenuItem_Click);
            // 
            // MoreMenuStrip
            // 
            this.MoreMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StorageProviderMenuItem,
            this.CloudServiceProviderSeparator,
            this.DownloadUsersheetMenuItem,
            this.UpdateSchemesMenuItem});
            this.MoreMenuStrip.Name = "MoreMenuStrip";
            this.MoreMenuStrip.Size = new System.Drawing.Size(194, 76);
            // 
            // StorageProviderMenuItem
            // 
            this.StorageProviderMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.StorageProviderMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.StorageProviderMenuItem.Name = "StorageProviderMenuItem";
            this.StorageProviderMenuItem.Size = new System.Drawing.Size(193, 22);
            this.StorageProviderMenuItem.Text = "Cloud Service Provider";
            // 
            // CloudServiceProviderSeparator
            // 
            this.CloudServiceProviderSeparator.Name = "CloudServiceProviderSeparator";
            this.CloudServiceProviderSeparator.Size = new System.Drawing.Size(190, 6);
            // 
            // DownloadUsersheetMenuItem
            // 
            this.DownloadUsersheetMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DownloadUsersheetMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DownloadUsersheetMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxExportToExcel;
            this.DownloadUsersheetMenuItem.Name = "DownloadUsersheetMenuItem";
            this.DownloadUsersheetMenuItem.Size = new System.Drawing.Size(193, 22);
            this.DownloadUsersheetMenuItem.Text = "Download usersheet";
            this.DownloadUsersheetMenuItem.Click += new System.EventHandler(this.DownloadUsersheetMenuItem_Click);
            // 
            // UpdateSchemesMenuItem
            // 
            this.UpdateSchemesMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.UpdateSchemesMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UpdateSchemesMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxCloudUpload;
            this.UpdateSchemesMenuItem.Name = "UpdateSchemesMenuItem";
            this.UpdateSchemesMenuItem.Size = new System.Drawing.Size(193, 22);
            this.UpdateSchemesMenuItem.Text = "Update schemes";
            this.UpdateSchemesMenuItem.Click += new System.EventHandler(this.UpdateSchemesMenuItem_Click);
            // 
            // ItemExplorer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(737, 428);
            this.Controls.Add(this.GlobalContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemExplorer";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemExplorer_FormClosing);
            this.Load += new System.EventHandler(this.ItemExplorer_Load);
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.BottomContainer.ResumeLayout(false);
            this.BottomContainer.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MoreMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.TableLayoutPanel BottomContainer;
        private System.Windows.Forms.Button MoreButton;
        private System.Windows.Forms.Button CloseButton;
        private CustomDialogs.DarkLabel DeselectSeperatorLabel;
        private System.Windows.Forms.Button MoveUpButton;
        private CustomDialogs.DarkLabel UpDownSeperator;
        private System.Windows.Forms.Button SettingsButton;
        private CustomDialogs.DarkLabel SettingsSeperator;
        private System.Windows.Forms.Label SyncStatusLabel;
        private System.Windows.Forms.Button DeselectButton;
        private CustomDialogs.DarkLabel InformationSeperator;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Button ChangeKeyButton;
        private System.Windows.Forms.Button InformationButton;
        private CustomDialogs.DarkContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGroupMenuItem;
        private System.Windows.Forms.ToolStripSeparator NewGroupSeperator;
        private System.Windows.Forms.ToolStripMenuItem NewFolderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewFilteredFolderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewItemBundleMenuItem;
        private System.Windows.Forms.ToolStripSeparator NewSeperator;
        private System.Windows.Forms.ToolStripMenuItem OpenInNewWindowMenuItem;
        private System.Windows.Forms.ToolStripSeparator OpenInNewWindowSeperator;
        private System.Windows.Forms.ToolStripMenuItem UpdateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DownloadMenuItem;
        private System.Windows.Forms.ToolStripSeparator DownloadSeperator;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeLinkMenuItem;
        private System.Windows.Forms.ToolStripSeparator ChangeLinkSeperator;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteMenuItem;
        private System.Windows.Forms.ToolStripSeparator PasteSeperator;
        private System.Windows.Forms.ToolStripMenuItem MoveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
        private System.Windows.Forms.ToolStripSeparator DeleteSeperator;
        private System.Windows.Forms.ToolStripMenuItem PropertiesMenuItem;
        private System.Windows.Forms.ContextMenuStrip MoreMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem StorageProviderMenuItem;
        private System.Windows.Forms.ToolStripSeparator CloudServiceProviderSeparator;
        private System.Windows.Forms.ToolStripMenuItem UpdateSchemesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DownloadUsersheetMenuItem;
    }
}
