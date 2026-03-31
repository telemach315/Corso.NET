using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EsempioForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            // 1. Verifico l'esistenza del file
            string path = Path.Combine(Application.StartupPath, "TextDB.txt");
            if (!File.Exists(path))
            {
                lblRisultato.Text = "Database testuale non trovato.";
                return;
            }

            string cognomeDaCercare = textCognome.Text.Trim();
            string[] righe = File.ReadAllLines(path);
            foreach (string riga in righe)
            {
                // Splitto la riga in parti basandomi sul carattere di separazione ";"
                string[] campi = riga.Split(';');

                // campi[0] = cognome
                // campi[1] = nome
                // campi[2] = telefono
                if (campi.Length >= 1 &&
                    campi[0].Equals(cognomeDaCercare, StringComparison.OrdinalIgnoreCase))
                {

                    // Mostro tutta la riga trovata
                    lblRisultato.Text = $"Telefono: {campi[2]}";
                    return;
                }
            }
            lblRisultato.Text = "Cognome NON trovato";

        }

        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "TextDB.txt");

            // Leggo i valori inseriti dall'utente
            string cognome = txtBoxCognome.Text.Trim();
            string nome = txtBoxNome.Text.Trim();
            string telefono = txtBoxNumero.Text.Trim();

            // Controllo che i campi non siano vuoti
            if (string.IsNullOrWhiteSpace(cognome) ||
                string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(telefono))
            {
                lblRisultato.Text = "Compila tutti i campi!";
                lblRisultato.ForeColor = Color.Red;
                return;
            }

            // Creo la riga da aggiungere
            string nuovaRiga = $"{cognome};{nome};{telefono};";

            // Aggiungo la riga al file
            File.AppendAllText(path, nuovaRiga + Environment.NewLine);

            // Messaggio di conferma
            lblRisultato.Text = "Contatto inserito correttamente!";
            lblRisultato.ForeColor = Color.Green;

            // Pulisco i campi
            txtBoxCognome.Clear();
            txtBoxNome.Clear();
            txtBoxNumero.Clear();
        }
    }
}
