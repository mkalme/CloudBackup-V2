namespace CloudBackup.Gui {
    partial class FilteredFolderEditor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilteredFolderEditor));
            this.CaseSensitiveCheckBox = new CustomDialogs.DarkCheckBox();
            this.ExcludeCheckBox = new CustomDialogs.DarkCheckBox();
            this.ExampleLabel = new CustomDialogs.DarkLabel();
            this.FilterLabel = new CustomDialogs.DarkLabel();
            this.FilterTextBox = new CustomDialogs.DarkTextBox();
            this.PathLabel = new CustomDialogs.DarkLabel();
            this.BrowseButton = new CustomDialogs.DarkButton();
            this.PathTextBox = new CustomDialogs.DarkTextBox();
            this.NameLabel = new CustomDialogs.DarkLabel();
            this.NameTextBox = new CustomDialogs.DarkTextBox();
            this.CancelButton = new CustomDialogs.DarkButton();
            this.SaveButton = new CustomDialogs.DarkButton();
            this.PasswordLinkEditor = new CloudBackup.Gui.PasswordLinkEditor();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // CaseSensitiveCheckBox
            // 
            this.CaseSensitiveCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.CaseSensitiveCheckBox.BoxBackColor = System.Drawing.Color.Transparent;
            this.CaseSensitiveCheckBox.BoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.CaseSensitiveCheckBox.BoxHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CaseSensitiveCheckBox.BoxMouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CaseSensitiveCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CaseSensitiveCheckBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CaseSensitiveCheckBox.Location = new System.Drawing.Point(169, 62);
            this.CaseSensitiveCheckBox.Name = "CaseSensitiveCheckBox";
            this.CaseSensitiveCheckBox.Size = new System.Drawing.Size(98, 19);
            this.CaseSensitiveCheckBox.TabIndex = 55;
            this.CaseSensitiveCheckBox.Text = "Case sensitive";
            this.CaseSensitiveCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CaseSensitiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExcludeCheckBox
            // 
            this.ExcludeCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ExcludeCheckBox.BoxBackColor = System.Drawing.Color.Transparent;
            this.ExcludeCheckBox.BoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ExcludeCheckBox.BoxHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ExcludeCheckBox.BoxMouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ExcludeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcludeCheckBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExcludeCheckBox.Location = new System.Drawing.Point(95, 62);
            this.ExcludeCheckBox.Name = "ExcludeCheckBox";
            this.ExcludeCheckBox.Size = new System.Drawing.Size(65, 19);
            this.ExcludeCheckBox.TabIndex = 54;
            this.ExcludeCheckBox.Text = "Exclude";
            this.ExcludeCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExcludeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.AutoSize = true;
            this.ExampleLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExampleLabel.Location = new System.Drawing.Point(303, 97);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(95, 15);
            this.ExampleLabel.TabIndex = 53;
            this.ExampleLabel.Text = "Example: bin|obj";
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FilterLabel.Location = new System.Drawing.Point(10, 74);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(33, 15);
            this.FilterLabel.TabIndex = 52;
            this.FilterLabel.Text = "Filter";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FilterTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.FilterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FilterTextBox.Location = new System.Drawing.Point(13, 93);
            this.FilterTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.FilterTextBox.PasswordChar = '\0';
            this.FilterTextBox.ReadOnly = false;
            this.FilterTextBox.Size = new System.Drawing.Size(280, 25);
            this.FilterTextBox.TabIndex = 51;
            this.FilterTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.FilterTextBox.XOffset = 0;
            this.FilterTextBox.YOffset = 0;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathLabel.Location = new System.Drawing.Point(9, 13);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(31, 15);
            this.PathLabel.TabIndex = 50;
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
            this.BrowseButton.TabIndex = 49;
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
            this.PathTextBox.TabIndex = 48;
            this.PathTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathTextBox.XOffset = 0;
            this.PathTextBox.YOffset = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameLabel.Location = new System.Drawing.Point(10, 124);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 47;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.Location = new System.Drawing.Point(13, 143);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ReadOnly = false;
            this.NameTextBox.Size = new System.Drawing.Size(280, 25);
            this.NameTextBox.TabIndex = 46;
            this.NameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.XOffset = 0;
            this.NameTextBox.YOffset = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton.Location = new System.Drawing.Point(98, 212);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 25);
            this.CancelButton.TabIndex = 45;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SaveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Image = global::CloudBackup.Gui.Properties.Resources._16pxSave;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.Location = new System.Drawing.Point(12, 212);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.SaveButton.Size = new System.Drawing.Size(75, 25);
            this.SaveButton.TabIndex = 44;
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
            this.PasswordLinkEditor.Location = new System.Drawing.Point(303, 140);
            this.PasswordLinkEditor.Name = "PasswordLinkEditor";
            this.PasswordLinkEditor.Password = null;
            this.PasswordLinkEditor.Size = new System.Drawing.Size(257, 28);
            this.PasswordLinkEditor.TabIndex = 56;
            // 
            // FilteredFolderEditor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(601, 251);
            this.Controls.Add(this.PasswordLinkEditor);
            this.Controls.Add(this.CaseSensitiveCheckBox);
            this.Controls.Add(this.ExcludeCheckBox);
            this.Controls.Add(this.ExampleLabel);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FilteredFolderEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filtered folder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilteredFolderEditor_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FilteredFolderEditor_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FilteredFolderEditor_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDialogs.DarkCheckBox CaseSensitiveCheckBox;
        private CustomDialogs.DarkCheckBox ExcludeCheckBox;
        private CustomDialogs.DarkLabel ExampleLabel;
        private CustomDialogs.DarkLabel FilterLabel;
        private CustomDialogs.DarkTextBox FilterTextBox;
        private CustomDialogs.DarkLabel PathLabel;
        private CustomDialogs.DarkButton BrowseButton;
        private CustomDialogs.DarkTextBox PathTextBox;
        private CustomDialogs.DarkLabel NameLabel;
        private CustomDialogs.DarkTextBox NameTextBox;
        private CustomDialogs.DarkButton CancelButton;
        private CustomDialogs.DarkButton SaveButton;
        private PasswordLinkEditor PasswordLinkEditor;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
    }
}