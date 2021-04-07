using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lab_2.Delegate
{
    public class KrediKarti
    {
        public string BankaAdi { get; set; }
        public string KartTipi { get; set; }
        public int KartLimiti { get; set; }
        public bool TaksitAlma { get; set; }

        public override string ToString() => $"{BankaAdi} bankasına ait müşteri {KartTipi}'ni kullanmakta ve kartınızın limiti {KartLimiti}";
    }
}
