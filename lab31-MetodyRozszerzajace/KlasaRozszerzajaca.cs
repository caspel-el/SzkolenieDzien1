using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab31_MetodyRozszerzajace
{
    public static class KlasaRozszerzajaca
    {
        public static int ZliczSlowa(this String tekst)
        {
            int iloscSlow = 0, index = 0;

            while (index<tekst.Length)
            {
                while (index<tekst.Length && !char.IsWhiteSpace(tekst[index]))
       
                    index++;
                    iloscSlow++;
                    while (index<tekst.Length && char.IsWhiteSpace(tekst[index]))
                        index++;
                    
                

            }
            return iloscSlow;
        }
    }
}
