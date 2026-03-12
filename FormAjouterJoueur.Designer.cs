namespace RugbyManager
{
    partial class FormAjouterJoueur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblNom = new Label();
            lblPoste = new Label();
            imageList1 = new ImageList(components);
            lblEquipe = new Label();
            lblVitesse = new Label();
            lblEndurance = new Label();
            lblForce = new Label();
            lblTechnique = new Label();
            lblAjouterJoueur = new Label();
            txtNom = new TextBox();
            btnValider = new Button();
            btnRetour = new Button();
            cmbEquipe = new ComboBox();
            nudVitesse = new NumericUpDown();
            nudEndurance = new NumericUpDown();
            nudForce = new NumericUpDown();
            nudTechnique = new NumericUpDown();
            cmbPoste = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudVitesse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEndurance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudForce).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTechnique).BeginInit();
            SuspendLayout();
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNom.Location = new Point(78, 120);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(49, 21);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom ";
            // 
            // lblPoste
            // 
            lblPoste.AutoSize = true;
            lblPoste.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPoste.Location = new Point(76, 165);
            lblPoste.Name = "lblPoste";
            lblPoste.Size = new Size(47, 21);
            lblPoste.TabIndex = 1;
            lblPoste.Text = "Poste";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // lblEquipe
            // 
            lblEquipe.AutoSize = true;
            lblEquipe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEquipe.Location = new Point(76, 208);
            lblEquipe.Name = "lblEquipe";
            lblEquipe.Size = new Size(57, 21);
            lblEquipe.TabIndex = 2;
            lblEquipe.Text = "Équipe";
            // 
            // lblVitesse
            // 
            lblVitesse.AutoSize = true;
            lblVitesse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVitesse.Location = new Point(74, 254);
            lblVitesse.Name = "lblVitesse";
            lblVitesse.Size = new Size(59, 21);
            lblVitesse.TabIndex = 3;
            lblVitesse.Text = "Vitesse";
            // 
            // lblEndurance
            // 
            lblEndurance.AutoSize = true;
            lblEndurance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndurance.Location = new Point(72, 301);
            lblEndurance.Name = "lblEndurance";
            lblEndurance.Size = new Size(83, 21);
            lblEndurance.TabIndex = 4;
            lblEndurance.Text = "Endurance";
            // 
            // lblForce
            // 
            lblForce.AutoSize = true;
            lblForce.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForce.Location = new Point(72, 345);
            lblForce.Name = "lblForce";
            lblForce.Size = new Size(48, 21);
            lblForce.TabIndex = 5;
            lblForce.Text = "Force";
            // 
            // lblTechnique
            // 
            lblTechnique.AutoSize = true;
            lblTechnique.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTechnique.Location = new Point(72, 386);
            lblTechnique.Name = "lblTechnique";
            lblTechnique.Size = new Size(79, 21);
            lblTechnique.TabIndex = 6;
            lblTechnique.Text = "Technique";
            // 
            // lblAjouterJoueur
            // 
            lblAjouterJoueur.AutoSize = true;
            lblAjouterJoueur.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAjouterJoueur.Location = new Point(357, 148);
            lblAjouterJoueur.Name = "lblAjouterJoueur";
            lblAjouterJoueur.Size = new Size(394, 60);
            lblAjouterJoueur.TabIndex = 7;
            lblAjouterJoueur.Text = "AJOUTER UN JOUEUR";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(204, 112);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(100, 23);
            txtNom.TabIndex = 8;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(408, 301);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(119, 31);
            btnValider.TabIndex = 15;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(567, 301);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(119, 31);
            btnRetour.TabIndex = 16;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // cmbEquipe
            // 
            cmbEquipe.FormattingEnabled = true;
            cmbEquipe.Location = new Point(204, 210);
            cmbEquipe.Name = "cmbEquipe";
            cmbEquipe.Size = new Size(100, 23);
            cmbEquipe.TabIndex = 17;
            // 
            // nudVitesse
            // 
            nudVitesse.Location = new Point(204, 257);
            nudVitesse.Name = "nudVitesse";
            nudVitesse.Size = new Size(100, 23);
            nudVitesse.TabIndex = 18;
            // 
            // nudEndurance
            // 
            nudEndurance.Location = new Point(204, 301);
            nudEndurance.Name = "nudEndurance";
            nudEndurance.Size = new Size(100, 23);
            nudEndurance.TabIndex = 19;
            // 
            // nudForce
            // 
            nudForce.Location = new Point(204, 343);
            nudForce.Name = "nudForce";
            nudForce.Size = new Size(100, 23);
            nudForce.TabIndex = 20;
            // 
            // nudTechnique
            // 
            nudTechnique.Location = new Point(204, 386);
            nudTechnique.Name = "nudTechnique";
            nudTechnique.Size = new Size(100, 23);
            nudTechnique.TabIndex = 21;
            // 
            // cmbPoste
            // 
            cmbPoste.FormattingEnabled = true;
            cmbPoste.Location = new Point(204, 163);
            cmbPoste.Name = "cmbPoste";
            cmbPoste.Size = new Size(100, 23);
            cmbPoste.TabIndex = 22;
            // 
            // FormAjouterJoueur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 450);
            Controls.Add(cmbPoste);
            Controls.Add(nudTechnique);
            Controls.Add(nudForce);
            Controls.Add(nudEndurance);
            Controls.Add(nudVitesse);
            Controls.Add(cmbEquipe);
            Controls.Add(btnRetour);
            Controls.Add(btnValider);
            Controls.Add(txtNom);
            Controls.Add(lblAjouterJoueur);
            Controls.Add(lblTechnique);
            Controls.Add(lblForce);
            Controls.Add(lblEndurance);
            Controls.Add(lblVitesse);
            Controls.Add(lblEquipe);
            Controls.Add(lblPoste);
            Controls.Add(lblNom);
            Name = "FormAjouterJoueur";
            Text = "FormAjouterJoueur";
            Load += FormAjouterJoueur_Load;
            ((System.ComponentModel.ISupportInitialize)nudVitesse).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEndurance).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudForce).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTechnique).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNom;
        private Label lblPoste;
        private ImageList imageList1;
        private Label lblEquipe;
        private Label lblVitesse;
        private Label lblEndurance;
        private Label lblForce;
        private Label lblTechnique;
        private Label lblAjouterJoueur;
        private TextBox txtNom;
        private Button btnValider;
        private Button btnRetour;
        private ComboBox cmbEquipe;
        private NumericUpDown nudVitesse;
        private NumericUpDown nudEndurance;
        private NumericUpDown nudForce;
        private NumericUpDown nudTechnique;
        private ComboBox cmbPoste;
    }
}