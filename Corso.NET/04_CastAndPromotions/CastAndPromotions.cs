using System;
using System.Collections.Generic;
using System.Text;

namespace Corso.NET._04_CastAndPromotions
{
    internal static class CastAndPromotions
    {
        public static void EseguiCastAndPromotions()
        {
            //Tipi Interi:
            //Il tipo di default è int.
            //Tipi come byte e short vengono automaticamente "promossi" a int durante le operazioni aritmetiche.

            //Tipi con virgola - standard IEEE 754:
            //float: Più leggero ma meno preciso. Richiede il suffisso f.
            //double: Il default per i numeri decimali. Veloce, basato su binario (IEEE 754).

            //Tipi con virgola - non IEEE 754
            //decimal: Più lento ma estremamente preciso. Si usa per i calcoli monetari. Richiede il suffisso m.

            //Casting:
            //Implicito: Automatico se non c'è rischio di perdere dati (es. da int a double).
            //Esplicito: Obbligatorio se c'è rischio di perdere dati (es.da double a int, dove si perde la parte decimale).

            //Special Values:
            //Infinity e NaN esistono solo per float e double.
            //Con gli interi o il tipo decimal, dividere per zero causerà sempre un errore (DivideByZeroException).


            // Numeri Interi (Signed e Unsigned)
            sbyte intero8Bit = 127;          // -128 a 127
            byte intero8BitU = 255;         // 0 a 255
            short intero16Bit = 32767;
            ushort intero16BitU = 65535;
            int intero32Bit = 2_147_483_647; // Tipo di default per gli interi
                                             // int errore1 = _100;    // Errore: interpretato come nome di variabile
                                             // double errore2 = 10_.5; // Errore: vicino al punto decimale
                                             // float errore3 = 100_;   // Errore: alla fine del numero
            uint intero32BitU = 4_294_967_295U;
            long intero64Bit = 9_223_372_036_854_775_807L;
            ulong intero64BitU = 18_446_744_073_709_551_615UL;

            // Numeri con la virgola (Floating Point e Decimal)
            float virgolaSingola = 3.14f;    // 32 bit, precisione ~7 cifre
            double virgolaDoppia = 3.14159;  // 64 bit, precisione ~15-17 cifre (default)
            decimal altaPrecisione = 79228.1625m; // 128 bit, ideale per calcoli finanziari

            // Conversione Implicita (Widening): da tipo piccolo a tipo grande (nessuna perdita)
            int piccoloIntero = 100;
            double grandeVirgola = piccoloIntero;
            Console.WriteLine($"Implicito (int -> double): {grandeVirgola}");

            // Conversione Esplicita (Narrowing): da tipo grande a tipo piccolo (richiede cast)
            double valorePrecisione = 9.99;
            int valoreTroncato = (int)valorePrecisione; // Perde la parte decimale
            Console.WriteLine($"Esplicito (double -> int): {valoreTroncato} (troncato)");


            // Regola: in un'operazione, i tipi più piccoli di 'int' vengono promossi a 'int'
            byte b1 = 10;
            byte b2 = 20;
            // byte b3 = b1 + b2; // ERRORE: b1 + b2 produce un 'int'
            int risultatoPromosso = b1 + b2;
            Console.WriteLine($"Promozione (byte + byte = int): {risultatoPromosso}");

            // Regola: se c'è un 'double', tutto viene promosso a 'double'
            int intero = 5;
            double sommaMista = intero + 2.5; // intero viene promosso a double
            Console.WriteLine($"Promozione (int + double = double): {sommaMista}");

            // 4. OPERAZIONI CON NaN E INFINITY
            Console.WriteLine("\n--- 4. NaN e Infinity (Solo float/double) ---");

            // Divisione per zero con numeri a virgola mobile non lancia eccezioni
            double zero = 0.0;
            double positivo = 10.0;
            double negativo = -10.0;

            double infPositivo = positivo / zero;
            double infNegativo = negativo / zero;
            double nonUnNumero = zero / zero;

            Console.WriteLine($"10.0 / 0.0 = {infPositivo}"); // Infinity
            Console.WriteLine($"-10.0 / 0.0 = {infNegativo}"); // -Infinity
            Console.WriteLine($"0.0 / 0.0 = {nonUnNumero}");  // NaN (Not a Number)

            // Proprietà di NaN
            Console.WriteLine($"NaN == NaN? {nonUnNumero == double.NaN}"); // False! NaN non è mai uguale a nulla
            Console.WriteLine($"IsNaN? {double.IsNaN(nonUnNumero)}");      // Vero metodo per controllare

            // 5. ECCEZIONI NEI TIPI INTERI
            Console.WriteLine("\n--- 5. Divisione per zero (Interi) ---");
            try
            {
                //int divZero = 10 / 0; // Questo lancia DivideByZeroException
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Errore: La divisione per zero con numeri INTERI lancia un'eccezione.");
            }


            // 88
            int numeroBin = 0b0101_1000;
            //20
            int numeroHex = 0x14;

            // 2. Operazione di prodotto
            // Il computer lavora sempre in binario internamente, 
            // quindi non importa come abbiamo scritto i numeri.
            int prodotto = numeroBin * numeroHex;

            // 3. Visualizzazione nei tre formati
            Console.WriteLine($"Primo numero (88):       {numeroBin} (scritto come 0b0101_1000)");
            Console.WriteLine($"Secondo numero (20):     {numeroHex} (scritto come 0x14)");
            Console.WriteLine($"Prodotto (88 * 20):      {prodotto}");
        }

    }
}
