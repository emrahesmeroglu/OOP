using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Log info inserted to DB!");
        }
    }
}
