namespace SondaSpaziale
{
    public partial class Form1 : Form
    {
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


    }
}