using System;
using Google.Apis.Download;

namespace CloudServiceProvider.GoogleCloud {
    public class DownloadProgressAdapter : IProgress<IDownloadProgress> {
        public IProgress<ByteProgressReport> Progress { get; set; }
        public long Length { get; set; }

        public DownloadProgressAdapter(IProgress<ByteProgressReport> progress, long length) {
            Progress = progress;
            Length = length;
        }

        public void Report(IDownloadProgress value) {
            RequestStatus status = RequestStatus.InProgress;

            switch (value.Status) {
                case DownloadStatus.Completed:
                    status = RequestStatus.Successfull;
                    break;
                case DownloadStatus.Failed:
                    status = RequestStatus.OtherError;
                    break;
            }

            Progress.Report(new ByteProgressReport(status, value.BytesDownloaded));
        }
    }
}
