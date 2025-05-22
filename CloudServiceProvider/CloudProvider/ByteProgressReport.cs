using System;

namespace CloudServiceProvider {
    public class ByteProgressReport : CloudProgressReport {
        public long BytesSeen { get; set; }

        public ByteProgressReport(RequestStatus status, long bytesSeen) : base(status) {
            BytesSeen = bytesSeen;
        }
    }
}
