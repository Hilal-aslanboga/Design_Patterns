using Builder.Lab_2.Abstarct;
using Builder.Lab_2.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lab_2.Concrete
{
    public class MasterCart : KrediKartiBuilder
    {
        public MasterCart() => _kart = new KrediKarti();

        public override void BankaAdi() => _kart.BankaAdi = "İş Bankası";

        public override void KartLimiti() => _kart.KartLimiti = 10000;

        public override void KartTipi() => _kart.KartTipi = "Master Card";

        public override void TaksitAlma() => _kart.TaksitAlma = false;
    }
}
