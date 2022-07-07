using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace gtask_tracker.console.app
{
    public delegate void RunCommandAction();
    public class CLICommand
    {
        private string _command;
        private string _description = "";
        private ICommand _action;
        
        public CLICommand(string command, ICommand action)
        {
            this._command = command;
            this._action = action;
        }
        public CLICommand(string command, ICommand action, string description)
        {
            this._command = command;
            this._action = action;
            this._description = description;    
        }
        public void Execute()
        {
            _action.Run();
        }
        public bool Validate(string inputCommand)
        {
            if (string.IsNullOrEmpty(inputCommand))
            {
                return false;
            }
            if (inputCommand == _command.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
