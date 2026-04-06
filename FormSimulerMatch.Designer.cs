namespace RugbyManager
{
    partial class FormSimulerMatch
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            txtAdversaire = new TextBox();
            uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            uiButton1 = new Sunny.UI.UIButton();
            uiButton6 = new Sunny.UI.UIButton();
            uiLedLabel1 = new Sunny.UI.UILedLabel();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtAdversaire
            // 
            txtAdversaire.Location = new Point(789, 808);
            txtAdversaire.Margin = new Padding(3, 4, 3, 4);
            txtAdversaire.Name = "txtAdversaire";
            txtAdversaire.Size = new Size(293, 27);
            txtAdversaire.TabIndex = 3;
            txtAdversaire.TextChanged += txtAdversaire_TextChanged;
            // 
            // uiSmoothLabel1
            // 
            uiSmoothLabel1.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiSmoothLabel1.Location = new Point(728, 9);
            uiSmoothLabel1.Name = "uiSmoothLabel1";
            uiSmoothLabel1.RectSize = 15;
            uiSmoothLabel1.Size = new Size(453, 125);
            uiSmoothLabel1.TabIndex = 24;
            uiSmoothLabel1.Text = "MATCH";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDataGridView1.BackgroundColor = Color.White;
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("Microsoft Sans Serif", 12F);
            uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.Location = new Point(422, 157);
            uiDataGridView1.Name = "uiDataGridView1";
            uiDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.Size = new Size(1053, 595);
            uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.TabIndex = 25;
            // 
            // uiButton1
            // 
            uiButton1.BackColor = SystemColors.ControlLight;
            uiButton1.FillColor = Color.White;
            uiButton1.FillColor2 = Color.White;
            uiButton1.FillHoverColor = Color.DodgerBlue;
            uiButton1.FillPressColor = Color.White;
            uiButton1.FillSelectedColor = Color.White;
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiButton1.ForeColor = Color.Black;
            uiButton1.Location = new Point(789, 877);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.RectColor = Color.White;
            uiButton1.RectHoverColor = Color.FromArgb(224, 224, 224);
            uiButton1.RectPressColor = Color.White;
            uiButton1.RectSelectedColor = Color.White;
            uiButton1.Size = new Size(293, 64);
            uiButton1.TabIndex = 27;
            uiButton1.Text = "SIMULER";
            uiButton1.TipsColor = Color.White;
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiButton1.Click += uiButton1_Click;
            // 
            // uiButton6
            // 
            uiButton6.BackColor = SystemColors.ControlLight;
            uiButton6.FillColor = Color.White;
            uiButton6.FillColor2 = Color.White;
            uiButton6.FillHoverColor = Color.DodgerBlue;
            uiButton6.FillPressColor = Color.White;
            uiButton6.FillSelectedColor = Color.White;
            uiButton6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiButton6.ForeColor = Color.Black;
            uiButton6.Location = new Point(789, 961);
            uiButton6.MinimumSize = new Size(1, 1);
            uiButton6.Name = "uiButton6";
            uiButton6.RectColor = Color.White;
            uiButton6.RectHoverColor = Color.FromArgb(224, 224, 224);
            uiButton6.RectPressColor = Color.White;
            uiButton6.RectSelectedColor = Color.White;
            uiButton6.Size = new Size(293, 64);
            uiButton6.TabIndex = 26;
            uiButton6.Text = "RETOUR";
            uiButton6.TipsColor = Color.White;
            uiButton6.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiButton6.Click += uiButton6_Click;
            // 
            // uiLedLabel1
            // 
            uiLedLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLedLabel1.Location = new Point(545, 798);
            uiLedLabel1.MinimumSize = new Size(1, 1);
            uiLedLabel1.Name = "uiLedLabel1";
            uiLedLabel1.Size = new Size(238, 44);
            uiLedLabel1.TabIndex = 31;
            uiLedLabel1.Text = "ADVERSAIRE :";
            // 
            // FormSimulerMatch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1033);
            Controls.Add(uiLedLabel1);
            Controls.Add(uiButton1);
            Controls.Add(uiButton6);
            Controls.Add(uiDataGridView1);
            Controls.Add(uiSmoothLabel1);
            Controls.Add(txtAdversaire);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSimulerMatch";
            Text = "SimulerMatch";
            Load += SimulerMatch_Load;
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAdversaire;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton6;
        private Sunny.UI.UILedLabel uiLedLabel1;
    }
}