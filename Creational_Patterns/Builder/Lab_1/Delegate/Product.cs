using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lab_1.Delegate
{
    public class Product
    {
        List<string> parts = new List<string>();

        public void Add(string part) => parts.Add(part);

        public void Display()
        {
            Console.WriteLine("\nProducts Parts");

            foreach (string part in parts)
                Console.WriteLine(part);

            Console.WriteLine();
        }
    }
}
