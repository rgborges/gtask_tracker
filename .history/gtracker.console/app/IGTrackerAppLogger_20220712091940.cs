namespace gtask_tracker.console.app
{
    public enum LogLevel
    {
        Info,
        Warning
    }
    public interface IGTrackerAppLogger
    {
        void LogMessage(LogLevel level, string message).;
    }
}