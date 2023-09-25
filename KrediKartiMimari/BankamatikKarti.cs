using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartiMimari
{
    public class BankamatikKarti : Kart, IHavele
    {
        public HesapTuru HesapTuru { get; set; }
        public decimal Bakiye { get; set; }

        public void HaveleGonder(string iban, decimal tutar)
        {
            throw new NotImplementedException();
        }

        public void LimitTanimla(decimal tutar)
        {
            throw new NotImplementedException();
        }
    }
}
