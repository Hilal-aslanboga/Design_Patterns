using FactoryMethod.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Lab_1.Concrete
{
    public class Product_A : IProduct
    {
        public string ShipFrom() => "from North African.";
    }
}
