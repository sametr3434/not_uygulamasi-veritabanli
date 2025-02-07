using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace not_uygulamsı_veritabanlı_
{
    public partial class ögretmen_ana_ekran : Form
    {
        public ögretmen_ana_ekran()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pnl_yan_menü.Width == 0)
            {
                tr_acilan_pencere.Start();
            }
            else if (pnl_yan_menü.Width == 260)
            {
                tr_kapalan_penecere.Start();
            }
        }

        private void tr_acilan_pencere_Tick(object sender, EventArgs e)
        {
            pnl_yan_menü.Width += 10;
            if (pnl_yan_menü.Width == 260)
            {
                tr_acilan_pencere.Stop();
            }
        }

        private void tr_kapalan_penecere_Tick(object sender, EventArgs e)
        {
            pnl_yan_menü.Width -= 10;
            if (pnl_yan_menü.Width == 0)
            {
                tr_kapalan_penecere.Stop();
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ögrencinotu1 ögrencinotu1 = new ögrencinotu1();
            ögrencinotu1.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frm_not_degistirme Frm_not_degistirme = new frm_not_degistirme();
            Frm_not_degistirme.Show();
            this.Hide();
        }

        private void ögretmen_ana_ekran_Load(object sender, EventArgs e)
        {
            pnl_yan_menü.Width = 0;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
