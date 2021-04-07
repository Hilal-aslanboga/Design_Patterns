using Observer.Lab_2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Lab_2.Concrete
{
    public class ConcreteProduct : Product
    {
        public ConcreteProduct(string productName, int price) : base(productName, price) { }
    }
}
