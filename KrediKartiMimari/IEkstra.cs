using System;

namespace KrediKartiMimari
{
    public interface IEkstra
    {
        bool EkKartMi { get; set; }

        DateTime SonKullanimTarihi { get; set; }

        void BorcOde(decimal tutar);
    }

}
