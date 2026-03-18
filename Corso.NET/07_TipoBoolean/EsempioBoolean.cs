using System;
using System.Collections.Generic;
using System.Text;

namespace Corso.NET._07_TipoBoolean
{
    internal static class EsempioBoolean
    {
        public static void EseguiEsempioBoolean() { 
            bool variabileBool; // Occupa 1 byte in memoria e può assumere solo i valori true o false
            variabileBool = false;
            if (variabileBool) { 
                Console.WriteLine("La variabile è vera");
            } else { 
                Console.WriteLine("La variabile è falsa");
            }

        }
    }
}
