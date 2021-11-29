using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_StaticNedir
{
   public class Ogrenci
    {
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public string EmailAdres { get; set; }

        public void Test1()
        {
            Console.WriteLine("Nesne örneği alındıktan sonra çalışma metot");
            Test2();
            //*Static olmayan bir metot static olan bir metodu çağırabilir.
        }

        public static void Test2()
        {
            Console.WriteLine("Nesne örneği alınmadan kullanılabilir!");
            //Test1(); Static olan bir metotda static olmayan bir metot çağırılmaz.
        }
    }
}
