using Corso.NET._09_Classi;
namespace Corso.NET
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            // Lezione 2
            // _02_ConsumoMemoria.Benchmarks.EseguiBenchmark();

            // Lezione 4
            // _04_CastAndPromotions.CastAndPromotions.EseguiCastAndPromotions();

            // Lezione 5
            // _05_Puntatori.ValoriEIndirizzi.StampaVariabili();

            // Lezione 6
            //_06_TipoChar.EsempioChar.EseguiEsempioChar();

            // Lezione 9
            //Punto p = new Punto();
            //p.x = (Half)16.23;
            //p.y = (Half)23.11;
            //p.StampaCoordinate();

            // Lezione 10
            Punto p1 = new Punto();
            p1.x = (Half)16.23;
            p1.y = (Half)23.11;
            
            Punto p2 = new Punto();
            p2.x = (Half)18.44;
            p2.y = (Half)27.56;
            
            double distanza = p1.CalcolaDistanza(p2);
            Console.WriteLine($"La distanza tra i due punti è: {distanza}");

            double tempo = 10.5; // secondi
            CalcolatoreFisica calcolatore = new CalcolatoreFisica();
            double velocitaRisultante = calcolatore.CalcolaVelocita(p1, p2, tempo);
            Console.WriteLine($"Distanza percorsa: {p1.CalcolaDistanza(p2)} metri");
            Console.WriteLine($"Tempo impiegato: {tempo} secondi");
            Console.WriteLine($"Velocità calcolata: {velocitaRisultante} m/s");
        }
    }
}