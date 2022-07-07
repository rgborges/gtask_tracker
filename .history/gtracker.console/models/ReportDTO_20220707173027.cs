using System;
using System.Collections.Generic;

namespace gtask_tracker.console.models
{
    public class ReportDTO
    {
        public int MyProperty { get; set; }
        public List<TaskLogDTO> Tasks { get; set;}
    }
}