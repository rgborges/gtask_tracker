using System;
using gtask_tracker.console.models;

namespace gtask_tracker.console.app
{
    public static class Display
    {
        public static void PrintReport(ReportDTO report)
        {
            System.Console.WriteLine(report.Title);
            System.Console.WriteLine("--------------------------");
            foreach( TaskLogDTO t in report.Tasks)
            {
                System.Console.WriteLine($"{nameof(t.Name)}: {t.Name} | {nameof(t.Status)} : {t.Status}");
                System.Console.WriteLine($"{nameof(t.Description)}: {t.Description}");
                foreach( TaskLogRecordDTO r in t.Records)
                {
                    System.Console.WriteLine($"\t\t{nameof(r.CommitMessage)} : {r.CommitMessage} {r.Timestamp}");
                    System.Console.WriteLine($"\t\t\t{nameof(r.DevelopmentDetails)} : {r.DevelopmentDetails}");
                }
            }
        }

        internal static void PrintLog(LogLevel level, string message)
        {
            switch(level)
            {
                case (LogLevel.Info):
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[INFO]: ");
                break;
            }
        }
    }
}