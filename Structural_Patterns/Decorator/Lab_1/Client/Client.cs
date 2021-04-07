using Decorator.Lab_1.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Lab_1.Client
{
    public class Client
    {
        public static void Display(string s, Araba araba) => Console.WriteLine(s + araba.Modified());
    }
}
