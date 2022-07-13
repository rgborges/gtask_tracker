namespace gtask_tracker.console.app
{
    public class GTrackerConsoleLogger : IGTrackerAppLogger
    {
        public void LogMessage(LogLevel level, string message)
        {
            Display.PrintLog(LogLevel level)
        }
    }
}