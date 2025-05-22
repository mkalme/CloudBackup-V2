using System;
using CustomDialogs;

namespace CloudBackup.Gui {
    public class ProgressReportAdapter : IProgressReport {
        public string ActivityType { get; set; }
        public string Message { get; set; }
        public float Percentage { get; set; }

        public ProgressReportAdapter(ProgressReport progressReport) {
            ActivityType = progressReport.Title;
            Message = progressReport.Message;
            Percentage = progressReport.Percentage;
        }
    }
}
