using System;
using System.Collections.Generic;

namespace gtask_tracker.console.app
{
    public class CommandLineParserInterface
    {
        private List<CLICommand> _commands;

        public CommandLineParserInterface()
        {
            _commands = new List<CLICommand>();
        }
        public void AddCommand(CLICommand command)
        {
            _commands.Add(command);
        }
        public void Run(string[] args)
        {
            foreach( string a in args)
            {
                foreach(CLICommand command in _commands)
                {
                    if(command.Validate(a))
                    {
                        command.Execute();
                        break;
                    }
                }
               
            }
        }

        
    }
}