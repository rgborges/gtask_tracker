using System;
using System.Collections.Generic;
using System.Text;

namespace gtask_tracker.console.lib
{
    public class TaskBook 
    {
        private string _author;
        private StringBuilder _builder;
        private List<TaskLogRecord> _records;
        private string _title;
        public string Title
        {
            get => _title; set
            {
                _title = value;
            }
        }
        public TaskBook(string author)
        {
            _author = author;
            _records = new List<TaskLogRecord>();
            _builder = new StringBuilder();
            _title = $"{DateTime.Now.ToString()} by auhtor {}";
        }
        public void Add(TaskLogRecord log)
        {
            _records.Add(log);
        }

    }
}
