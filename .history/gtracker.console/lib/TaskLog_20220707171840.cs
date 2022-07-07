namespace gtask_tracker.console.models
{
    public class TaskLog
    {
        public string Name { get; set; }    
        public string Description { get; set; }
        public DateTime startTime { get; set; }
        public TaskStatus MyProperty { get; set; }

    }
}