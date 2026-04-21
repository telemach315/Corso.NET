namespace Corso.NET._09_Classi
{
    public class CalcolatoreFisica
    {
        public double CalcolaVelocita(Punto pInizio, Punto pFine, double tempoSecondi)
        {
            if (tempoSecondi <= 0)
            {
                Console.WriteLine("Errore: Il tempo deve essere maggiore di zero.");
                return 0;
            }
            double distanza = pInizio.CalcolaDistanza(pFine);
            double velocita = distanza / tempoSecondi;
            return velocita;
        }

        public double CalcolaVelocita(double distanza, double tempoSecondi)
        {
            if (tempoSecondi <= 0)
            {
                Console.WriteLine("Errore: Il tempo deve essere maggiore di zero.");
                return 0;
            }
            double velocita = distanza / tempoSecondi;
            return velocita;
        }
    }
}