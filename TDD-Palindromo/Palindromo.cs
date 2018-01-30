using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao
{
    public class Palindromo
    {
        public bool EhPalindromo(String frase)
        {
            String fraseFiltrada = frase
                    .ToUpper().Replace(" ", "").Replace("-", "");

            for (int i = 1; i < fraseFiltrada.Length; i++)
            {
                if(fraseFiltrada.Length == 1)
                {
                    return true;
                }
                if (fraseFiltrada[i-1] != fraseFiltrada[fraseFiltrada.Length - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
