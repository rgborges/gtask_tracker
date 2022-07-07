using System;
using System.Collections.Generic;
using gtask_tracker.console.lib;

namespace gtask_tracker.console.app.debug
{
    public class Debug
    {
        private DateTime startTime;
        public Report GetSampleData()
        {
            var book = new Report("Rafael Borges");
            book.Add(new TaskLogRecord("Iniciando nova tarefa", "Rodando mais uma tarefa", "Rafael Borges"));

            return book;
        }
    }
}