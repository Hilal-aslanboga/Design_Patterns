using Adapter.Lab_1.Concrete;
using Adapter.Lab_1.Interface;
using Adapter.Lab_2.Concrete;
using Adapter.Lab_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            ArabaUyarlıyıcı uyarlıyıcı = new ArabaUyarlıyıcı();
            Console.WriteLine($"Tekerleğin inchi { uyarlıyıcı.HamAraba(18.7)}");

            IAraba adaptor_3 = new ArabaAdapter();
            Console.WriteLine(adaptor_3.Istek(19.5));
            Console.WriteLine("\n");

            #endregion

            #region Lab_2
            Bagdastirici bagdastirici = new Bagdastirici();
            ITarget target = new ConcreteAdaptor(bagdastirici);

            Console.WriteLine("İşlemci ile uyumsuz");
            Console.WriteLine("Adaptör bunu çağırabilir");
            Console.WriteLine(target.GetRequest());

            #endregion

            Console.ReadKey();
        }
    }
}
