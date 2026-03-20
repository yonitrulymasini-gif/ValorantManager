namespace RugbyManager
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAfficherJoueurs = new Button();
            btnAjouterJoueur = new Button();
            btnModifierJoueur = new Button();
            btnSupprimerJoueur = new Button();
            btnGererEquipes = new Button();
            lblTitre = new Label();
            btnMiseAJourBlessures = new Button();
            btnSimulerMatch = new Button();
            btnQuitter = new Button();
            SuspendLayout();
            // 
            // btnAfficherJoueurs
            // 
            btnAfficherJoueurs.FlatStyle = FlatStyle.Flat;
            btnAfficherJoueurs.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAfficherJoueurs.Location = new Point(105, 179);
            btnAfficherJoueurs.Name = "btnAfficherJoueurs";
            btnAfficherJoueurs.Size = new Size(207, 66);
            btnAfficherJoueurs.TabIndex = 0;
            btnAfficherJoueurs.Text = "Afficher tous les joueurs";
            btnAfficherJoueurs.UseVisualStyleBackColor = true;
            btnAfficherJoueurs.Click += btnAfficherJoueurs_Click;
            // 
            // btnAjouterJoueur
            // 
            btnAjouterJoueur.FlatStyle = FlatStyle.Flat;
            btnAjouterJoueur.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjouterJoueur.Location = new Point(467, 179);
            btnAjouterJoueur.Name = "btnAjouterJoueur";
            btnAjouterJoueur.Size = new Size(196, 66);
            btnAjouterJoueur.TabIndex = 1;
            btnAjouterJoueur.Text = "Ajouter un joueur";
            btnAjouterJoueur.UseVisualStyleBackColor = true;
            btnAjouterJoueur.Click += btnAjouterJoueur_Click;
            // 
            // btnModifierJoueur
            // 
            btnModifierJoueur.FlatStyle = FlatStyle.Flat;
            btnModifierJoueur.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModifierJoueur.Location = new Point(848, 179);
            btnModifierJoueur.Name = "btnModifierJoueur";
            btnModifierJoueur.Size = new Size(194, 66);
            btnModifierJoueur.TabIndex = 2;
            btnModifierJoueur.Text = "Modifier un joueur";
            btnModifierJoueur.UseVisualStyleBackColor = true;
            btnModifierJoueur.Click += btnModifierJoueur_Click;
            // 
            // btnSupprimerJoueur
            // 
            btnSupprimerJoueur.FlatStyle = FlatStyle.Flat;
            btnSupprimerJoueur.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSupprimerJoueur.Location = new Point(105, 441);
            btnSupprimerJoueur.Name = "btnSupprimerJoueur";
            btnSupprimerJoueur.Size = new Size(207, 68);
            btnSupprimerJoueur.TabIndex = 3;
            btnSupprimerJoueur.Text = "Supprimer un joueur";
            btnSupprimerJoueur.UseVisualStyleBackColor = true;
            btnSupprimerJoueur.Click += btnSupprimerJoueur_Click;
            // 
            // btnGererEquipes
            // 
            btnGererEquipes.FlatStyle = FlatStyle.Flat;
            btnGererEquipes.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGererEquipes.Location = new Point(467, 361);
            btnGererEquipes.Name = "btnGererEquipes";
            btnGererEquipes.Size = new Size(196, 59);
            btnGererEquipes.TabIndex = 4;
            btnGererEquipes.Text = "Gérer équipes";
            btnGererEquipes.UseVisualStyleBackColor = true;
            btnGererEquipes.Click += btnGererEquipes_Click;
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(349, 26);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(495, 80);
            lblTitre.TabIndex = 5;
            lblTitre.Text = "RUGBY MANAGER";
            lblTitre.Click += label1_Click;
            // 
            // btnMiseAJourBlessures
            // 
            btnMiseAJourBlessures.FlatStyle = FlatStyle.Flat;
            btnMiseAJourBlessures.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMiseAJourBlessures.Location = new Point(467, 526);
            btnMiseAJourBlessures.Name = "btnMiseAJourBlessures";
            btnMiseAJourBlessures.Size = new Size(196, 58);
            btnMiseAJourBlessures.TabIndex = 6;
            btnMiseAJourBlessures.Text = "Mise à jour blessures";
            btnMiseAJourBlessures.UseVisualStyleBackColor = true;
            btnMiseAJourBlessures.Click += btnMiseAJourBlessures_Click;
            // 
            // btnSimulerMatch
            // 
            btnSimulerMatch.FlatStyle = FlatStyle.Flat;
            btnSimulerMatch.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSimulerMatch.Location = new Point(856, 441);
            btnSimulerMatch.Name = "btnSimulerMatch";
            btnSimulerMatch.Size = new Size(194, 68);
            btnSimulerMatch.TabIndex = 7;
            btnSimulerMatch.Text = "Simuler match COMPLET";
            btnSimulerMatch.UseVisualStyleBackColor = true;
            btnSimulerMatch.Click += btnSimulerMatch_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.FlatStyle = FlatStyle.Flat;
            btnQuitter.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuitter.ForeColor = SystemColors.ControlText;
            btnQuitter.Location = new Point(467, 682);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(196, 59);
            btnQuitter.TabIndex = 8;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = false;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 854);
            Controls.Add(btnQuitter);
            Controls.Add(btnSimulerMatch);
            Controls.Add(btnMiseAJourBlessures);
            Controls.Add(lblTitre);
            Controls.Add(btnGererEquipes);
            Controls.Add(btnSupprimerJoueur);
            Controls.Add(btnModifierJoueur);
            Controls.Add(btnAjouterJoueur);
            Controls.Add(btnAfficherJoueurs);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAfficherJoueurs;
        private Button btnAjouterJoueur;
        private Button btnModifierJoueur;
        private Button btnSupprimerJoueur;
        private Button btnGererEquipes;
        private Label lblTitre;
        private Button btnMiseAJourBlessures;
        private Button btnSimulerMatch;
        private Button btnQuitter;
    }
}
