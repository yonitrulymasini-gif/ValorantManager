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
    public partial class FormAjouterJoueur : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=db_schema;Uid=root;Pwd=cesi;";

        public FormAjouterJoueur()
        {
            InitializeComponent();
        }

        private void FormAjouterJoueur_Load(object sender, EventArgs e)
        {
            // Charger les postes
            cmbPoste.Items.Add("duelliste");
            cmbPoste.Items.Add("controleur");
            cmbPoste.Items.Add("initiateur");
            cmbPoste.Items.Add("sentinelle");

            // Charger les équipes depuis la BDD
            ChargerEquipes();
        }

        private void ChargerEquipes()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT nom FROM Equipes ORDER BY nom", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbEquipe.Items.Clear();
                    while (reader.Read())
                    {
                        cmbEquipe.Items.Add(reader.GetString("nom"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur chargement équipes : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || cmbPoste.SelectedItem == null || cmbEquipe.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmdEquipe = new MySqlCommand(
                        "SELECT id FROM Equipes WHERE nom = ?", conn);
                    cmdEquipe.Parameters.AddWithValue("?", cmbEquipe.SelectedItem.ToString());
                    object result = cmdEquipe.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Équipe introuvable !", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int equipeID = Convert.ToInt32(result);

                    MySqlCommand cmd = new MySqlCommand(@"
                        INSERT INTO Joueurs (nom, equipe_id, poste, vitesse, endurance, force_physique, technique) 
                        VALUES (?, ?, ?, ?, ?, ?, ?)", conn);

                    cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                    cmd.Parameters.AddWithValue("@equipeID", equipeID);
                    cmd.Parameters.AddWithValue("@poste", cmbPoste.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@vitesse", (int)nudVitesse.Value);
                    cmd.Parameters.AddWithValue("@endurance", (int)nudEndurance.Value);
                    cmd.Parameters.AddWithValue("@force", (int)nudForce.Value);
                    cmd.Parameters.AddWithValue("@technique", (int)nudTechnique.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Joueur ajouté avec succès !", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormMain formMain = new FormMain();
                    formMain.Show();
                    this.Close();
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