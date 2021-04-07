using Singleton.Lab_1;
using Singleton.Lab_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            var singletonManager = SingletonManager.CreateSingletonObject(); //bu custom method vasıtasıyla bir nesnemizi kontrollü bir şekilde ürettik.
            singletonManager.CreateLog(); //singletonManager değişkeni üzerinden SingletonManager.cs sınıfının CreateLog() yeteneğine eriştim ve onu kullanabildim.
            #endregion

            Console.WriteLine("\n");

            #region Lab_2
            int result = SingletonClass.Sinif.Toplam(5, 8);
            Console.WriteLine($"Result is {result}");
            #endregion

            Console.ReadKey();
        }
    }
}
