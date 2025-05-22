using System;
using System.Windows.Forms;
using System.Drawing;

namespace CloudBackup.Gui {
    public partial class ProgressForm : Form {
        private Progress<ProgressReport> _progress;
        private bool _canClose = false;

        public ProgressForm(Progress<ProgressReport> progress, Color progressColor) {
            InitializeComponent();

            ProgressPanel.ProgressColor = progressColor;

            _progress = progress;
            _progress.ProgressChanged += UpdateProgress;

            UploadingTitleTimer.Interval = 400;
            UploadingTitleTimer.Start();
        }

        public void SetText(string text) {
            if (_title.StartsWith(text)) return;

            Text = text;
            _title = text;

            ProgressPanel.SetText(Text);
        }

        private void UpdateProgress(object sender, ProgressReport progress) {
            SetText(progress.Title);

            ProgressPanel.Update(new ProgressReportAdapter(progress));

            if (progress.State == State.Finished || progress.State == State.ExceptionThrown) {
                _canClose = true;
                Close(); 
            }
        }

        private void ProgressForm_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = !_canClose;
        }

        private string _title = "";
        private void UploadingTitleTimer_Tick(object sender, EventArgs e) {
            if (Text.Length - _title.Length < 3) {
                Text += ".";
            } else {
                Text = _title;
            }

            ProgressPanel.SetText(Text);
        }
    }
}
