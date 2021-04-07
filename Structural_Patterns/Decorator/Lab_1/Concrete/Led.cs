using Decorator.Lab_1.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Lab_1.Concrete
{
    public class Led : HamAraba
    {
        Araba _araba;

        public Led(Araba araba) => _araba = araba;

        public override string Modified() => _araba.Modified() + "Arabanın ön camlarına led takılması gerekiyor.";
        //dekore ettik
    }
}
