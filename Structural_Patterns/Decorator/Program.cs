using Decorator.Lab_1.Abstarct;
using Decorator.Lab_1.Client;
using Decorator.Lab_1.Concrete;
using Decorator.Lab_2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            Araba araba = new HamAraba();

            Client.Display("1.ham hali: ", araba);
            Console.WriteLine("\n");
            Client.Display("Ham haline dekoratör led eklenmiş hali: ", new Led(araba));
            Console.WriteLine("\n");
            Client.Display("Ham haline dekoratör sticker eklenmiş hali: ", new Sticker(araba));
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("\n");
            #endregion

            #region Lab_2
            var lesson1 = new CSharp() { LessonName = "C# Lesson", PurchasePrice = 10000 };
            var lesson2 = new Database() { LessonName = "Microsoft Sql Server Lesson", PurchasePrice = 10000 };
            var lesson3 = new Java() { LessonName = "Java", PurchasePrice = 10000 };

            PurchaseOffer csharp = new PurchaseOffer(lesson1);
            csharp.DiscountedPercentage = 20;

            PurchaseOffer database = new PurchaseOffer(lesson1);
            database.DiscountedPercentage = 30;

            PurchaseOffer java = new PurchaseOffer(lesson1);
            java.DiscountedPercentage = 50;

            Console.WriteLine($"Not Applied Discounted: {lesson1.PurchasePrice}");
            Console.WriteLine($"Applied Discount: {csharp.PurchasePrice}");
            Console.WriteLine("\n");
            Console.WriteLine($"Not Applied Discounted: {lesson2.PurchasePrice}");
            Console.WriteLine($"Applied Discount: {database.PurchasePrice}");
            Console.WriteLine("\n");
            Console.WriteLine($"Not Applied Discounted: {lesson3.PurchasePrice}");
            Console.WriteLine($"Applied Discount: {java.PurchasePrice}");
            #endregion

            Console.ReadKey();
        }
    }
}
