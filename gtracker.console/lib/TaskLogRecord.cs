using System;

namespace gtask_tracker.console.lib
{
    public class TaskLogRecord : Entity
    {
        private string? _commitMessage;
        private string? _developmentMessage;
        private DateTime _timestamp;
        private string? _author;
        public string? CommitMessage { get => _commitMessage; }
        public string? DevelopmentDetails { get => _developmentMessage; }
        public DateTime Timestamp { get => _timestamp; }
        public string? Author { get => _author; }

        public TaskLogRecord(string commit, string development, string author)
        {
            CheckStringPolicy.CheckStringArray(new string[] {commit, development, author});
            this._commitMessage = commit;
            this._developmentMessage = development;
            this._author = author;
            this._timestamp = DateTime.UtcNow;
        } 
        public TaskLogRecord(string commit, string development, string author, DateTime timestamp)
        {
            CheckStringPolicy.CheckStringArray(new string[] {commit, development, author});
            this._commitMessage = commit;
            this._developmentMessage = development;
            this._author = author;
            this._timestamp = timestamp;
        } 
    }
}
