using System;
namespace gtask_tracker.console.models
{
    public class TaskLogRecordDTO
    {
        private int Id {get; set;}
        public string? CommitMessage { get; set; }
        public string? DevelopmentDetails { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
