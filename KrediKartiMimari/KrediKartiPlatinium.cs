using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartiMimari
{
    public class KrediKartiPlatinium : Kart, IHavele, IPuan, IEkstra, IEft
    {
        public bool ClubUyeligiVarMi { get; set; }

        public DateTime UyelikBaslangicTarihi { get; set; }
        public DateTime UyelikBitisTarihi { get; set; }
        public decimal KazanilanPuan { get; set; }
        public bool EkKartMi { get; set; }
        public DateTime SonKullanimTarihi { get; set; }

        public void BorcOde(decimal tutar)
        {
            throw new NotImplementedException();
        }

        public void HaveleGonder(string iban, decimal tutar)
        {
            throw new NotImplementedException();
        }

        public void UyeligiYenile()
        {
            throw new NotImplementedException();
        }

        public void UyeligiBitir()
        {
            throw new NotImplementedException();
        }

        public void EftGonder(string iban, decimal tutar)
        {
            throw new NotImplementedException();
        }
    }
}
