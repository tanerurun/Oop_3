using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Database loglandı.");
        }
    }
}
