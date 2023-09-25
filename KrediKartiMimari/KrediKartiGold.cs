using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartiMimari
{
    public class KrediKartiGold : Kart, IHavele, IPuan, IEkstra, ITaksit
    {
        public decimal KazanilanPuan { get; set; }
        public bool EkKartMi { get; set; }
        public DateTime SonKullanimTarihi { get; set; }
        public bool IndirimOzelligiVarMi { get; set; }
        public bool KampanyaTanimliMi { get; set; }
        public DateTime KampanyaBaslangicTarihi { get; set; }
        public DateTime KampanyaBitisTarihi { get; set; }

        public void BorcOde(decimal tutar)
        {
            throw new NotImplementedException();
        }
        public void KampanyaTanimla()
        {
            throw new NotImplementedException();
        }

        public void KampanyaBitir()
        {
            throw new NotImplementedException();
        }


        public void HaveleGonder(string iban, decimal tutar)
        {
            throw new NotImplementedException();
        }

        public void TaksitYap(decimal tutar, int taksitSayisi)
        {
            throw new NotImplementedException();
        }
    }
}
