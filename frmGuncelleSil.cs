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
    public partial class frmGuncelleSil : Form
    {
        public frmGuncelleSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SporDb;Integrated Security=True;TrustServerCertificate=True");

        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from UyeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgvGuncelleSil.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void frmGuncelleSil_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        int key = 0;

        private void dgvUyeListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(dgvGuncelleSil.SelectedRows[0].Cells[0].Value.ToString());
            txtAdSoyad2.Text = dgvGuncelleSil.SelectedRows[0].Cells[1].Value.ToString();
            txtTelNo2.Text = dgvGuncelleSil.SelectedRows[0].Cells[2].Value.ToString();
            cmbCinsiyet2.Text = dgvGuncelleSil.SelectedRows[0].Cells[3].Value.ToString();
            txtYas2.Text = dgvGuncelleSil.SelectedRows[0].Cells[4].Value.ToString();
            txtOdeme2.Text = dgvGuncelleSil.SelectedRows[0].Cells[5].Value.ToString();
            cmbZamanlama2.Text = dgvGuncelleSil.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAdSoyad2.Text = "";
            txtTelNo2.Text = "";
            cmbCinsiyet2.Text = "";
            txtYas2.Text = "";
            txtOdeme2.Text = "";
            cmbZamanlama2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAnasayfa anasayfa = new frmAnasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek Üyeyi Seçiniz");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from UyeTbl where Uid =" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Silindi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0 || txtAdSoyad2.Text == "" || txtTelNo2.Text == "" || cmbCinsiyet2.Text == "" || txtYas2.Text == "" || cmbZamanlama2.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update UyeTbl set UAdSoyad ='" + txtAdSoyad2.Text + "',UTelefon='" + txtTelNo2.Text + "',UCinsiyet='" + cmbCinsiyet2.Text + "',UYas='" + txtYas2.Text + "',UOdeme='" + txtOdeme2.Text + "',UZamanlama='" + cmbZamanlama2.Text + "' where Uid=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Güncellendi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
