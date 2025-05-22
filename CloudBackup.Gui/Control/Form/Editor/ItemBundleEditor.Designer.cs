namespace CloudBackup.Gui {
    partial class ItemBundleEditor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemBundleEditor));
            this.FolderCol = new CustomDialogs.TextAndImageColumn();
            this.FilesCol = new CustomDialogs.TextAndImageColumn();
            this.FileGridView = new CustomDialogs.DarkDataGridView();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.OpenFilesView = new System.Windows.Forms.Button();
            this.OpenFoldersView = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FolderGridView = new CustomDialogs.DarkDataGridView();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.AddFilesButton = new CustomDialogs.DarkButton();
            this.AddFoldersButton = new CustomDialogs.DarkButton();
            this.ItemCancelButton = new CustomDialogs.DarkButton();
            this.SaveButton = new CustomDialogs.DarkButton();
            this.RemoveFiles = new System.Windows.Forms.LinkLabel();
            this.RemoveFoldersLink = new System.Windows.Forms.LinkLabel();
            this.NameLabel = new CustomDialogs.DarkLabel();
            this.NameTextBox = new CustomDialogs.DarkTextBox();
            this.PasswordLinkEditor = new CloudBackup.Gui.PasswordLinkEditor();
            ((System.ComponentModel.ISupportInitialize)(this.FileGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FolderCol
            // 
            this.FolderCol.AlignmentToRight = false;
            this.FolderCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FolderCol.HeaderText = "Folders";
            this.FolderCol.Image = null;
            this.FolderCol.Name = "FolderCol";
            this.FolderCol.ReadOnly = true;
            // 
            // FilesCol
            // 
            this.FilesCol.AlignmentToRight = false;
            this.FilesCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FilesCol.HeaderText = "Files";
            this.FilesCol.Image = null;
            this.FilesCol.Name = "FilesCol";
            this.FilesCol.ReadOnly = true;
            // 
            // FileGridView
            // 
            this.FileGridView.AllowUserToAddRows = false;
            this.FileGridView.AllowUserToDeleteRows = false;
            this.FileGridView.AllowUserToOrderColumns = true;
            this.FileGridView.AllowUserToResizeRows = false;
            this.FileGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FileGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileGridView.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FileGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FileGridView.CellForeColor = System.Drawing.SystemColors.HighlightText;
            this.FileGridView.CellGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.FileGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FileGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilesCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FileGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.FileGridView.EnableHeadersVisualStyles = false;
            this.FileGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.FileGridView.Location = new System.Drawing.Point(311, 14);
            this.FileGridView.Name = "FileGridView";
            this.FileGridView.ReadOnly = true;
            this.FileGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FileGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.FileGridView.RowTemplate.Height = 23;
            this.FileGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FileGridView.Size = new System.Drawing.Size(289, 150);
            this.FileGridView.TabIndex = 31;
            // 
            // OpenFilesView
            // 
            this.OpenFilesView.FlatAppearance.BorderSize = 0;
            this.OpenFilesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFilesView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.OpenFilesView.Image = global::CloudBackup.Gui.Properties.Resources._16pxZoom;
            this.OpenFilesView.Location = new System.Drawing.Point(403, 170);
            this.OpenFilesView.Name = "OpenFilesView";
            this.OpenFilesView.Size = new System.Drawing.Size(25, 25);
            this.OpenFilesView.TabIndex = 30;
            this.ToolTip.SetToolTip(this.OpenFilesView, "Open expanded file view");
            this.OpenFilesView.UseVisualStyleBackColor = true;
            this.OpenFilesView.Click += new System.EventHandler(this.OpenFilesView_Click);
            // 
            // OpenFoldersView
            // 
            this.OpenFoldersView.FlatAppearance.BorderSize = 0;
            this.OpenFoldersView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFoldersView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.OpenFoldersView.Image = global::CloudBackup.Gui.Properties.Resources._16pxZoom;
            this.OpenFoldersView.Location = new System.Drawing.Point(105, 170);
            this.OpenFoldersView.Name = "OpenFoldersView";
            this.OpenFoldersView.Size = new System.Drawing.Size(25, 25);
            this.OpenFoldersView.TabIndex = 29;
            this.ToolTip.SetToolTip(this.OpenFoldersView, "Open expanded folder view");
            this.OpenFoldersView.UseVisualStyleBackColor = true;
            this.OpenFoldersView.Click += new System.EventHandler(this.OpenFoldersView_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Multiselect = true;
            // 
            // FolderGridView
            // 
            this.FolderGridView.AllowUserToAddRows = false;
            this.FolderGridView.AllowUserToDeleteRows = false;
            this.FolderGridView.AllowUserToOrderColumns = true;
            this.FolderGridView.AllowUserToResizeRows = false;
            this.FolderGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FolderGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FolderGridView.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FolderGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FolderGridView.CellForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderGridView.CellGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.FolderGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FolderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FolderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FolderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FolderCol});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FolderGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.FolderGridView.EnableHeadersVisualStyles = false;
            this.FolderGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.FolderGridView.Location = new System.Drawing.Point(13, 14);
            this.FolderGridView.Name = "FolderGridView";
            this.FolderGridView.ReadOnly = true;
            this.FolderGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FolderGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.FolderGridView.RowTemplate.Height = 23;
            this.FolderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FolderGridView.Size = new System.Drawing.Size(289, 150);
            this.FolderGridView.TabIndex = 32;
            // 
            // AddFilesButton
            // 
            this.AddFilesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.AddFilesButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.AddFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFilesButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddFilesButton.Location = new System.Drawing.Point(312, 169);
            this.AddFilesButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddFilesButton.Name = "AddFilesButton";
            this.AddFilesButton.Size = new System.Drawing.Size(87, 25);
            this.AddFilesButton.TabIndex = 28;
            this.AddFilesButton.Text = "Add files";
            this.AddFilesButton.UseVisualStyleBackColor = false;
            this.AddFilesButton.Click += new System.EventHandler(this.AddFilesButton_Click);
            // 
            // AddFoldersButton
            // 
            this.AddFoldersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.AddFoldersButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.AddFoldersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFoldersButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddFoldersButton.Location = new System.Drawing.Point(14, 169);
            this.AddFoldersButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddFoldersButton.Name = "AddFoldersButton";
            this.AddFoldersButton.Size = new System.Drawing.Size(87, 25);
            this.AddFoldersButton.TabIndex = 27;
            this.AddFoldersButton.Text = "Add folders";
            this.AddFoldersButton.UseVisualStyleBackColor = false;
            this.AddFoldersButton.Click += new System.EventHandler(this.AddFoldersButton_Click);
            // 
            // ItemCancelButton
            // 
            this.ItemCancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ItemCancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ItemCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemCancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ItemCancelButton.Location = new System.Drawing.Point(101, 274);
            this.ItemCancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.ItemCancelButton.Name = "ItemCancelButton";
            this.ItemCancelButton.Size = new System.Drawing.Size(75, 25);
            this.ItemCancelButton.TabIndex = 26;
            this.ItemCancelButton.Text = "Cancel";
            this.ItemCancelButton.UseVisualStyleBackColor = false;
            this.ItemCancelButton.Click += new System.EventHandler(this.ItemCancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SaveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Image = global::CloudBackup.Gui.Properties.Resources._16pxSave;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.Location = new System.Drawing.Point(14, 274);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.SaveButton.Size = new System.Drawing.Size(75, 25);
            this.SaveButton.TabIndex = 25;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RemoveFiles
            // 
            this.RemoveFiles.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.RemoveFiles.AutoSize = true;
            this.RemoveFiles.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFiles.Location = new System.Drawing.Point(547, 167);
            this.RemoveFiles.Name = "RemoveFiles";
            this.RemoveFiles.Size = new System.Drawing.Size(50, 15);
            this.RemoveFiles.TabIndex = 24;
            this.RemoveFiles.TabStop = true;
            this.RemoveFiles.Text = "Remove";
            this.RemoveFiles.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFiles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RemoveFiles_LinkClicked);
            // 
            // RemoveFoldersLink
            // 
            this.RemoveFoldersLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.RemoveFoldersLink.AutoSize = true;
            this.RemoveFoldersLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFoldersLink.Location = new System.Drawing.Point(249, 167);
            this.RemoveFoldersLink.Name = "RemoveFoldersLink";
            this.RemoveFoldersLink.Size = new System.Drawing.Size(50, 15);
            this.RemoveFoldersLink.TabIndex = 23;
            this.RemoveFoldersLink.TabStop = true;
            this.RemoveFoldersLink.Text = "Remove";
            this.RemoveFoldersLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFoldersLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RemoveFoldersLink_LinkClicked);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameLabel.Location = new System.Drawing.Point(10, 210);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 22;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.Location = new System.Drawing.Point(14, 227);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ReadOnly = false;
            this.NameTextBox.Size = new System.Drawing.Size(285, 25);
            this.NameTextBox.TabIndex = 21;
            this.NameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.XOffset = 0;
            this.NameTextBox.YOffset = 0;
            // 
            // PasswordLinkEditor
            // 
            this.PasswordLinkEditor.AutoSize = true;
            this.PasswordLinkEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PasswordLinkEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PasswordLinkEditor.DisplayName = "PasswordLinkEditor";
            this.PasswordLinkEditor.Link = null;
            this.PasswordLinkEditor.Location = new System.Drawing.Point(309, 224);
            this.PasswordLinkEditor.Name = "PasswordLinkEditor";
            this.PasswordLinkEditor.Password = null;
            this.PasswordLinkEditor.Size = new System.Drawing.Size(257, 28);
            this.PasswordLinkEditor.TabIndex = 33;
            // 
            // ItemBundleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(611, 312);
            this.Controls.Add(this.PasswordLinkEditor);
            this.Controls.Add(this.FileGridView);
            this.Controls.Add(this.OpenFilesView);
            this.Controls.Add(this.OpenFoldersView);
            this.Controls.Add(this.FolderGridView);
            this.Controls.Add(this.AddFilesButton);
            this.Controls.Add(this.AddFoldersButton);
            this.Controls.Add(this.ItemCancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RemoveFiles);
            this.Controls.Add(this.RemoveFoldersLink);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ItemBundleEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item bundle editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemBundleEditor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.FileGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDialogs.TextAndImageColumn FolderCol;
        private CustomDialogs.TextAndImageColumn FilesCol;
        private CustomDialogs.DarkDataGridView FileGridView;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button OpenFilesView;
        private System.Windows.Forms.Button OpenFoldersView;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private CustomDialogs.DarkDataGridView FolderGridView;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private CustomDialogs.DarkButton AddFilesButton;
        private CustomDialogs.DarkButton AddFoldersButton;
        private CustomDialogs.DarkButton ItemCancelButton;
        private CustomDialogs.DarkButton SaveButton;
        private System.Windows.Forms.LinkLabel RemoveFiles;
        private System.Windows.Forms.LinkLabel RemoveFoldersLink;
        private CustomDialogs.DarkLabel NameLabel;
        private CustomDialogs.DarkTextBox NameTextBox;
        private PasswordLinkEditor PasswordLinkEditor;
    }
}