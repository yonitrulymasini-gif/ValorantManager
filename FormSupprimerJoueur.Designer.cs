namespace RugbyManager
{
    partial class FormSupprimerJoueur
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            uiButton1 = new Sunny.UI.UIButton();
            uiButton6 = new Sunny.UI.UIButton();
            uiDataGridView2 = new Sunny.UI.UIDataGridView();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // uiSmoothLabel1
            // 
            uiSmoothLabel1.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiSmoothLabel1.Location = new Point(613, 9);
            uiSmoothLabel1.Name = "uiSmoothLabel1";
            uiSmoothLabel1.RectSize = 15;
            uiSmoothLabel1.Size = new Size(780, 125);
            uiSmoothLabel1.TabIndex = 25;
            uiSmoothLabel1.Text = "SUPPRIMER";
            uiSmoothLabel1.Click += uiSmoothLabel1_Click;
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
            uiButton1.Location = new Point(840, 794);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.RectColor = Color.White;
            uiButton1.RectHoverColor = Color.FromArgb(224, 224, 224);
            uiButton1.RectPressColor = Color.White;
            uiButton1.RectSelectedColor = Color.White;
            uiButton1.Size = new Size(293, 64);
            uiButton1.TabIndex = 29;
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
            uiButton6.Location = new Point(840, 878);
            uiButton6.MinimumSize = new Size(1, 1);
            uiButton6.Name = "uiButton6";
            uiButton6.RectColor = Color.White;
            uiButton6.RectHoverColor = Color.FromArgb(224, 224, 224);
            uiButton6.RectPressColor = Color.White;
            uiButton6.RectSelectedColor = Color.White;
            uiButton6.Size = new Size(293, 64);
            uiButton6.TabIndex = 28;
            uiButton6.Text = "RETOUR";
            uiButton6.TipsColor = Color.White;
            uiButton6.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiButton6.Click += uiButton6_Click;
            // 
            // uiDataGridView2
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDataGridView2.BackgroundColor = Color.White;
            uiDataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView2.EnableHeadersVisualStyles = false;
            uiDataGridView2.Font = new Font("Microsoft Sans Serif", 12F);
            uiDataGridView2.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView2.Location = new Point(772, 22);
            uiDataGridView2.Name = "uiDataGridView2";
            uiDataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            uiDataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            uiDataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDataGridView2.SelectedIndex = -1;
            uiDataGridView2.Size = new Size(10, 8);
            uiDataGridView2.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView2.TabIndex = 31;
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            uiDataGridView1.BackgroundColor = Color.White;
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("Microsoft Sans Serif", 12F);
            uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.Location = new Point(468, 156);
            uiDataGridView1.Name = "uiDataGridView1";
            uiDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12F);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.Size = new Size(1053, 595);
            uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.TabIndex = 32;
            // 
            // FormSupprimerJoueur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(uiDataGridView1);
            Controls.Add(uiDataGridView2);
            Controls.Add(uiButton1);
            Controls.Add(uiButton6);
            Controls.Add(uiSmoothLabel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSupprimerJoueur";
            Text = "Supprimer un joueur";
            Load += FormSupprimerJoueur_Load;
            ((System.ComponentModel.ISupportInitialize)uiDataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ResumeLayout(false);
        }

        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton6;
        private Sunny.UI.UIDataGridView uiDataGridView2;
        private Sunny.UI.UIDataGridView uiDataGridView1;
    }
}