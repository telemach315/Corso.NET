namespace SondaSpaziale
{
   public partial class Form1 : Form
    {
        // Interi con segno
        sbyte variazioneTemperatura = -5;          // 8-bit
        short livelloRadiazioni = 450;             // 16-bit
        int identificativoSonda = 102456;          // 32-bit
        long distanzaDallaTerraKm = 384400000L;    // 64-bit

        // Interi senza segno
        byte protocolloVersione = 2;               // 8-bit
        ushort porteAttive = 65000;                // 16-bit
        uint conteggioFotoni = 4000000000U;        // 32-bit
        ulong cicliCpuEseguiti = 18446744073709551610UL; // 64-bit

        // Virgola mobile e alta precisione
        float pressioneInterna = 1.013f;           // 7 cifre precisione
        double densitaAtmosferica = 0.00000045123d;// 15-17 cifre precisione
        decimal valoreMissioneEuro = 15000000.75m; // 28-29 cifre (finanziario)

        // Logici e testuali
        bool sistemaOperativoAttivo = true;
        char classeSonda = 'A';

        private double distanzaKm = 54600000.0;
        private const double VelocitaKmPerSecondo = 16.9995;

        // Calcoliamo lo spostamento ogni 10ms
        // Se in 1000ms fa 16.9995 km, in 10ms fa (16.9995 / 100)
        private const double IncrementoPerTick = VelocitaKmPerSecondo / 100.0;

        public Form1()
        {
            InitializeComponent();
            ConfiguraGrafica();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 10;
            timer1.Start();
        }

        private void ConfiguraGrafica()
        {
            this.Text = "Controllo Missione Tianwen-2";
            this.BackColor = Color.FromArgb(20, 20, 20);
            this.ForeColor = Color.LimeGreen;
            this.Font = new Font("Consolas", 12, FontStyle.Bold);

            lblNome.Text = "Tianwen-2";
            lblStato.Text = "STATO: ATTIVO";
            lblStato.ForeColor = Color.Lime;

            lblVelocita.Text = $"{VelocitaKmPerSecondo} km/s";

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            distanzaKm += IncrementoPerTick;

            // Visualizza la distanza con 6 decimali
            // "N6" formatta il numero con separatore di migliaia e 6 decimali
            lblDistanza.Text = $"{distanzaKm.ToString("N6")} km";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}