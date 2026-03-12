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
    public partial class FormJoueurs : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=db_schema;Uid=root;Pwd=cesi;";

        public FormJoueurs()
        {
            InitializeComponent();
        }

        private void FormJoueurs_Load(object sender, EventArgs e)
        {
            AfficherJoueurs();
        }

        private void AfficherJoueurs()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT j.id, j.nom, e.nom AS equipe, j.poste, j.vitesse, j.endurance, 
                               j.force_physique, j.technique, j.blesse, j.matchs_indisponibles 
                        FROM Joueurs j 
                        LEFT JOIN Equipes e ON j.equipe_id = e.id 
                        ORDER BY j.nom";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Nom");
                    dt.Columns.Add("Équipe");
                    dt.Columns.Add("Poste");
                    dt.Columns.Add("Vitesse");
                    dt.Columns.Add("Endurance");
                    dt.Columns.Add("Force");
                    dt.Columns.Add("Technique");
                    dt.Columns.Add("Statut");

                    while (reader.Read())
                    {
                        bool blesse = reader.GetBoolean("blesse");
                        int matchsIndispo = reader.GetInt32("matchs_indisponibles");

                        string statut = blesse
                            ? $"Indisponible ({matchsIndispo} matchs)"
                            : "Disponible";

                        dt.Rows.Add(
                            reader.GetInt32("id"),
                            reader.GetString("nom"),
                            reader.IsDBNull(2) ? "Sans équipe" : reader.GetString(2),
                            reader.GetString("poste"),
                            reader.GetInt32("vitesse"),
                            reader.GetInt32("endurance"),
                            reader.GetInt32("force_physique"),
                            reader.GetInt32("technique"),
                            statut
                        );
                    }

                    dgvJoueurs.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Close();
        }
    }
}

