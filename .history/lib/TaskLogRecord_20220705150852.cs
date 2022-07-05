public class TaskLogRecord 
{
    private string? _commitMessage;
    private string? _developmentMessage;
    public string? CommitMessage { get => _commitMessage; set; }
    public string? DevelopmentDetails { get; set; }
    public DateTime Timestamp { get; set; }
    public string Author { get; set;}

}