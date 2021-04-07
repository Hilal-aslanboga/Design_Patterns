using Adapter.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Lab_1.Concrete
{
   public class ArabaAdapter : ArabaUyarlıyıcı, IAraba
    {
        public string Istek(double inch) => $"Kar Lastiğine geçebilir {inch}";
    }
}
