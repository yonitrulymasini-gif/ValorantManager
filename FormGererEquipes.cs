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
    public partial class FormGererEquipes : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=valorant_manager;Uid=root;Pwd=root;";

        public FormGererEquipes()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormGererEquipes_Load(object sender, EventArgs e)
        {
            AfficherEquipes();
        }

        private void AfficherEquipes()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT id, nom FROM Equipes ORDER BY nom", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Nom");

                    while (reader.Read())
                    {
                        dt.Rows.Add(
                            reader.GetInt32("id"),
                            reader.GetString("nom")
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
                MessageBox.Show("Veuillez sélectionner une équipe !", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(uiDataGridView1.SelectedRows[0].Cells["ID"].Value);
            string nom = uiDataGridView1.SelectedRows[0].Cells["Nom"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Voulez-vous vraiment supprimer l'équipe '{nom}' ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(
                            "DELETE FROM Equipes WHERE id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Équipe supprimée !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AfficherEquipes(); // actualise la liste
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (txtNomEquipe.Text == "")
            {
                MessageBox.Show("Veuillez saisir un nom d'équipe !", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        "INSERT INTO Equipes (nom) VALUES (@nom)", conn);
                    cmd.Parameters.AddWithValue("@nom", txtNomEquipe.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Équipe ajoutée !", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNomEquipe.Text = "";
                    AfficherEquipes(); // actualise la liste
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