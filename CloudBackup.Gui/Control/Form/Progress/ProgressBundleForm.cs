using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class ProgressBundleForm : Form {
        public IList<UpdateableItem> UpdateableItems { get; set; }
        
        private bool _canClose = false;

        public bool UpdateSuccessfull { get; private set; } = false;

        public ProgressBundleForm(IList<UpdateableItem> updateableItems, Color progressColor) {
            InitializeComponent();

            ProgressPanel.ProgressColor = progressColor;

            UpdateableItems = updateableItems;

            UploadingTimer.Interval = 400;
            UploadingTimer.Start();
        }

        private void ProgressBundleForm_Load(object sender, EventArgs e) {
            BeginUpdate();
        }

        private void BeginUpdate() {
            IProgress<ProgressReport> itemProgress = new Progress<ProgressReport>();
            ((Progress<ProgressReport>)itemProgress).ProgressChanged += ItemUpdateProgress;

            Thread thread = new Thread(() => {
                for (int i = 0; i < UpdateableItems.Count; i++) {
                    UpdateableItem item = UpdateableItems[i];

                    itemProgress.Report(new ProgressReport($"Updating {item.Name}", $"{i} / {UpdateableItems.Count}", i / (float)UpdateableItems.Count));

                    UpdateItem(item);
                }

                itemProgress.Report(new ProgressReport("Updating finished", "", 1) {
                    State = State.Finished
                });
            });

            thread.Start();
        }
        private void UpdateItem(UpdateableItem item) {
            Invoke(new Action(() => {
                Icon = ImageToIconConverter.Convert(item.GetIcon(), 16, 16);
            }));

            Progress<ProgressReport> progress = new Progress<ProgressReport>();
            progress.ProgressChanged += UpdateProgress;

            if (item.Update(progress)) {
                UpdateSuccessfull = true;
            }
        }

        private void ItemUpdateProgress(object sender, ProgressReport progress) {
            Invoke(new Action(() => {
                if (progress.Title != ItemProgressPanel.OriginalActivityTypeText) {
                    ItemProgressPanel.SetText(progress.Title);
                }

                ItemProgressPanel.Update(new ProgressReportAdapter(progress));

                if (progress.State == State.Finished || progress.State == State.ExceptionThrown) {
                    _canClose = true;
                    Close();
                }
            }));
        }
        private void UpdateProgress(object sender, ProgressReport progress) {
            Invoke(new Action(() => {
                if (progress.Title != ProgressPanel.OriginalActivityTypeText) {
                    ProgressPanel.SetText(progress.Title);
                }

                ProgressPanel.Update(new ProgressReportAdapter(progress));
            }));
        }

        private void UploadingTimer_Tick(object sender, EventArgs e) {
            UpdateText(ItemProgressPanel);
            UpdateText(ProgressPanel);

            Text = ItemProgressPanel.ActivityTypeText;
        }
        private void UpdateText(ProgressPanel panel) {
            if (panel.ActivityTypeText.Length - panel.OriginalActivityTypeText.Length < 3) {
                panel.SetText(panel.ActivityTypeText + ".");
            } else {
                panel.SetText(panel.OriginalActivityTypeText);
            }
        }

        private void ProgressBundleForm_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = !_canClose;
        }
    }
}
