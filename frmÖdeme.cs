using Bunifu.UI.WinForms.Helpers.Transitions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness_center
{
    public partial class frmÖdeme : Form
    {
        public frmÖdeme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SporDb;Integrated Security=True;TrustServerCertificate=True");

        private void FillName()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select UAdSoyad from UyeTbl", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("UAdSoyad", typeof(string));
            dt.Load(rdr);
            cmbAdSoyad.ValueMember = "UAdSoyad";
            cmbAdSoyad.DataSource = dt;
            baglanti.Close();
        }
        private void AdFiltrele()
        {
            baglanti.Open();
            string query = "select * from OdemeTbl where OUye = '" + txtAra.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgvOdeme.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from OdemeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgvOdeme.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cmbAdSoyad.Text = "";
            txtOdeme3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAnasayfa anasayfa = new frmAnasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void frmÖdeme_Load(object sender, EventArgs e)
        {
            FillName();
            uyeler();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbAdSoyad.Text == "" || txtOdeme3.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                string dtpodemetarih = dtpOdemeTarihi.Value.Month.ToString() + dtpOdemeTarihi.Value.Year.ToString();
                baglanti.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from OdemeTbl where OUye ='" + cmbAdSoyad.SelectedValue.ToString() + "' and OAy ='" + dtpodemetarih + "'", baglanti);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Zaten Ödeme Yapıldı");
                }
                else
                {
                    string query = "Insert into OdemeTbl values('" + dtpodemetarih + "','" + cmbAdSoyad.SelectedValue.ToString() + "'," + txtOdeme3.Text + ")";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Tutar Başarıyla Ödendi");
                }
                baglanti.Close();
                uyeler();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdFiltrele();
            txtAra.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            uyeler();
        }
    }
}
