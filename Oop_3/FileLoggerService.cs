using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosya loglandı.");
        }
    }
}
