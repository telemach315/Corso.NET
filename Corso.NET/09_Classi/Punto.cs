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
    }
}
