using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace not_uygulamsı_veritabanlı_
{
    public partial class frm_not_degistirme : Form
    {
        public frm_not_degistirme()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantısı
        SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-QS81DQLQ;Initial Catalog=ögrenci_notları;Integrated Security=True;Encrypt=False");

        private void btn_degistir_Click(object sender, EventArgs e)
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglantı.Open();

                // SQL komutunu oluşturuyoruz
                SqlCommand komut = new SqlCommand("UPDATE tbl_ögrenci_notları SET notu=@P2 WHERE okul_no=@P1 AND dersin_adı=@P3", baglantı);

                // Parametreleri ekliyoruz
                komut.Parameters.AddWithValue("@P1", txt_okul_no.Text.Trim());
                komut.Parameters.AddWithValue("@P2", txt_yeni_notu.Text.Trim());
                komut.Parameters.AddWithValue("@P3", txt_degisecek_ders.Text.Trim());

                // Sorguyu çalıştırıyoruz
                int etkilenenSatir = komut.ExecuteNonQuery();

                // Kullanıcıya geri bildirim veriyoruz
                if (etkilenenSatir > 0)
                {
                    MessageBox.Show("Not başarıyla değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı. Lütfen bilgileri kontrol edin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Hata mesajı
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                if (baglantı.State == System.Data.ConnectionState.Open)
                {
                    baglantı.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ögretmen_ana_ekran ögrenmek_Ana_Ekran = new ögretmen_ana_ekran();
            ögrenmek_Ana_Ekran.Show();
            this.Hide();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm_notları_göster frm_Notları_Göster = new frm_notları_göster();
            frm_Notları_Göster.Show();
            this.Hide();
        }

        private void txt_okul_no_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
