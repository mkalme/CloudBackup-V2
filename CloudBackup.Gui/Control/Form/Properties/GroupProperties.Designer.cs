
namespace CloudBackup.Gui {
    partial class GroupProperties {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupProperties));
            this.GlobalContainer = new System.Windows.Forms.Panel();
            this.InformationContainer = new System.Windows.Forms.TableLayoutPanel();
            this.CreationDateSeperator = new System.Windows.Forms.Panel();
            this.PathContainer = new System.Windows.Forms.TableLayoutPanel();
            this.CreationDateLabel = new CustomDialogs.DarkLabel();
            this.CreationDateTextBox = new System.Windows.Forms.TextBox();
            this.ModifiedTextBox = new System.Windows.Forms.TextBox();
            this.darkLabel1 = new CustomDialogs.DarkLabel();
            this.TypeSeperator = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.NameTextBox = new CustomDialogs.DarkTextBox();
            this.HeaderSeperator = new System.Windows.Forms.Panel();
            this.TypeContainer = new System.Windows.Forms.TableLayoutPanel();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new CustomDialogs.DarkLabel();
            this.LocationLabel = new CustomDialogs.DarkLabel();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.SizeLabel = new CustomDialogs.DarkLabel();
            this.ContainsLabel = new CustomDialogs.DarkLabel();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.ContainsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CloseButton = new CustomDialogs.DarkButton();
            this.GlobalContainer.SuspendLayout();
            this.InformationContainer.SuspendLayout();
            this.PathContainer.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.TypeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GlobalContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GlobalContainer.Controls.Add(this.InformationContainer);
            this.GlobalContainer.Location = new System.Drawing.Point(8, 8);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.Size = new System.Drawing.Size(334, 320);
            this.GlobalContainer.TabIndex = 0;
            // 
            // InformationContainer
            // 
            this.InformationContainer.AutoSize = true;
            this.InformationContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InformationContainer.ColumnCount = 1;
            this.InformationContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InformationContainer.Controls.Add(this.CreationDateSeperator, 0, 5);
            this.InformationContainer.Controls.Add(this.PathContainer, 0, 4);
            this.InformationContainer.Controls.Add(this.TypeSeperator, 0, 3);
            this.InformationContainer.Controls.Add(this.HeaderPanel, 0, 0);
            this.InformationContainer.Controls.Add(this.HeaderSeperator, 0, 1);
            this.InformationContainer.Controls.Add(this.TypeContainer, 0, 2);
            this.InformationContainer.Location = new System.Drawing.Point(13, 12);
            this.InformationContainer.Name = "InformationContainer";
            this.InformationContainer.RowCount = 6;
            this.InformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InformationContainer.Size = new System.Drawing.Size(312, 280);
            this.InformationContainer.TabIndex = 0;
            // 
            // CreationDateSeperator
            // 
            this.CreationDateSeperator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CreationDateSeperator.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CreationDateSeperator.Location = new System.Drawing.Point(2, 273);
            this.CreationDateSeperator.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.CreationDateSeperator.Name = "CreationDateSeperator";
            this.CreationDateSeperator.Size = new System.Drawing.Size(308, 1);
            this.CreationDateSeperator.TabIndex = 6;
            // 
            // PathContainer
            // 
            this.PathContainer.AutoSize = true;
            this.PathContainer.ColumnCount = 2;
            this.PathContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.PathContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PathContainer.Controls.Add(this.CreationDateLabel, 0, 0);
            this.PathContainer.Controls.Add(this.CreationDateTextBox, 1, 0);
            this.PathContainer.Controls.Add(this.ModifiedTextBox, 1, 1);
            this.PathContainer.Controls.Add(this.darkLabel1, 0, 1);
            this.PathContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.PathContainer.Location = new System.Drawing.Point(0, 213);
            this.PathContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PathContainer.Name = "PathContainer";
            this.PathContainer.RowCount = 2;
            this.PathContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PathContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PathContainer.Size = new System.Drawing.Size(312, 54);
            this.PathContainer.TabIndex = 5;
            // 
            // CreationDateLabel
            // 
            this.CreationDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CreationDateLabel.AutoSize = true;
            this.CreationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreationDateLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CreationDateLabel.Location = new System.Drawing.Point(0, 7);
            this.CreationDateLabel.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.CreationDateLabel.Name = "CreationDateLabel";
            this.CreationDateLabel.Size = new System.Drawing.Size(47, 13);
            this.CreationDateLabel.TabIndex = 0;
            this.CreationDateLabel.Text = "Created:";
            // 
            // CreationDateTextBox
            // 
            this.CreationDateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CreationDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreationDateTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreationDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreationDateTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CreationDateTextBox.Location = new System.Drawing.Point(86, 7);
            this.CreationDateTextBox.Margin = new System.Windows.Forms.Padding(2, 7, 3, 0);
            this.CreationDateTextBox.Name = "CreationDateTextBox";
            this.CreationDateTextBox.ReadOnly = true;
            this.CreationDateTextBox.Size = new System.Drawing.Size(223, 13);
            this.CreationDateTextBox.TabIndex = 3;
            // 
            // ModifiedTextBox
            // 
            this.ModifiedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ModifiedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModifiedTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ModifiedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModifiedTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ModifiedTextBox.Location = new System.Drawing.Point(86, 34);
            this.ModifiedTextBox.Margin = new System.Windows.Forms.Padding(2, 7, 3, 0);
            this.ModifiedTextBox.Name = "ModifiedTextBox";
            this.ModifiedTextBox.ReadOnly = true;
            this.ModifiedTextBox.Size = new System.Drawing.Size(223, 13);
            this.ModifiedTextBox.TabIndex = 5;
            // 
            // darkLabel1
            // 
            this.darkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.darkLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.darkLabel1.Location = new System.Drawing.Point(0, 34);
            this.darkLabel1.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(50, 13);
            this.darkLabel1.TabIndex = 4;
            this.darkLabel1.Text = "Modified:";
            // 
            // TypeSeperator
            // 
            this.TypeSeperator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TypeSeperator.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TypeSeperator.Location = new System.Drawing.Point(2, 206);
            this.TypeSeperator.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.TypeSeperator.Name = "TypeSeperator";
            this.TypeSeperator.Size = new System.Drawing.Size(308, 1);
            this.TypeSeperator.TabIndex = 4;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.AutoSize = true;
            this.HeaderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HeaderPanel.ColumnCount = 2;
            this.HeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.HeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderPanel.Controls.Add(this.PictureBox, 0, 0);
            this.HeaderPanel.Controls.Add(this.NameTextBox, 1, 0);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.RowCount = 1;
            this.HeaderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderPanel.Size = new System.Drawing.Size(312, 35);
            this.HeaderPanel.TabIndex = 1;
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::CloudBackup.Gui.Properties.Resources._64pxGroup;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(35, 35);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.Location = new System.Drawing.Point(84, 7);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(224, 22);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.XOffset = 0;
            this.NameTextBox.YOffset = 0;
            // 
            // HeaderSeperator
            // 
            this.HeaderSeperator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeaderSeperator.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.HeaderSeperator.Location = new System.Drawing.Point(2, 41);
            this.HeaderSeperator.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.HeaderSeperator.Name = "HeaderSeperator";
            this.HeaderSeperator.Size = new System.Drawing.Size(308, 1);
            this.HeaderSeperator.TabIndex = 2;
            // 
            // TypeContainer
            // 
            this.TypeContainer.AutoSize = true;
            this.TypeContainer.ColumnCount = 2;
            this.TypeContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.TypeContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TypeContainer.Controls.Add(this.LocationTextBox, 1, 1);
            this.TypeContainer.Controls.Add(this.TypeLabel, 0, 0);
            this.TypeContainer.Controls.Add(this.LocationLabel, 0, 1);
            this.TypeContainer.Controls.Add(this.TypeTextBox, 1, 0);
            this.TypeContainer.Controls.Add(this.SizeLabel, 0, 2);
            this.TypeContainer.Controls.Add(this.ContainsLabel, 0, 3);
            this.TypeContainer.Controls.Add(this.SizeTextBox, 1, 2);
            this.TypeContainer.Controls.Add(this.ContainsRichTextBox, 1, 3);
            this.TypeContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TypeContainer.Location = new System.Drawing.Point(0, 48);
            this.TypeContainer.Margin = new System.Windows.Forms.Padding(0);
            this.TypeContainer.Name = "TypeContainer";
            this.TypeContainer.RowCount = 4;
            this.TypeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TypeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TypeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TypeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TypeContainer.Size = new System.Drawing.Size(312, 152);
            this.TypeContainer.TabIndex = 3;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.LocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocationTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LocationTextBox.Location = new System.Drawing.Point(86, 34);
            this.LocationTextBox.Margin = new System.Windows.Forms.Padding(2, 7, 3, 0);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.ReadOnly = true;
            this.LocationTextBox.Size = new System.Drawing.Size(223, 13);
            this.LocationTextBox.TabIndex = 4;
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TypeLabel.Location = new System.Drawing.Point(0, 7);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(34, 13);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Type:";
            // 
            // LocationLabel
            // 
            this.LocationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocationLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LocationLabel.Location = new System.Drawing.Point(0, 34);
            this.LocationLabel.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(51, 13);
            this.LocationLabel.TabIndex = 1;
            this.LocationLabel.Text = "Location:";
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TypeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TypeTextBox.Location = new System.Drawing.Point(86, 7);
            this.TypeTextBox.Margin = new System.Windows.Forms.Padding(2, 7, 3, 0);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.ReadOnly = true;
            this.TypeTextBox.Size = new System.Drawing.Size(223, 13);
            this.TypeTextBox.TabIndex = 3;
            this.TypeTextBox.Text = "Group";
            // 
            // SizeLabel
            // 
            this.SizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SizeLabel.Location = new System.Drawing.Point(0, 61);
            this.SizeLabel.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(30, 13);
            this.SizeLabel.TabIndex = 8;
            this.SizeLabel.Text = "Size:";
            // 
            // ContainsLabel
            // 
            this.ContainsLabel.AutoSize = true;
            this.ContainsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContainsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ContainsLabel.Location = new System.Drawing.Point(0, 88);
            this.ContainsLabel.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.ContainsLabel.Name = "ContainsLabel";
            this.ContainsLabel.Size = new System.Drawing.Size(51, 13);
            this.ContainsLabel.TabIndex = 6;
            this.ContainsLabel.Text = "Contains:";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SizeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SizeTextBox.Location = new System.Drawing.Point(86, 61);
            this.SizeTextBox.Margin = new System.Windows.Forms.Padding(2, 7, 3, 0);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.ReadOnly = true;
            this.SizeTextBox.Size = new System.Drawing.Size(223, 13);
            this.SizeTextBox.TabIndex = 7;
            // 
            // ContainsRichTextBox
            // 
            this.ContainsRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ContainsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContainsRichTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContainsRichTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ContainsRichTextBox.Location = new System.Drawing.Point(85, 87);
            this.ContainsRichTextBox.Margin = new System.Windows.Forms.Padding(1, 6, 3, 0);
            this.ContainsRichTextBox.Name = "ContainsRichTextBox";
            this.ContainsRichTextBox.ReadOnly = true;
            this.ContainsRichTextBox.Size = new System.Drawing.Size(224, 65);
            this.ContainsRichTextBox.TabIndex = 2;
            this.ContainsRichTextBox.Text = "";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(267, 336);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 24);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // GroupProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(350, 369);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.GlobalContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GroupProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "1";
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.InformationContainer.ResumeLayout(false);
            this.InformationContainer.PerformLayout();
            this.PathContainer.ResumeLayout(false);
            this.PathContainer.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.TypeContainer.ResumeLayout(false);
            this.TypeContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GlobalContainer;
        private CustomDialogs.DarkButton CloseButton;
        private System.Windows.Forms.TableLayoutPanel InformationContainer;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TableLayoutPanel HeaderPanel;
        private CustomDialogs.DarkTextBox NameTextBox;
        private System.Windows.Forms.Panel HeaderSeperator;
        private System.Windows.Forms.TableLayoutPanel TypeContainer;
        private CustomDialogs.DarkLabel TypeLabel;
        private CustomDialogs.DarkLabel LocationLabel;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private CustomDialogs.DarkLabel ContainsLabel;
        private System.Windows.Forms.Panel TypeSeperator;
        private System.Windows.Forms.TableLayoutPanel PathContainer;
        private CustomDialogs.DarkLabel CreationDateLabel;
        private System.Windows.Forms.TextBox CreationDateTextBox;
        private System.Windows.Forms.Panel CreationDateSeperator;
        private System.Windows.Forms.TextBox ModifiedTextBox;
        private CustomDialogs.DarkLabel darkLabel1;
        private CustomDialogs.DarkLabel SizeLabel;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.RichTextBox ContainsRichTextBox;
    }
}