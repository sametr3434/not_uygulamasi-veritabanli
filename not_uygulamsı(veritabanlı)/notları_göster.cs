using Microsoft.Data.SqlClient;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace not_uygulamsı_veritabanlı_
{

    public partial class frm_notları_göster : Form
    {
        public frm_notları_göster()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-QS81DQLQ;Initial Catalog=ögrenci_notları;Integrated Security=True;Encrypt=False");
        private void cmb_ders_secin_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM tbl_ögrenci_notları WHERE dersin_adı=@dersin_adi", baglanti);
                komut.Parameters.AddWithValue("@dersin_adi", cmb_ders_secin.Text);

                SqlDataReader oku = komut.ExecuteReader(); // SELECT için DataReader kullanılır
                while (oku.Read()) // Verileri satır satır okur
                {
                    // Okunan veriyi listBox1'e ekle
                    listBox1.Items.Add($"Öğrenci Adı: {oku["ogrenci_adi"]}, Not: {oku["notu"]}");
                }

                oku.Close();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Hata alındı: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ögretmen_ana_ekran ögrenmek_Ana_Ekran = new ögretmen_ana_ekran();
            ögrenmek_Ana_Ekran.Show();
            this.Hide();
        }
    }
}
