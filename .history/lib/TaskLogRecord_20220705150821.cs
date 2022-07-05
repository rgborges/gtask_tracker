public class TaskLogRecord 
{
    private string _commitMessage
    public string? CommitMessage { get; set; }
    public string? DevelopmentDetails { get; set; }
    public DateTime Timestamp { get; set; }
    public string Author { get; set;}

}