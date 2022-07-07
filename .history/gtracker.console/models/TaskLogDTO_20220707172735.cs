using System;

namespace gtask_tracker.console.models
{
    public class TaskLogDTO 
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public TaskStatus Status { get; set; }
        public List<TaskLogRecordDTO> Records {get; set;}
    }
}