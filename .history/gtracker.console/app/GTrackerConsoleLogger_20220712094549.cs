namespace gtask_tracker.console.app
{
    public class GTrackerConsoleLogger : IGTrackerAppLogger
    {
        public 
        public void LogMessage(LogLevel level, string message)
        {
            Display.PrintLog(level, message);
        }
    }
}