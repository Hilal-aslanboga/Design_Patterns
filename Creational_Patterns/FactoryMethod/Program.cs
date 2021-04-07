using FactoryMethod.Lab_1.Creator;
using FactoryMethod.Lab_1.Interface;
using FactoryMethod.Lab_2.Concrete;
using FactoryMethod.Lab_2.Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            ProductCreator productCreator = new ProductCreator();
            IProduct product;
            for (int mounth = 1; mounth <= 12; mounth++)
            {
                product = productCreator.FactoryMethod(mounth);
                Console.WriteLine($"Coffee Beans : {product.ShipFrom()}");
            }
            #endregion

            Console.WriteLine("\n");

            #region Lab_2
            SystemManager systemManager = new SystemManager(new SystemLoggerFactory());
            systemManager.Save();
            #endregion

            Console.ReadKey();
        }
    }
}
