namespace fitness_center
{
    partial class frmÖdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmÖdeme));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label3 = new Label();
            label9 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            dtpOdemeTarihi = new DateTimePicker();
            label4 = new Label();
            txtOdeme3 = new TextBox();
            label5 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            cmbAdSoyad = new ComboBox();
            dgvOdeme = new Guna.UI2.WinForms.Guna2DataGridView();
            txtAra = new TextBox();
            button1 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOdeme).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(1108, 9);
            label3.Name = "label3";
            label3.Size = new Size(38, 41);
            label3.TabIndex = 3;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkOrange;
            label9.Location = new Point(500, 66);
            label9.Name = "label9";
            label9.Size = new Size(151, 41);
            label9.TabIndex = 4;
            label9.Text = "Ödemeler";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(450, 25);
            label1.Name = "label1";
            label1.Size = new Size(257, 41);
            label1.TabIndex = 5;
            label1.Text = "FITNESS CENTER";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(40, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(196, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(41, 357);
            label2.Name = "label2";
            label2.Size = new Size(151, 28);
            label2.TabIndex = 35;
            label2.Text = "Üye Adı Soyadı";
            // 
            // dtpOdemeTarihi
            // 
            dtpOdemeTarihi.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpOdemeTarihi.Location = new Point(41, 309);
            dtpOdemeTarihi.Name = "dtpOdemeTarihi";
            dtpOdemeTarihi.Size = new Size(237, 27);
            dtpOdemeTarihi.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(41, 473);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 35;
            label4.Text = "Tutar";
            // 
            // txtOdeme3
            // 
            txtOdeme3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOdeme3.ForeColor = Color.DarkOrange;
            txtOdeme3.Location = new Point(41, 527);
            txtOdeme3.Name = "txtOdeme3";
            txtOdeme3.Size = new Size(254, 34);
            txtOdeme3.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(41, 255);
            label5.Name = "label5";
            label5.Size = new Size(136, 28);
            label5.TabIndex = 38;
            label5.Text = "Ödeme Tarihi";
            // 
            // button4
            // 
            button4.BackColor = Color.DarkOrange;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(86, 640);
            button4.Name = "button4";
            button4.Size = new Size(166, 50);
            button4.TabIndex = 41;
            button4.Text = "Geri";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOrange;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(57, 584);
            button3.Name = "button3";
            button3.Size = new Size(109, 50);
            button3.TabIndex = 40;
            button3.Text = "Ödeme";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(172, 584);
            button2.Name = "button2";
            button2.Size = new Size(109, 50);
            button2.TabIndex = 39;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(545, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // cmbAdSoyad
            // 
            cmbAdSoyad.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbAdSoyad.FormattingEnabled = true;
            cmbAdSoyad.Location = new Point(41, 407);
            cmbAdSoyad.Name = "cmbAdSoyad";
            cmbAdSoyad.Size = new Size(237, 36);
            cmbAdSoyad.TabIndex = 44;
            // 
            // dgvOdeme
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvOdeme.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvOdeme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvOdeme.ColumnHeadersHeight = 30;
            dgvOdeme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvOdeme.DefaultCellStyle = dataGridViewCellStyle3;
            dgvOdeme.GridColor = Color.Black;
            dgvOdeme.Location = new Point(318, 274);
            dgvOdeme.Name = "dgvOdeme";
            dgvOdeme.RowHeadersVisible = false;
            dgvOdeme.RowHeadersWidth = 51;
            dgvOdeme.RowTemplate.Height = 25;
            dgvOdeme.Size = new Size(808, 416);
            dgvOdeme.TabIndex = 45;
            dgvOdeme.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvOdeme.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvOdeme.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvOdeme.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvOdeme.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvOdeme.ThemeStyle.BackColor = Color.White;
            dgvOdeme.ThemeStyle.GridColor = Color.Black;
            dgvOdeme.ThemeStyle.HeaderStyle.BackColor = Color.DarkOrange;
            dgvOdeme.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOdeme.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvOdeme.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvOdeme.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvOdeme.ThemeStyle.HeaderStyle.Height = 30;
            dgvOdeme.ThemeStyle.ReadOnly = false;
            dgvOdeme.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvOdeme.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOdeme.ThemeStyle.RowsStyle.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvOdeme.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvOdeme.ThemeStyle.RowsStyle.Height = 25;
            dgvOdeme.ThemeStyle.RowsStyle.SelectionBackColor = Color.DarkOrange;
            dgvOdeme.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // txtAra
            // 
            txtAra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAra.ForeColor = Color.DarkOrange;
            txtAra.Location = new Point(460, 234);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(254, 34);
            txtAra.TabIndex = 46;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(720, 229);
            button1.Name = "button1";
            button1.Size = new Size(109, 40);
            button1.TabIndex = 47;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkOrange;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(835, 228);
            button5.Name = "button5";
            button5.Size = new Size(109, 40);
            button5.TabIndex = 47;
            button5.Text = "Yenile";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // frmÖdeme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1158, 749);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(txtAra);
            Controls.Add(dgvOdeme);
            Controls.Add(cmbAdSoyad);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(dtpOdemeTarihi);
            Controls.Add(txtOdeme3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmÖdeme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmÖdeme";
            Load += frmÖdeme_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOdeme).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label9;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private DateTimePicker dtpOdemeTarihi;
        private Label label4;
        private TextBox txtOdeme3;
        private Label label5;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox1;
        private ComboBox cmbAdSoyad;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOdeme;
        private TextBox txtAra;
        private Button button1;
        private Button button5;
    }
}