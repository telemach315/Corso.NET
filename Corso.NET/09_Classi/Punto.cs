namespace Corso.NET._09_Classi
{
    public class Punto
    {
        public Half x;
        public Half y;

        public void StampaCoordinate()
        {
            Console.WriteLine($"Coordinate x:{(Half)x} y:{(Half)y}");
        }

        public double CalcolaDistanza(Punto altroPunto)
        {
            double deltaX = (double)(altroPunto.x - this.x);
            double deltaY = (double)(altroPunto.y - this.y);
            double distanza = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            //Console.WriteLine($"La distanza tra i due punti è: {distanza}");
            return distanza;
        }
    }
}
