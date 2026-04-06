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
    public partial class FormModifierJoueur : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=valorant_manager;Uid=root;Pwd=root;";
        int joueurIDSelectionne = -1;

        public FormModifierJoueur()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormModifierJoueur_Load(object sender, EventArgs e)
        {
            // Charger les postes
            uiComboBox1.Items.Add("duelliste");
            uiComboBox1.Items.Add("controleur");
            uiComboBox1.Items.Add("initiateur");
            uiComboBox1.Items.Add("sentinelle");

            // Charger les joueurs et équipes
            ChargerJoueurs();
            ChargerEquipes();
        }

        private void ChargerJoueurs()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT id, nom FROM Joueurs ORDER BY nom", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    uiComboBox3.Items.Clear();
                    uiComboBox3.DisplayMember = "Text";
                    uiComboBox3.ValueMember = "Value";

                    var items = new List<dynamic>();
                    while (reader.Read())
                    {
                        uiComboBox3.Items.Add(new { Text = reader.GetString("nom"), Value = reader.GetInt32("id") });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur chargement joueurs : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

                    uiComboBox2.Items.Clear();
                    while (reader.Read())
                    {
                        uiComboBox2.Items.Add(reader.GetString("nom"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur chargement équipes : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbJoueurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiComboBox3.SelectedItem == null) return;

            // Récupérer l'ID du joueur sélectionné
            dynamic selected = uiComboBox3.SelectedItem;
            joueurIDSelectionne = selected.Value;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(@"
                        SELECT j.poste, j.vitesse, j.endurance, j.force_physique, j.technique, e.nom AS equipe
                        FROM Joueurs j
                        LEFT JOIN Equipes e ON j.equipe_id = e.id
                        WHERE j.id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", joueurIDSelectionne);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Remplir les champs avec les données actuelles du joueur
                        uiComboBox1.SelectedItem = reader.GetString("poste");
                        uiComboBox2.SelectedItem = reader.GetString("equipe");
                        uiIntegerUpDown1.Value = reader.GetInt32("vitesse");
                        uiIntegerUpDown2.Value = reader.GetInt32("endurance");
                        uiIntegerUpDown3.Value = reader.GetInt32("force_physique");
                        uiIntegerUpDown4.Value = reader.GetInt32("technique");
                    }
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
            FormAccueil formMain = new FormAccueil();
            formMain.Show();
            this.Close();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            {
                if (joueurIDSelectionne == -1 || uiComboBox3.SelectedItem == null || uiComboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez sélectionner un joueur !", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Récupérer l'ID de l'équipe
                        MySqlCommand cmdEquipe = new MySqlCommand(
                            "SELECT id FROM Equipes WHERE nom = @nom", conn);
                        cmdEquipe.Parameters.AddWithValue("@nom", uiComboBox2.SelectedItem.ToString());
                        int equipeID = Convert.ToInt32(cmdEquipe.ExecuteScalar());

                        // Mettre à jour le joueur
                        MySqlCommand cmd = new MySqlCommand(@"
                        UPDATE Joueurs 
                        SET poste = @poste, equipe_id = @equipeID, vitesse = @vitesse, 
                            endurance = @endurance, force_physique = @force, technique = @technique
                        WHERE id = @id", conn);

                        cmd.Parameters.AddWithValue("@poste", uiComboBox1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@equipeID", equipeID);
                        cmd.Parameters.AddWithValue("@vitesse", (int)uiIntegerUpDown1.Value);
                        cmd.Parameters.AddWithValue("@endurance", (int)uiIntegerUpDown2.Value);
                        cmd.Parameters.AddWithValue("@force", (int)uiIntegerUpDown3.Value);
                        cmd.Parameters.AddWithValue("@technique", (int)uiIntegerUpDown4.Value);
                        cmd.Parameters.AddWithValue("@id", joueurIDSelectionne);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Joueur modifié avec succès !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FormAccueil formMain = new FormAccueil();
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
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            FormAccueil formMain = new FormAccueil();
            formMain.Show();
            this.Close();
        }

        private void cmbEquipe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}