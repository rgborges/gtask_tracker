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
                System.Console.WriteLine($"{nameof(t.Name)}: {t.Name}");
                foreach( TaskLogRecordDTO r in t.Records)
                {
                    System.Console.WriteLine($"{nameof(t.Name)} : {t.Name} | {nameof(t.Status)} : {t.Status}");
                    System.Console.WriteLine($"\t{nameof(t.Description)} : {t.Description}");
                    foreach 
                }
            }
        }
    }
}