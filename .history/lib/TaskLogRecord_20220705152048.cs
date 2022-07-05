public class TaskLogRecord
{
    private string? _commitMessage;
    private string? _developmentMessage;
    private DateTime _timestamp;
    private string? _author;
    public string? CommitMessage { get => _commitMessage; }
    public string? DevelopmentDetails { get => _developmentMessage; }
    public DateTime Timestamp { get => _timestamp; }
    public string Author { get => _author; }

    public TaskLogRecord(string commit, string develeopment, string author)
    {
        CheckStringPolicy.CheckStringArray(new string[] {commit, develeopment, author});
    } 
    public TaskLogRecord(string commit, string deve) 
}