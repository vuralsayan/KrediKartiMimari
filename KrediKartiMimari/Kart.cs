using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartiMimari
{
    public abstract class Kart
    {
        public string BankaAdi { get; set; }
        public string KartAdi { get; set; }
        public KartTuru KartTuru { get; set; }
        public int CVCKodu { get; set; }

        public void ParaCek(decimal tutar)
        {

        }

        public void ParaYatirma(decimal tutar)
        {

        }
    }

    public enum KartTuru
    {
        Visa,
        Master
    }
}
