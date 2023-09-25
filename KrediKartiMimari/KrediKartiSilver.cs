using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartiMimari
{
    public class KrediKartiSilver : Kart, IEkstra, IEft, ITaksit
    {
        public bool EkKartMi { get; set; }
        public DateTime SonKullanimTarihi { get; set; }
        public bool KisitlamaVarMi { get; set; }
        public DateTime KisitlamaTarihi { get; set; }

        public void BorcOde(decimal tutar)
        {
            throw new NotImplementedException();
        }

        public void EftGonder(string iban, decimal tutar)
        {
            throw new NotImplementedException();
        }

        public void TaksitYap(decimal tutar, int taksitSayisi)
        {
            throw new NotImplementedException();
        }
    }
}
