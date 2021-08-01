using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_3
{
    class BasvuruManager
    {
        //burada iki metot var biri başvur diğeri bilgilendirme 
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            krediManager.Hesapla();
            foreach (var item in loggerServices)
            {
                item.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var item in krediler)
            {
                item.Hesapla();
            }
        }
    }
}
