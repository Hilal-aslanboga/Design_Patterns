using Builder.Lab_2.Abstarct;
using Builder.Lab_2.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lab_2.Concrete
{
    public class VisaCart : KrediKartiBuilder
    {
        public VisaCart() => _kart = new KrediKarti();

        public override void BankaAdi() => _kart.BankaAdi = "Garanti Bankası";

        public override void KartLimiti() => _kart.KartLimiti = 10000;

        public override void KartTipi() => _kart.KartTipi = "Visa";

        public override void TaksitAlma() => _kart.TaksitAlma = true;
    }
}
