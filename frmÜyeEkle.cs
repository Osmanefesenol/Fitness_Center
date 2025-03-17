using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace fitness_center
{

    public partial class frmÜyeEkle : Form
    {
        public frmÜyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SporDb;Integrated Security=True;TrustServerCertificate=True");


        private void frmÜyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad1.Text == "" || txtTelNo1.Text == "" || txtOdeme1.Text == "" || txtYas1.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "Insert into UyeTbl values('" + txtAdSoyad1.Text + "','" + txtTelNo1.Text + "','" + cmbCinsiyet1.SelectedItem.ToString() + "','" + txtYas1.Text + "','" + txtOdeme1.Text + "','" + cmbZamanlama1.SelectedItem.ToString() + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Eklendi");
                    baglanti.Close();
                    txtAdSoyad1.Text = "";
                    txtTelNo1.Text = "";
                    txtOdeme1.Text = "";
                    txtYas1.Text = "";
                    cmbCinsiyet1.Text = "";
                    cmbZamanlama1.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            txtAdSoyad1.Text = "";
            txtTelNo1.Text = "";
            txtOdeme1.Text = "";
            txtYas1.Text = "";
            cmbCinsiyet1.Text = "";
            cmbZamanlama1.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAnasayfa anasayfa = new frmAnasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
