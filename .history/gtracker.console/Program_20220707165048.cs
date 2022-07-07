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
            string appSettings = @"{
                    'DataDirectory' : 'C:\\Users\\TG456GS\\source\\repos\\Labs\\my_framework\\gtask_tracker\\gtracker.console\\'
            }";

            AppConfiguration appConfig = JsonConvert.DeserializeObject<AppConfiguration>(appSettings);
            if( appConfig is not null)
            {
                Console.WriteLine(appConfig.DataDirectory);
            }
            System.Console.WriteLine("End");

        }
    }
}
