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
    public partial class frm_giris : Form
    {
        public frm_giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-QS81DQLQ;Initial Catalog=ögrenci_notları;Integrated Security=True;Encrypt=False");
        private void giris_Load(object sender, EventArgs e)
        {
            rb_ogrenci_girisi.Checked = true;
        }

        private void rb_ogretmen_girisi_CheckedChanged(object sender, EventArgs e)
        {
            lbl_numara.Text = "ögretmen sifresi";
            btn_kullanici_girisi.Text = "ögretmen girisi";
            Point point = new Point();

        }

        private void rb_ogrenci_girisi_CheckedChanged(object sender, EventArgs e)
        {
            lbl_numara.Text = "ögrenci numarası";
            btn_kullanici_girisi.Text = "ögrenci girisi";
        }

        private void btn_kullanici_girisi_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut;

                // Öğrenci girişi kontrolü
                if (rb_ogrenci_girisi.Checked)
                {
                    komut = new SqlCommand("SELECT * FROM tbl_ögrenci_notları WHERE ogrenci_adi=@p1 AND okul_no=@p2", baglanti);
                    komut.Parameters.AddWithValue("@p1", txt_ad.Text);
                    komut.Parameters.AddWithValue("@p2", txt_numara_veya_sifre.Text);
                }
                // Öğretmen girişi kontrolü
                else if (rb_ogretmen_girisi.Checked)
                {
                    komut = new SqlCommand("SELECT * FROM tbl_ogretmenler WHERE ogretmen_adi=@p1 AND sifre=@p2", baglanti);
                    komut.Parameters.AddWithValue("@p1", txt_ad.Text);
                    komut.Parameters.AddWithValue("@p2", txt_numara_veya_sifre.Text);

                }
                else
                {
                    MessageBox.Show("Lütfen bir giriş türü seçin.");
                    return;
                }

                // Sorguyu çalıştır ve sonucu kontrol et
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read() && oku.HasRows)
                {
                    MessageBox.Show("Giriş başarılı!");
                    if (rb_ogretmen_girisi.Checked == true)
                    {
                        frm_notları_göster frm_Notları_Göster = new frm_notları_göster();
                        frm_Notları_Göster.Show();
                        this.Hide();
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Giriş bilgileri hatalı. Lütfen tekrar deneyin.");
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Giriş yapılamadı. Hata: " + ex.Message);
            }
        }

    }
}
