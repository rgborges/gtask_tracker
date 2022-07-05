public class TaskLogDTO : Entity
{
    public string CommitMessage { get; set; }
    public string DevelopmentDetails { get; set; }
    public DateTime Timestamp { get; set; }
}