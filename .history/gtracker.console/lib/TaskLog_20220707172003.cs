using System;

namespace gtask_tracker.console.models
{
    public enum TaskStatus
    {
        Stopped,
        InProgress,
        Finished,
        Started
    }
    public class TaskLog
    {
        public string Name { get; set; }    = "<unknow";
        public string Description { get; set; } = "<set one description to this task>";
        public DateTime startTime { get; set; }
        public TaskStatus Status { get; set; }

    }
}