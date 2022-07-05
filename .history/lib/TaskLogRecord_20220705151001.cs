public class TaskLogRecord 
{
    private string? _commitMessage;
    private string? _developmentMessage;
    private DateTime _timestamp;
    public string? CommitMessage { get => _commitMessage; }
    public string? DevelopmentDetails { get => _developmentMessage; }
    public DateTime Timestamp { get; set; }
    public string Author { get; set;}

}