namespace gtask_tracker.console.models
{
    public enum TaskStatus
    {
        Stopped,
        InProgress,
        Fini
    }
    public class TaskLog
    {
        public string Name { get; set; }    
        public string Description { get; set; }
        public DateTime startTime { get; set; }
        public TaskStatus Status { get; set; }

    }
}