using System;

namespace gtracker.console.Application
{
    public class GTrackerApplication
    {
        private ICommandLine? _cli;
        private bool _loop = false;
        public GTrackerApplication()
        {

        }
        public void Add(ICommandLine commandLine)
        {
            if (commandLine == null)
            {
                throw new ArgumentNullException("The command line object passed to the application is null");
            }
            _cli = commandLine;
        }
        public void Run(string[] args)
        {
            if( _cli is null) 
            { 
                throw new NullReferenceException("You ");
            }
            _cli.Run(args);
        }
        public void RunInteractive()
        {

        }
    }
}
