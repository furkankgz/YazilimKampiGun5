using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager IhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager TasitKrediManager = new TasitKrediManager();
            IKrediManager KonutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(KonutKrediManager, fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {IhtiyacKrediManager, TasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
