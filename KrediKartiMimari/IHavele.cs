using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartiMimari
{
    public interface IHavele
    {
        void HaveleGonder(string iban, decimal tutar);
    }

}
