using Builder.Lab_2.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lab_2.Directories
{
    class KartDirectory
    {
        public void KrediCartBuilder(KrediKartiBuilder krediKartiBuilder)
        {
            krediKartiBuilder.BankaAdi();
            krediKartiBuilder.KartTipi();
            krediKartiBuilder.KartLimiti();
            krediKartiBuilder.TaksitAlma();
        }
    }
}
