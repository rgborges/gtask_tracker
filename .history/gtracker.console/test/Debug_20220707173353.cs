using System;
using System.Collections.Generic;
using gtask_tracker.console.lib;
using gtask_tracker.console.models;

namespace gtask_tracker.console.app.debug
{
    public class Debug
    {
        private DateTime startTime;
        public ReportDTO GetSampleData()
        {
            var records = new List<TaskLogRecordDTO>();
            records.Add(new TaskLogRecordDTO {
                CommitMessage = "Start to reading and trying to discover the issue"
            });
        }
    }
}