using System;
using Microsoft.Data.SqlClient;
namespace not_uygulamsı_veritabanlı_
{
    public partial class not_girişi : Form
    {
        public not_girişi()
        {
            InitializeComponent();
        }

        private void btn_silme_Click(object sender, EventArgs e)
        {

        }
        SqlConnection baglantı = new SqlConnection("@Data Source=laptop-qs81dqlq.ögrenci_notları.dbo");

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open(); MessageBox.Show("BAGLANDI");
            }
            catch { MessageBox.Show("."); }
            //SqlCommand komut= new SqlCommand("INSORT INTO tbl_ögrenci_notları (ogrenci_adi ,okul_no,dersin_adı,notu) VALUS)(@ogrenci_adi,@okul_no,@dersin_adı,@notu)", baglantı);
            // komut.Parameters.AddWithValue("@ogrenci_adi", txtAdı);
            // komut.Parameters.AddWithValue("@dersin_adı", txtDersinAdı);
            // komut.Parameters.AddWithValue("@okul_no", txtOkulNo);
            // komut.Parameters.AddWithValue("@notu", txt_Notu);
            // komut.ExecuteNonQuery();
            // baglantı.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ögretmen_ana_ekran ögrenmek_Ana_Ekran = new ögretmen_ana_ekran();
            ögrenmek_Ana_Ekran.Show();
            this.Close();
        }
    }
}
