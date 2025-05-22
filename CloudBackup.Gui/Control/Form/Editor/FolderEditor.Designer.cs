namespace CloudBackup.Gui {
    partial class FolderEditor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderEditor));
            this.PathLabel = new CustomDialogs.DarkLabel();
            this.BrowseButton = new CustomDialogs.DarkButton();
            this.PathTextBox = new CustomDialogs.DarkTextBox();
            this.NameLabel = new CustomDialogs.DarkLabel();
            this.NameTextBox = new CustomDialogs.DarkTextBox();
            this.FolderCancelButton = new CustomDialogs.DarkButton();
            this.SaveButton = new CustomDialogs.DarkButton();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.PasswordLinkEditor = new CloudBackup.Gui.PasswordLinkEditor();
            this.SuspendLayout();
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathLabel.Location = new System.Drawing.Point(9, 13);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(31, 15);
            this.PathLabel.TabIndex = 21;
            this.PathLabel.Text = "Path";
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BrowseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BrowseButton.Image = global::CloudBackup.Gui.Properties.Resources._16pxFolderClosed;
            this.BrowseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BrowseButton.Location = new System.Drawing.Point(12, 32);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 25);
            this.BrowseButton.TabIndex = 20;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathTextBox.Location = new System.Drawing.Point(96, 32);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.PathTextBox.PasswordChar = '\0';
            this.PathTextBox.ReadOnly = false;
            this.PathTextBox.Size = new System.Drawing.Size(496, 25);
            this.PathTextBox.TabIndex = 19;
            this.PathTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathTextBox.XOffset = 0;
            this.PathTextBox.YOffset = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameLabel.Location = new System.Drawing.Point(10, 74);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 18;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.Location = new System.Drawing.Point(13, 93);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ReadOnly = false;
            this.NameTextBox.Size = new System.Drawing.Size(280, 25);
            this.NameTextBox.TabIndex = 17;
            this.NameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.XOffset = 0;
            this.NameTextBox.YOffset = 0;
            // 
            // FolderCancelButton
            // 
            this.FolderCancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.FolderCancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.FolderCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FolderCancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderCancelButton.Location = new System.Drawing.Point(98, 176);
            this.FolderCancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.FolderCancelButton.Name = "FolderCancelButton";
            this.FolderCancelButton.Size = new System.Drawing.Size(75, 25);
            this.FolderCancelButton.TabIndex = 16;
            this.FolderCancelButton.Text = "Cancel";
            this.FolderCancelButton.UseVisualStyleBackColor = false;
            this.FolderCancelButton.Click += new System.EventHandler(this.FolderCancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SaveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Image = global::CloudBackup.Gui.Properties.Resources._16pxSave;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.Location = new System.Drawing.Point(12, 176);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.SaveButton.Size = new System.Drawing.Size(75, 25);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PasswordLinkEditor
            // 
            this.PasswordLinkEditor.AutoSize = true;
            this.PasswordLinkEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PasswordLinkEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PasswordLinkEditor.DisplayName = "PasswordLinkEditor";
            this.PasswordLinkEditor.Link = null;
            this.PasswordLinkEditor.Location = new System.Drawing.Point(303, 90);
            this.PasswordLinkEditor.Name = "PasswordLinkEditor";
            this.PasswordLinkEditor.Password = null;
            this.PasswordLinkEditor.Size = new System.Drawing.Size(257, 28);
            this.PasswordLinkEditor.TabIndex = 24;
            // 
            // FolderEditor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(601, 215);
            this.Controls.Add(this.PasswordLinkEditor);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.FolderCancelButton);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FolderEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Folder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FolderEditor_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FolderEditor_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FolderEditor_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDialogs.DarkLabel PathLabel;
        private CustomDialogs.DarkButton BrowseButton;
        private CustomDialogs.DarkTextBox PathTextBox;
        private CustomDialogs.DarkLabel NameLabel;
        private CustomDialogs.DarkTextBox NameTextBox;
        private CustomDialogs.DarkButton FolderCancelButton;
        private CustomDialogs.DarkButton SaveButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private PasswordLinkEditor PasswordLinkEditor;
    }
}