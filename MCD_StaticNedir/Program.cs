using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_StaticNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Static nesne örneği alınmadan ulaşabildiğimiz metot, field, sınıf...
             * Tip M1 = new Tip();
             * Tip. 
             * 
             * 
             * 
             * 
             */
            //Stack bölge içerisinde pointerımız oluştu.
            Ogrenci o1;
            //Stack bölgede pointer oluştuğu zaman static olan bir yapıcı metot çalıştı ve yine class içerisinde tanımlı olan static field, metot static dediğimiz bölgede oluşturuldu.
            Ogrenci.Test2();

            o1 = new Ogrenci();
            //Stack bölgede pointer => kendini heap bölgede tamamladı... static olmayan tanımlarını tamamladı...
            o1.Test1();//nesne örneği alındıktan sonra test1 adındaki metotuma ulaşabildim.

            /*Static kavramı gerçek hayatta nerelerde kullanılır...
             * 
             * 1-Helper.cs => Kontroller
             * 2-Oluşturmuş olduğumuz nesnemizin => bağımlılığı farklı classlara olduğu için (Proje içerisinde özel olduğu için ) nesne içerisinde static metot tanımları yapılır.
             * 3-Class içerisinde bir field (static) tanımı yapar ilgili field içerisinde bir değer ataması yaparız. Daha sonra uygulama içerisinde N farklıyerde oluşturmuş olduğumuz static fieldığımıza ulaşır değerimizi okuruz.
             * 4-[Uygulama] => [ozelHelper] => [DLL(Kütüphane)]
             * 
             */

        }
    }
}
