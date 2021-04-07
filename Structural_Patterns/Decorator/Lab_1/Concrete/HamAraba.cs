using Decorator.Lab_1.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Lab_1.Concrete
{
    public class HamAraba : Araba
    {
        //temel Modified, bu string söz öbeğini birazdan açacağımız decoratörler aracıkığıyla dekore edeceğiz.
        public override string Modified() => "Çalıştığım galeri için: ";
    }
}
