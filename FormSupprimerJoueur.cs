using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RugbyManager
{
    public partial class FormSupprimerJoueur : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=valorant_manager;Uid=root;Pwd=root;";

        public FormSupprimerJoueur()
        {
            InitializeComponent();
            this.Load += FormSupprimerJoueur_Load;
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormSupprimerJoueur_Load(object sender, EventArgs e)
        {
            uiDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            uiDataGridView1.MultiSelect = false;
            uiDataGridView1.ReadOnly = true;
            uiDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            AfficherJoueurs();
        }

        private void AfficherJoueurs()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(@"
                        SELECT j.id, j.nom, e.nom AS equipe, j.poste
                        FROM Joueurs j
                        LEFT JOIN Equipes e ON j.equipe_id = e.id
                        ORDER BY j.nom", conn);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Nom");
                    dt.Columns.Add("Equipe");
                    dt.Columns.Add("Poste");

                    while (reader.Read())
                    {
                        dt.Rows.Add(
                            reader.GetInt32("id"),
                            reader.GetString("nom"),
                            reader.IsDBNull(2) ? "Sans équipe" : reader.GetString(2),
                            reader.GetString("poste")
                        );
                    }

                    uiDataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un joueur à supprimer !", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(uiDataGridView1.SelectedRows[0].Cells["ID"].Value);
            string nom = uiDataGridView1.SelectedRows[0].Cells["Nom"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Voulez-vous vraiment supprimer le joueur '{nom}' ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(
                            "DELETE FROM Joueurs WHERE id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Joueur supprimé !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AfficherJoueurs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormAccueil formMain = new FormAccueil();
            formMain.Show();
            this.Close();
        }

        private void uiSmoothLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            FormAccueil formMain = new FormAccueil();
            formMain.Show();
            this.Close();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un joueur à supprimer !", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(uiDataGridView1.SelectedRows[0].Cells["ID"].Value);
            string nom = uiDataGridView1.SelectedRows[0].Cells["Nom"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Voulez-vous vraiment supprimer le joueur '{nom}' ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(
                            "DELETE FROM Joueurs WHERE id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Joueur supprimé !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AfficherJoueurs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}