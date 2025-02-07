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

namespace not_uygulamsı_veritabanlı_
{
    public partial class ögrencinotu1 : Form
    {
        public ögrencinotu1()
        {
            InitializeComponent();
        }

        private void ögrencinotu1_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-QS81DQLQ;Initial Catalog=ögrenci_notları;Integrated Security=True;Encrypt=False");
        private void button2_Click(object sender, EventArgs e)
        {
            txt_dersin_adi.Clear();
            txt_no.Clear();
            txt_not.Clear();
            txt_not.Clear();
            txt_ogrenci_adı.Clear();
            txt_ogrenci_adı.Focus();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand komut = new SqlCommand("INSERT INTO tbl_ögrenci_notları (ogrenci_adi,okul_no,dersin_adı,notu) VALUES(@ogrenci_adi,@okul_no,@dersin_adı,@notu)", baglanti);
                komut.Parameters.AddWithValue("@ogrenci_adi", txt_ogrenci_adı.Text.ToUpper());
                komut.Parameters.AddWithValue("@okul_no", txt_no.Text.ToUpper());
                komut.Parameters.AddWithValue("@dersin_adı", txt_dersin_adi.Text);
                komut.Parameters.AddWithValue("@notu", txt_not.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt yapıldı");
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm_not_degistirme frm_Not_Degistirme = new frm_not_degistirme();
            frm_Not_Degistirme.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ögretmen_ana_ekran ögrenmek_Ana_Ekran =new ögretmen_ana_ekran();
            ögrenmek_Ana_Ekran.Show();
            this.Hide();
        }
    }
}
