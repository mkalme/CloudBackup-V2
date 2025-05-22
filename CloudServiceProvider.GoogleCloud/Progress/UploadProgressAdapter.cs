using System;
using Google.Apis.Upload;

namespace CloudServiceProvider.GoogleCloud {
    public class UploadProgressAdapter : IProgress<IUploadProgress> {
        public IProgress<ByteProgressReport> Progress { get; set; }
        public long Length { get; set; }

        public UploadProgressAdapter(IProgress<ByteProgressReport> progress, long length) { 
            Progress = progress;
            Length = length;
        }

        public void Report(IUploadProgress value) {
            RequestStatus status = RequestStatus.InProgress;

            switch (value.Status) {
                case UploadStatus.Completed:
                    status = RequestStatus.Successfull;
                    break;
                case UploadStatus.Failed:
                    status = RequestStatus.OtherError;
                    break;
            }

            Progress.Report(new ByteProgressReport(status, value.BytesSent));
        }
    }
}
