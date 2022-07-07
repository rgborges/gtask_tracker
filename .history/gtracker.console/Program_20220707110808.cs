using System;
using System.Text.Json.Serialization;
using gtask_tracker.console.app;
using gtask_tracker.console.app.commands;
using Newtonsoft.Json;

namespace gtask_tracker.console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] testArgs = {"new", "list", "set", "hello"};
            // var cli = new CommandLineParserInterface();
            // var helloCommand = new CLICommand("hello", new HelloCommand(), "hello command");
            // var newCommand = new CLICommand("new", new NewTaskCommand(), "this is a new command");
            // cli.AddCommand(helloCommand);
            // cli.AddCommand(newCommand);
            // cli.Run(testArgs);

            string appSettings = @"{
                    'DataDirectory' : 'C:\\Users\\TG456GS\\source\\repos\\Labs\\my_framework\\gtask_tracker\\gtracker.console\\'
            }";

            AppConfiguration appConfig = JsonConvert.DeserializeObject<AppConfiguration>(appSettings);

            
        }
    }
}
