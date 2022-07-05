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

}