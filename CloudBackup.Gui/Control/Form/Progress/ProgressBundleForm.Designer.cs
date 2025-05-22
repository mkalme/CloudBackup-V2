
namespace CloudBackup.Gui {
    partial class ProgressBundleForm {
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
            this.ProgressPanel = new CustomDialogs.ProgressPanel();
            this.ProgressSeperator = new System.Windows.Forms.Panel();
            this.ItemProgressPanel = new CustomDialogs.ProgressPanel();
            this.UploadingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ProgressPanel
            // 
            this.ProgressPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ProgressPanel.Location = new System.Drawing.Point(9, 85);
            this.ProgressPanel.Name = "ProgressPanel";
            this.ProgressPanel.OriginalActivityTypeText = "";
            this.ProgressPanel.ProgressColor = System.Drawing.Color.DarkSeaGreen;
            this.ProgressPanel.Size = new System.Drawing.Size(370, 57);
            this.ProgressPanel.TabIndex = 8;
            // 
            // ProgressSeperator
            // 
            this.ProgressSeperator.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ProgressSeperator.Location = new System.Drawing.Point(12, 76);
            this.ProgressSeperator.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressSeperator.Name = "ProgressSeperator";
            this.ProgressSeperator.Size = new System.Drawing.Size(364, 1);
            this.ProgressSeperator.TabIndex = 9;
            // 
            // ItemProgressPanel
            // 
            this.ItemProgressPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ItemProgressPanel.Location = new System.Drawing.Point(9, 10);
            this.ItemProgressPanel.Name = "ItemProgressPanel";
            this.ItemProgressPanel.OriginalActivityTypeText = "";
            this.ItemProgressPanel.ProgressColor = System.Drawing.Color.DarkSeaGreen;
            this.ItemProgressPanel.Size = new System.Drawing.Size(370, 57);
            this.ItemProgressPanel.TabIndex = 10;
            // 
            // UploadingTimer
            // 
            this.UploadingTimer.Tick += new System.EventHandler(this.UploadingTimer_Tick);
            // 
            // ProgressBundleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(388, 154);
            this.Controls.Add(this.ItemProgressPanel);
            this.Controls.Add(this.ProgressSeperator);
            this.Controls.Add(this.ProgressPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProgressBundleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Progress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgressBundleForm_FormClosing);
            this.Load += new System.EventHandler(this.ProgressBundleForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDialogs.ProgressPanel ProgressPanel;
        private System.Windows.Forms.Panel ProgressSeperator;
        private CustomDialogs.ProgressPanel ItemProgressPanel;
        private System.Windows.Forms.Timer UploadingTimer;
    }
}