namespace fitness_center
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtKullanici.Text = "";
            txtSifre.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else if(txtKullanici.Text == "Admin" && txtSifre.Text == "1234")
            {
                frmAnasayfa anasayfa = new frmAnasayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý Kullanýcý ya da Þifre");
            }
        }
    }
}