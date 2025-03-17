namespace fitness_center
{
    partial class frmÜyeleriGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmÜyeleriGoruntule));
            label9 = new Label();
            label1 = new Label();
            label3 = new Label();
            dgvUyeListele = new Guna.UI2.WinForms.Guna2DataGridView();
            txtUyeAra = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvUyeListele).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkOrange;
            label9.Location = new Point(489, 50);
            label9.Name = "label9";
            label9.Size = new Size(205, 41);
            label9.TabIndex = 3;
            label9.Text = "Üyeleri Listele";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(462, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 41);
            label1.TabIndex = 4;
            label1.Text = "FITNESS CENTER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(1101, 9);
            label3.Name = "label3";
            label3.Size = new Size(38, 41);
            label3.TabIndex = 5;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // dgvUyeListele
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvUyeListele.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUyeListele.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUyeListele.ColumnHeadersHeight = 30;
            dgvUyeListele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUyeListele.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUyeListele.GridColor = Color.Black;
            dgvUyeListele.Location = new Point(33, 167);
            dgvUyeListele.Name = "dgvUyeListele";
            dgvUyeListele.RowHeadersVisible = false;
            dgvUyeListele.RowHeadersWidth = 51;
            dgvUyeListele.RowTemplate.Height = 25;
            dgvUyeListele.Size = new Size(1083, 450);
            dgvUyeListele.TabIndex = 29;
            dgvUyeListele.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvUyeListele.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvUyeListele.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvUyeListele.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvUyeListele.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvUyeListele.ThemeStyle.BackColor = Color.White;
            dgvUyeListele.ThemeStyle.GridColor = Color.Black;
            dgvUyeListele.ThemeStyle.HeaderStyle.BackColor = Color.DarkOrange;
            dgvUyeListele.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUyeListele.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvUyeListele.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvUyeListele.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvUyeListele.ThemeStyle.HeaderStyle.Height = 30;
            dgvUyeListele.ThemeStyle.ReadOnly = false;
            dgvUyeListele.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvUyeListele.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUyeListele.ThemeStyle.RowsStyle.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvUyeListele.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvUyeListele.ThemeStyle.RowsStyle.Height = 25;
            dgvUyeListele.ThemeStyle.RowsStyle.SelectionBackColor = Color.DarkOrange;
            dgvUyeListele.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // txtUyeAra
            // 
            txtUyeAra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUyeAra.ForeColor = Color.DarkOrange;
            txtUyeAra.Location = new Point(306, 127);
            txtUyeAra.Name = "txtUyeAra";
            txtUyeAra.Size = new Size(254, 34);
            txtUyeAra.TabIndex = 30;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(566, 122);
            button1.Name = "button1";
            button1.Size = new Size(109, 40);
            button1.TabIndex = 31;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(681, 122);
            button2.Name = "button2";
            button2.Size = new Size(109, 40);
            button2.TabIndex = 31;
            button2.Text = "Yenile";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOrange;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(460, 623);
            button3.Name = "button3";
            button3.Size = new Size(214, 50);
            button3.TabIndex = 32;
            button3.Text = "Geri";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(53, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(160, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // frmÜyeleriGoruntule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DimGray;
            ClientSize = new Size(1151, 679);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtUyeAra);
            Controls.Add(dgvUyeListele);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmÜyeleriGoruntule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmÜyeleriGoruntule";
            Load += frmÜyeleriGoruntule_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUyeListele).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUyeListele;
        private TextBox txtUyeAra;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox2;
    }
}