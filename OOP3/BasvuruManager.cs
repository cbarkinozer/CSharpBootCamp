using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) 
        {
            //Başvuru bilgilerini değerlendirme

            //!!!Aşağıdaki gibi yaparsan tüm başvurular konut kredi managera bağımlı
            //hale gelir bu doğru bir yöntem değildir

            // KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //Onun yerine parametre olarak interfaceimizi ekledikten sonra bunu yazıyoruz
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) 
        {
            foreach ( var kredi in krediler) 
            {
                kredi.Hesapla();
            }
        }
    }
}
