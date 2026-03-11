using System.Runtime.CompilerServices;

namespace Corso.NET.Puntatori
{
    internal unsafe class ValoriEIndirizzi
    {
        public static void StampaVariabili()
        {
            byte numero = 27;

            byte* puntatore = &numero;
            long indirizzo = (long)puntatore;

            Console.WriteLine($"--- Valore della variabile ---");
            Console.WriteLine($"Esadecimale (HEX):  0x{Convert.ToString(numero, 16).ToUpper()}");
            Console.WriteLine($"Decimale (DEC):     {numero}");
            Console.WriteLine($"Ottale (OCT):       {Convert.ToString(numero, 8).PadLeft(8, '0')}");
            Console.WriteLine($"Binario (BIN):      {Convert.ToString(numero, 2).PadLeft(8, '0')}");

            Console.WriteLine();
            Console.WriteLine($"--- Indirizzo di memoria della variabile ---");
            Console.WriteLine($"Esadecimale (HEX):          {indirizzo:X}");
            Console.WriteLine($"Decimale (DEC):             {indirizzo} oppure {indirizzo:D}");
            Console.WriteLine($"Ottale (OCT):               {Convert.ToString(indirizzo, 8)}");
            Console.WriteLine($"Binario (BIN):              {indirizzo:B}");
            Console.WriteLine($"Binario a 64 bit (BIN64):   {indirizzo:B64}");

            Console.WriteLine();
            Console.WriteLine($"--- Recupero valore da indirizzo ---");
            byte valoreRecuperatoDaIndirizzo = *puntatore;
            Console.WriteLine($"Leggo il valore tramite indirizzo:           {valoreRecuperatoDaIndirizzo}");
            Console.WriteLine($"Leggo il valore tramite indirizzo (HEX):     {valoreRecuperatoDaIndirizzo:X}");

            Console.WriteLine();
            Console.WriteLine($"--- Recupero indirizzo tramite Unsafe.AsPointer ---");
            // Ottiene il puntatore senza usare esplicitamente l'operatore &
            void* ptr1 = Unsafe.AsPointer(ref numero);
            Console.WriteLine($"Indirizzo ottenuto tramite Unsafe.AsPointer: {(long)ptr1:X}");


            byte nuovonumero = numero;
            byte* ptr2 = &nuovonumero;
            long address1 = (long)ptr2;

            Console.WriteLine($"Valore di 'nuovonumero': {nuovonumero}");
            Console.WriteLine($"Indirizzo di 'nuovonumero': {address1}");

            ref byte nuovonumeroRef = ref numero;
            //byte* ptr3 = &nuovonumeroRef;
            unsafe
            {
                // Usiamo 'fixed' per bloccare il riferimento in una posizione fissa
                fixed (byte* ptr3 = &nuovonumeroRef)
                {
                    long address2 = (long)ptr3;
                    Console.WriteLine($"Valore di 'nuovonumeroRef': {*ptr3}");
                    Console.WriteLine($"Indirizzo di 'nuovonumeroRef' (fixed): 0x{address2:X}");
                 }
                // Al di fuori delle graffe, il GC è libero di spostare di nuovo la variabile
            }
        }
    }
}
