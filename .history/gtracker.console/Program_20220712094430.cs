﻿using System;
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
            var logger = GTrackerConsoleLogger
            Measure.Run(() => {
               
            });
            Console.WriteLine("End");
        }
    }
}