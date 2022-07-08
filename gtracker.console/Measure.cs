using System;

namespace gtask_tracker.console
{
    internal class Measure
    {
        internal static void Run(Action task)
        {
            DateTime start = DateTime.Now;
            task();
            System.Console.WriteLine($"{DateTime.Now.Subtract(start).Milliseconds} ms");
        }
    }
}