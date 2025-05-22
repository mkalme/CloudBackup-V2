namespace CloudBackup.Gui {
    partial class PasswordLinkEditor {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ChangeLinkButton = new CustomDialogs.DarkButton();
            this.ChangePasswordButton = new CustomDialogs.DarkButton();
            this.SuspendLayout();
            // 
            // ChangeLinkButton
            // 
            this.ChangeLinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ChangeLinkButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ChangeLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeLinkButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangeLinkButton.Image = global::CloudBackup.Gui.Properties.Resources._16pxLink;
            this.ChangeLinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeLinkButton.Location = new System.Drawing.Point(153, 3);
            this.ChangeLinkButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChangeLinkButton.Name = "ChangeLinkButton";
            this.ChangeLinkButton.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ChangeLinkButton.Size = new System.Drawing.Size(104, 25);
            this.ChangeLinkButton.TabIndex = 25;
            this.ChangeLinkButton.Text = "Change link";
            this.ChangeLinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeLinkButton.UseVisualStyleBackColor = false;
            this.ChangeLinkButton.Click += new System.EventHandler(this.ChangeLinkButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ChangePasswordButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePasswordButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangePasswordButton.Image = global::CloudBackup.Gui.Properties.Resources._16pxKey;
            this.ChangePasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangePasswordButton.Location = new System.Drawing.Point(3, 3);
            this.ChangePasswordButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ChangePasswordButton.Size = new System.Drawing.Size(140, 25);
            this.ChangePasswordButton.TabIndex = 24;
            this.ChangePasswordButton.Text = "Change password";
            this.ChangePasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangePasswordButton.UseVisualStyleBackColor = false;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // PasswordLinkEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.ChangeLinkButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.DisplayName = "PasswordLinkEditor";
            this.Size = new System.Drawing.Size(262, 33);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDialogs.DarkButton ChangeLinkButton;
        private CustomDialogs.DarkButton ChangePasswordButton;
    }
}
