using System;
using System.Collections.Generic;
using System.Text;

namespace Corso.NET._06_TipoChar
{
    internal static class EsempioChar
    {
        public static void EseguiEsempioChar()
        {
            /* Tipo primitivo letterale
             * char
             * può avere presenti nell'insieme dei caratteri Unicode
             * ed è rappresentato nella forma UTF-16 */

            /*
             Il tipo char in .NET occupa 2 byte e segue la codifica UTF-16.
             Questo significa che puoi mappare valori decimali da 0 a 65535
             */
            char a = '\u0041'; /* A (A dell'alfabeto latino) */
            char g = '\u03b1'; /* A (A dell'alfabeto greco) */
            /*
             \u significa che il numero esadecimale che segue rappresenta un carattere Unicode.
            */

            char b = (char)(a + 1); /* Ottengo B come somma di 0041 + 1 */
            b = (char)65;

            /* Caratteri di Escape */
            /* \n return    */
            /* \\ backslash    */
            /* \t Tab    */
            /* \' apice singolo   */
            /* \" doppio apice   */

            char c = '\u23da';  /* Simbolo di messa a terra */
            c = '\u042b'; /* YERU (Alfabeto cirillico) */
            c = '\u6c34'; /* Ideogramma cinese della parola 'acqua' */

            /* Mappa dei caratteri dell'alfabeto latino:
             * https://www.unicode.org/charts/PDF/U0000.pdf
             * */

            //Emoji
            char cuore = '\u2764';

            char[] emojiChars = ['\uD83D', '\uDE00'];
            string renderEmoji = new string(emojiChars);

        }
    }
}
