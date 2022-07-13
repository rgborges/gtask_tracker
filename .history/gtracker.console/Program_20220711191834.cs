using System;
using System.Text.Json.Serialization;
using gtask_tracker.console.app;
using gtask_tracker.console.app.commands;
using gtask_tracker.console.app.debug;
using Newtonsoft.Json;

namespace gtask_tracker.console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var appBuilder = new AppBuilder()
            .UseCli()
            .UseLogger()
            .UseRepository

            Measure.Run(() => {
                var report = Debug.GetSampleData();
                Display.PrintReport(report);
            });
            Console.WriteLine("End");
        }
    }
}