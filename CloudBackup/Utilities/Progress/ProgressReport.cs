using System;

namespace CloudBackup {
    public class ProgressReport {
        public string Title { get; set; }
        public string Message { get; set; }
        
        public State State { get; set; }
        public float Percentage { get; set; }

        public ProgressReport(string title, string message, float percentage) { 
            Title = title;
            Message = message;

            State = State.NotStarted;
            Percentage = percentage;
        }
    }
}
