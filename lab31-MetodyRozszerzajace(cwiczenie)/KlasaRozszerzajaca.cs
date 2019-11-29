using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab31_MetodyRozszerzajace_cwiczenie_
{
    public static class KlasaRozszerzajaca
    {

        public static int IloscDniNaZiemi(this DateTime dataUrodzenia )
        {
           
            

            return Convert.ToInt32((DateTime.Today - dataUrodzenia).TotalDays);
        }

    }
}
