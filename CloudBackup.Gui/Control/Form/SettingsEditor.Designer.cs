
namespace CloudBackup.Gui {
    partial class SettingsEditor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsEditor));
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.DefaultPasswordLengthTextBox = new CustomDialogs.DarkTextBox();
            this.DefaultPasswordLengthLabel = new CustomDialogs.DarkLabel();
            this.ZipPathTextBox = new CustomDialogs.DarkTextBox();
            this.ZipPathLabel = new CustomDialogs.DarkLabel();
            this.ProgressBarColorLabel = new CustomDialogs.DarkLabel();
            this.FolderNameLabel = new CustomDialogs.DarkLabel();
            this.FolderNameTextBox = new CustomDialogs.DarkTextBox();
            this.ProgressBarColorPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new CustomDialogs.DarkButton();
            this.Cancelbutton = new CustomDialogs.DarkButton();
            this.GlobalContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.GlobalContainer.ColumnCount = 2;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.85654F));
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.14346F));
            this.GlobalContainer.Controls.Add(this.DefaultPasswordLengthTextBox, 1, 0);
            this.GlobalContainer.Controls.Add(this.DefaultPasswordLengthLabel, 0, 0);
            this.GlobalContainer.Controls.Add(this.ZipPathTextBox, 1, 1);
            this.GlobalContainer.Controls.Add(this.ZipPathLabel, 0, 1);
            this.GlobalContainer.Controls.Add(this.ProgressBarColorLabel, 0, 3);
            this.GlobalContainer.Controls.Add(this.FolderNameLabel, 0, 2);
            this.GlobalContainer.Controls.Add(this.FolderNameTextBox, 1, 2);
            this.GlobalContainer.Controls.Add(this.ProgressBarColorPanel, 1, 3);
            this.GlobalContainer.Location = new System.Drawing.Point(12, 12);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 4;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GlobalContainer.Size = new System.Drawing.Size(476, 111);
            this.GlobalContainer.TabIndex = 0;
            // 
            // DefaultPasswordLengthTextBox
            // 
            this.DefaultPasswordLengthTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DefaultPasswordLengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DefaultPasswordLengthTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DefaultPasswordLengthTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DefaultPasswordLengthTextBox.Location = new System.Drawing.Point(152, 1);
            this.DefaultPasswordLengthTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.DefaultPasswordLengthTextBox.Name = "DefaultPasswordLengthTextBox";
            this.DefaultPasswordLengthTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.DefaultPasswordLengthTextBox.PasswordChar = '\0';
            this.DefaultPasswordLengthTextBox.ReadOnly = false;
            this.DefaultPasswordLengthTextBox.Size = new System.Drawing.Size(323, 26);
            this.DefaultPasswordLengthTextBox.TabIndex = 13;
            this.DefaultPasswordLengthTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DefaultPasswordLengthTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.DefaultPasswordLengthTextBox.XOffset = 0;
            this.DefaultPasswordLengthTextBox.YOffset = 1;
            // 
            // DefaultPasswordLengthLabel
            // 
            this.DefaultPasswordLengthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DefaultPasswordLengthLabel.AutoSize = true;
            this.DefaultPasswordLengthLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DefaultPasswordLengthLabel.Location = new System.Drawing.Point(4, 6);
            this.DefaultPasswordLengthLabel.Name = "DefaultPasswordLengthLabel";
            this.DefaultPasswordLengthLabel.Size = new System.Drawing.Size(135, 15);
            this.DefaultPasswordLengthLabel.TabIndex = 12;
            this.DefaultPasswordLengthLabel.Text = "Default password length";
            // 
            // ZipPathTextBox
            // 
            this.ZipPathTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ZipPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ZipPathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZipPathTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ZipPathTextBox.Location = new System.Drawing.Point(152, 28);
            this.ZipPathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ZipPathTextBox.Name = "ZipPathTextBox";
            this.ZipPathTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.ZipPathTextBox.PasswordChar = '\0';
            this.ZipPathTextBox.ReadOnly = false;
            this.ZipPathTextBox.Size = new System.Drawing.Size(323, 26);
            this.ZipPathTextBox.TabIndex = 7;
            this.ZipPathTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ZipPathTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.ZipPathTextBox.XOffset = 0;
            this.ZipPathTextBox.YOffset = 1;
            // 
            // ZipPathLabel
            // 
            this.ZipPathLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ZipPathLabel.AutoSize = true;
            this.ZipPathLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ZipPathLabel.Location = new System.Drawing.Point(4, 33);
            this.ZipPathLabel.Name = "ZipPathLabel";
            this.ZipPathLabel.Size = new System.Drawing.Size(76, 15);
            this.ZipPathLabel.TabIndex = 8;
            this.ZipPathLabel.Text = "7zip exe path";
            // 
            // ProgressBarColorLabel
            // 
            this.ProgressBarColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProgressBarColorLabel.AutoSize = true;
            this.ProgressBarColorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ProgressBarColorLabel.Location = new System.Drawing.Point(4, 88);
            this.ProgressBarColorLabel.Name = "ProgressBarColorLabel";
            this.ProgressBarColorLabel.Size = new System.Drawing.Size(102, 15);
            this.ProgressBarColorLabel.TabIndex = 14;
            this.ProgressBarColorLabel.Text = "Progress bar color";
            // 
            // FolderNameLabel
            // 
            this.FolderNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FolderNameLabel.AutoSize = true;
            this.FolderNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderNameLabel.Location = new System.Drawing.Point(4, 60);
            this.FolderNameLabel.Name = "FolderNameLabel";
            this.FolderNameLabel.Size = new System.Drawing.Size(73, 15);
            this.FolderNameLabel.TabIndex = 15;
            this.FolderNameLabel.Text = "Folder name";
            // 
            // FolderNameTextBox
            // 
            this.FolderNameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FolderNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.FolderNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolderNameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderNameTextBox.Location = new System.Drawing.Point(152, 55);
            this.FolderNameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.FolderNameTextBox.Name = "FolderNameTextBox";
            this.FolderNameTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.FolderNameTextBox.PasswordChar = '\0';
            this.FolderNameTextBox.ReadOnly = true;
            this.FolderNameTextBox.Size = new System.Drawing.Size(323, 26);
            this.FolderNameTextBox.TabIndex = 16;
            this.FolderNameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FolderNameTextBox.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.FolderNameTextBox.XOffset = 0;
            this.FolderNameTextBox.YOffset = 1;
            // 
            // ProgressBarColorPanel
            // 
            this.ProgressBarColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProgressBarColorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProgressBarColorPanel.Location = new System.Drawing.Point(154, 84);
            this.ProgressBarColorPanel.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.ProgressBarColorPanel.Name = "ProgressBarColorPanel";
            this.ProgressBarColorPanel.Size = new System.Drawing.Size(24, 24);
            this.ProgressBarColorPanel.TabIndex = 7;
            this.ProgressBarColorPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarColorPanel_MouseDown);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SaveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Image = global::CloudBackup.Gui.Properties.Resources._16pxSave;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.Location = new System.Drawing.Point(12, 175);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.SaveButton.Size = new System.Drawing.Size(75, 25);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Cancelbutton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.Cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelbutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Cancelbutton.Location = new System.Drawing.Point(98, 175);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(0);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 25);
            this.Cancelbutton.TabIndex = 6;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // SettingsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(499, 214);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GlobalContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private CustomDialogs.DarkButton SaveButton;
        private CustomDialogs.DarkButton Cancelbutton;
        private CustomDialogs.DarkTextBox ZipPathTextBox;
        private CustomDialogs.DarkLabel ZipPathLabel;
        private CustomDialogs.DarkLabel DefaultPasswordLengthLabel;
        private CustomDialogs.DarkTextBox DefaultPasswordLengthTextBox;
        private CustomDialogs.DarkLabel ProgressBarColorLabel;
        private CustomDialogs.DarkLabel FolderNameLabel;
        private CustomDialogs.DarkTextBox FolderNameTextBox;
        private System.Windows.Forms.Panel ProgressBarColorPanel;
    }
}