using System;

namespace CloudServiceProvider {
    public class CloudProgressReport {
        public RequestStatus Status { get; set; }

        public CloudProgressReport(RequestStatus status) { 
            Status = status;
        }
    }
}
