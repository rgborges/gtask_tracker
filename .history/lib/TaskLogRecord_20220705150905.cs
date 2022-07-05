public class TaskLogRecord 
{
    private string? _commitMessage;
    private string? _developmentMessage;
    public string? CommitMessage { get => _commitMessage; }
    public string? DevelopmentDetails { get => _developmentMessage; }
    public DateTime Timestamp { get; set; }
    public string Author { get; set;}

}