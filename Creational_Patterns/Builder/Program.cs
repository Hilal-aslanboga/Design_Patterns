using Builder.Lab_1.Concrete;
using Builder.Lab_1.Delegate;
using Builder.Lab_1.Directories;
using Builder.Lab_1.Interface;
using Builder.Lab_2.Abstarct;
using Builder.Lab_2.Concrete;
using Builder.Lab_2.Directories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            Directory directory = new Directory();
            IBuilder builder_1 = new Builder_1();
            IBuilder builder_2 = new Builder_2();

            directory.Constructor(builder_1);
            Product product_1 = builder_1.GetResult();
            product_1.Display();

            directory.Constructor(builder_2);
            Product product_2 = builder_2.GetResult();
            product_2.Display();
            #endregion

            #region Lab_2
            KrediKartiBuilder americanExpress = new AmericanExpress();
            KrediKartiBuilder masterCart = new MasterCart();
            KrediKartiBuilder visaCart = new VisaCart();

            KartDirectory kartDirectory = new KartDirectory();
            kartDirectory.KrediCartBuilder(americanExpress);

            KartDirectory kartDirectory2 = new KartDirectory();
            kartDirectory.KrediCartBuilder(masterCart);

            KartDirectory kartDirectory3 = new KartDirectory();
            kartDirectory.KrediCartBuilder(visaCart);

            Console.WriteLine(americanExpress.Kart.BankaAdi);
            Console.WriteLine(americanExpress.Kart.KartTipi);
            Console.WriteLine(americanExpress.Kart.KartLimiti);
            Console.WriteLine(americanExpress.Kart.TaksitAlma);
            Console.WriteLine("\n");
            Console.WriteLine(masterCart.Kart.BankaAdi);
            Console.WriteLine(masterCart.Kart.KartTipi);
            Console.WriteLine(masterCart.Kart.KartLimiti);
            Console.WriteLine(masterCart.Kart.TaksitAlma);
            Console.WriteLine("\n");
            Console.WriteLine(visaCart.Kart.BankaAdi);
            Console.WriteLine(visaCart.Kart.KartTipi);
            Console.WriteLine(visaCart.Kart.KartLimiti);
            Console.WriteLine(visaCart.Kart.TaksitAlma);
            #endregion

            Console.ReadKey();
        }
    }
}
