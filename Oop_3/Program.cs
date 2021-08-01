using System;
using System.Collections.Generic;

namespace Oop_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtyacKrediManager = new IhtiyacKredisiManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();
            IKrediManager tasitKrediManager = new TasitKredisiManager();
            IKrediManager konutKrediManager = new KonutKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> logger = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
            BasvuruManager basvuruManager = new BasvuruManager();
            AsyncCallback.BasvuruYap(new EsnafKredisiManager(), logger);
            List<IKrediManager> krediler = new List<IKrediManager> { ihtyacKrediManager,tasitKrediManager};
            Console.WriteLine("Hello World!");
        }
    }
}
