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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmÜyeEkle uyeekle = new frmÜyeEkle();
            uyeekle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGuncelleSil guncelleSil = new frmGuncelleSil();
            guncelleSil.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmÖdeme odeme = new frmÖdeme();
            odeme.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmÜyeleriGoruntule uyelerigoruntule = new frmÜyeleriGoruntule();
            uyelerigoruntule.Show();
            this.Hide();
        }
    }
}
