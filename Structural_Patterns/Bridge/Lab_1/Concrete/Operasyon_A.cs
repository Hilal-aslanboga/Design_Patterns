using Bridge.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Lab_1.Concrete
{
    public class Operasyon_A : IKopru
    {
        public string OperasyonUygulamasi() => "Operasyon A";
    }
}
