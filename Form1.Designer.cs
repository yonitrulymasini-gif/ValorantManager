namespace RugbyManager
{
    partial class FormJoueurs
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
            dgvJoueurs = new DataGridView();
            btnRetour = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJoueurs).BeginInit();
            SuspendLayout();
            // 
            // dgvJoueurs
            // 
            dgvJoueurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJoueurs.Location = new Point(91, 74);
            dgvJoueurs.Name = "dgvJoueurs";
            dgvJoueurs.Size = new Size(948, 540);
            dgvJoueurs.TabIndex = 0;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(917, 12);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(122, 39);
            btnRetour.TabIndex = 1;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // FormJoueurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 708);
            Controls.Add(btnRetour);
            Controls.Add(dgvJoueurs);
            Name = "FormJoueurs";
            Text = "Form1";
            Load += FormJoueurs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJoueurs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvJoueurs;
        private Button btnRetour;
    }
}