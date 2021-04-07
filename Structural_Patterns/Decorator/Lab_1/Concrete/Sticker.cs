using Decorator.Lab_1.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Lab_1.Concrete
{
    public class Sticker : HamAraba
    {
        Araba _araba;

        public Sticker(Araba araba) => _araba = araba;


        public override string Modified() => _araba.Modified() + "Arabaya etiketler takılması gerekiyor.";
        //dekore ettik
    }
}
