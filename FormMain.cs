using System.Data;

namespace RugbyManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAfficherJoueurs_Click(object sender, EventArgs e)
        {
            FormJoueurs formJoueurs = new FormJoueurs();
            formJoueurs.Show();
            this.Hide();

        }

        private void btnAjouterJoueur_Click(object sender, EventArgs e)
        {
            FormAjouterJoueur formAjouter = new FormAjouterJoueur();
            formAjouter.Show();
            this.Hide();
        }

        private void btnMiseAJourBlessures_Click(object sender, EventArgs e)
        {

        }
    }
}
