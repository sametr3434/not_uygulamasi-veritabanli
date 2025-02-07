namespace not_uygulamsı_veritabanlı_
{
    partial class frm_giris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rb_ogrenci_girisi = new RadioButton();
            rb_ogretmen_girisi = new RadioButton();
            txt_ad = new TextBox();
            lb_ad = new Label();
            lbl_numara = new Label();
            txt_numara_veya_sifre = new TextBox();
            btn_kullanici_girisi = new Button();
            SuspendLayout();
            // 
            // rb_ogrenci_girisi
            // 
            rb_ogrenci_girisi.AutoSize = true;
            rb_ogrenci_girisi.Location = new Point(337, 17);
            rb_ogrenci_girisi.Margin = new Padding(4);
            rb_ogrenci_girisi.Name = "rb_ogrenci_girisi";
            rb_ogrenci_girisi.Size = new Size(146, 32);
            rb_ogrenci_girisi.TabIndex = 0;
            rb_ogrenci_girisi.TabStop = true;
            rb_ogrenci_girisi.Text = "ögrenci girisi";
            rb_ogrenci_girisi.UseVisualStyleBackColor = true;
            rb_ogrenci_girisi.CheckedChanged += rb_ogrenci_girisi_CheckedChanged;
            // 
            // rb_ogretmen_girisi
            // 
            rb_ogretmen_girisi.AutoSize = true;
            rb_ogretmen_girisi.Location = new Point(546, 17);
            rb_ogretmen_girisi.Margin = new Padding(4);
            rb_ogretmen_girisi.Name = "rb_ogretmen_girisi";
            rb_ogretmen_girisi.Size = new Size(166, 32);
            rb_ogretmen_girisi.TabIndex = 1;
            rb_ogretmen_girisi.TabStop = true;
            rb_ogretmen_girisi.Text = "ögretmen girişi";
            rb_ogretmen_girisi.UseVisualStyleBackColor = true;
            rb_ogretmen_girisi.CheckedChanged += rb_ogretmen_girisi_CheckedChanged;
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(316, 113);
            txt_ad.Margin = new Padding(4);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(246, 34);
            txt_ad.TabIndex = 2;
            // 
            // lb_ad
            // 
            lb_ad.AutoSize = true;
            lb_ad.Location = new Point(127, 119);
            lb_ad.Margin = new Padding(4, 0, 4, 0);
            lb_ad.Name = "lb_ad";
            lb_ad.Size = new Size(39, 28);
            lb_ad.TabIndex = 3;
            lb_ad.Text = "AD";
            // 
            // lbl_numara
            // 
            lbl_numara.AutoSize = true;
            lbl_numara.Location = new Point(127, 205);
            lbl_numara.Name = "lbl_numara";
            lbl_numara.Size = new Size(169, 28);
            lbl_numara.TabIndex = 4;
            lbl_numara.Text = "Ögrenci Numarası";
            // 
            // txt_numara_veya_sifre
            // 
            txt_numara_veya_sifre.Location = new Point(316, 199);
            txt_numara_veya_sifre.Name = "txt_numara_veya_sifre";
            txt_numara_veya_sifre.Size = new Size(246, 34);
            txt_numara_veya_sifre.TabIndex = 5;
            // 
            // btn_kullanici_girisi
            // 
            btn_kullanici_girisi.Location = new Point(377, 276);
            btn_kullanici_girisi.Name = "btn_kullanici_girisi";
            btn_kullanici_girisi.Size = new Size(185, 51);
            btn_kullanici_girisi.TabIndex = 6;
            btn_kullanici_girisi.Text = "ögrenci girisi";
            btn_kullanici_girisi.UseVisualStyleBackColor = true;
            btn_kullanici_girisi.Click += btn_kullanici_girisi_Click;
            // 
            // frm_giris
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(btn_kullanici_girisi);
            Controls.Add(txt_numara_veya_sifre);
            Controls.Add(lbl_numara);
            Controls.Add(lb_ad);
            Controls.Add(txt_ad);
            Controls.Add(rb_ogretmen_girisi);
            Controls.Add(rb_ogrenci_girisi);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frm_giris";
            Text = "giris";
            Load += giris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rb_ogrenci_girisi;
        private RadioButton rb_ogretmen_girisi;
        private TextBox txt_ad;
        private Label lb_ad;
        private Label lbl_numara;
        private TextBox txt_numara_veya_sifre;
        private Button btn_kullanici_girisi;
    }
}