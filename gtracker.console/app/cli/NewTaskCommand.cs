using System;

namespace gtask_tracker.console.app.commands
{
    public class NewTaskCommand : ICommand
    {
        public void Run()
        {
            Console.WriteLine("new task has been reached");
        }
    }
}