using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    interface IWyszukaj
    {
       int szukac_prod(float min_cena, float max_cen, string nazwa);
       int szukac_prod(float min_cena, string nazwa);
       int szukac_prod(string nazwa);
       int szukac_prod(float max_cen);
    }
}
