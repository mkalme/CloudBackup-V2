using System;

namespace CloudBackup {
    public class ZipProgressAdapter : IProgress<float> {
        public IProgress<ProgressReport> Progress { get; set; }

        public string Title { get; set; }
        public string Message { get; set; }

        public ZipProgressAdapter(IProgress<ProgressReport> progress) {
            Progress = progress;
        }

        public void Report(float value) {
            ProgressReport report = new ProgressReport(Title, Message, value) {
                State = value >= 1 ? State.Finished : State.Unfinished
            };

            Progress.Report(report);
        }
    }
}
