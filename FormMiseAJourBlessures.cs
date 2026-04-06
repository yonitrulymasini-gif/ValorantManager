using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RugbyManager
{
    public partial class FormMiseAJourBlessures : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=valorant_manager;Uid=root;Pwd=root;";

        public FormMiseAJourBlessures()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormMiseAJourBlessures_Load(object sender, EventArgs e)
        {
            AfficherJoueursBlesses();
        }

        private void AfficherJoueursBlesses()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(@"
                        SELECT j.id, j.nom, e.nom AS equipe, j.poste, j.matchs_indisponibles
                        FROM Joueurs j
                        LEFT JOIN Equipes e ON j.equipe_id = e.id
                        WHERE j.blesse = TRUE
                        ORDER BY j.nom", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Nom");
                    dt.Columns.Add("Equipe");
                    dt.Columns.Add("Poste");
                    dt.Columns.Add("Matchs restants");

                    while (reader.Read())
                    {
                        dt.Rows.Add(
                            reader.GetInt32("id"),
                            reader.GetString("nom"),
                            reader.IsDBNull(2) ? "Sans équipe" : reader.GetString(2),
                            reader.GetString("poste"),
                            reader.GetInt32("matchs_indisponibles")
                        );
                    }

                    uiDataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Aucun joueur blessé !", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void uiButton6_Click(object sender, EventArgs e)
        {
            FormAccueil formMain = new FormAccueil();
            formMain.Show();
            this.Close();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Décrémenter les matchs d'indisponibilité
                    MySqlCommand cmdDecrement = new MySqlCommand(@"
                        UPDATE Joueurs 
                        SET matchs_indisponibles = matchs_indisponibles - 1 
                        WHERE blesse = TRUE", conn);
                    cmdDecrement.ExecuteNonQuery();

                    // Remettre disponibles les joueurs à 0 match restant
                    MySqlCommand cmdRetablir = new MySqlCommand(@"
                        UPDATE Joueurs 
                        SET blesse = FALSE, matchs_indisponibles = 0 
                        WHERE matchs_indisponibles <= 0 AND blesse = TRUE", conn);
                    int retablis = cmdRetablir.ExecuteNonQuery();

                    MessageBox.Show($"Mise à jour effectuée !\n{retablis} joueur(s) rétabli(s) !",
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AfficherJoueursBlesses();
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