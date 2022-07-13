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
            
        

            Measure.Run(() => {
                var logger = new GTrackerConsoleLogger();
                logger.LogMessage(LogLevel.Info, "This is an info message")
            });
            Console.WriteLine("End");
        }
    }
}