using Builder.Lab_2.Abstarct;
using Builder.Lab_2.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lab_2.Concrete
{
    public class AmericanExpress : KrediKartiBuilder
    {
        public AmericanExpress() => _kart = new KrediKarti();

        public override void BankaAdi() => _kart.BankaAdi = "Bank of America";

        public override void KartLimiti() => _kart.KartLimiti = 10000;

        public override void KartTipi() => _kart.KartTipi = "American Express";

        public override void TaksitAlma() => _kart.TaksitAlma = true;
    }
}
