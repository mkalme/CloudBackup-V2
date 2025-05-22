using System;
using CloudServiceProvider;
using CustomDialogs;

namespace CloudBackup {
    public class ByteProgressAdapter : IProgress<ByteProgressReport> {
        public IProgress<ProgressReport> Progress { get; set; }
        public long TotalBytes { get; set; }
        public string Title { get; set; }
        public bool FinishOnEnd { get; set; } = true;

        public ByteProgressAdapter(IProgress<ProgressReport> progress, long totalBytes) {
            Progress = progress;
            TotalBytes = totalBytes;
        }

        public void Report(ByteProgressReport value) {
            State state = State.Unfinished;

            switch (value.Status) {
                case RequestStatus.Successfull:
                    state = FinishOnEnd ? State.Finished : state;
                    break;
                case RequestStatus.FileNotFound:
                case RequestStatus.NoInternetConnection:
                case RequestStatus.OtherError:
                case RequestStatus.Canceled:
                    state = State.ExceptionThrown;
                    break;
            }

            string message = $"{value.BytesSeen.ConvertToStorage(true)} sent out of {TotalBytes.ConvertToStorage(true)}";

            ProgressReport report = new ProgressReport(Title, message, (float)value.BytesSeen / TotalBytes) {
                State = state
            };

            Progress.Report(report);
        }
    }
}
