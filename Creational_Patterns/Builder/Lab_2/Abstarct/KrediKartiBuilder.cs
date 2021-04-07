using Builder.Lab_2.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lab_2.Abstarct
{
    public abstract class KrediKartiBuilder
    {
        protected KrediKarti _kart;

        public KrediKarti Kart { get => _kart; }

        public abstract void BankaAdi();
        public abstract void KartTipi();
        public abstract void KartLimiti();
        public abstract void TaksitAlma();
    }
}
