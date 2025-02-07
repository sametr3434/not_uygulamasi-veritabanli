namespace not_uygulamsı_veritabanlı_
{
    partial class ögrencinotu1
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
            txt_ogrenci_adı = new TextBox();
            txt_no = new TextBox();
            txt_dersin_adi = new TextBox();
            txt_not = new TextBox();
            bl_ögreniciAdı = new Label();
            lbl_ögrenicno = new Label();
            lbl_dersadı = new Label();
            lbl_not = new Label();
            button2 = new Button();
            kaydet = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_ogrenci_adı
            // 
            txt_ogrenci_adı.Location = new Point(371, 96);
            txt_ogrenci_adı.Name = "txt_ogrenci_adı";
            txt_ogrenci_adı.Size = new Size(194, 34);
            txt_ogrenci_adı.TabIndex = 0;
            // 
            // txt_no
            // 
            txt_no.Location = new Point(371, 147);
            txt_no.Name = "txt_no";
            txt_no.Size = new Size(194, 34);
            txt_no.TabIndex = 1;
            // 
            // txt_dersin_adi
            // 
            txt_dersin_adi.Location = new Point(371, 206);
            txt_dersin_adi.Name = "txt_dersin_adi";
            txt_dersin_adi.Size = new Size(194, 34);
            txt_dersin_adi.TabIndex = 2;
            // 
            // txt_not
            // 
            txt_not.Location = new Point(371, 264);
            txt_not.Name = "txt_not";
            txt_not.Size = new Size(194, 34);
            txt_not.TabIndex = 3;
            // 
            // bl_ögreniciAdı
            // 
            bl_ögreniciAdı.AutoSize = true;
            bl_ögreniciAdı.Location = new Point(200, 98);
            bl_ögreniciAdı.Name = "bl_ögreniciAdı";
            bl_ögreniciAdı.Size = new Size(113, 28);
            bl_ögreniciAdı.TabIndex = 4;
            bl_ögreniciAdı.Text = "ögrenic adı";
            // 
            // lbl_ögrenicno
            // 
            lbl_ögrenicno.AutoSize = true;
            lbl_ögrenicno.Location = new Point(200, 153);
            lbl_ögrenicno.Name = "lbl_ögrenicno";
            lbl_ögrenicno.Size = new Size(110, 28);
            lbl_ögrenicno.TabIndex = 5;
            lbl_ögrenicno.Text = "ögrenic no";
            // 
            // lbl_dersadı
            // 
            lbl_dersadı.AutoSize = true;
            lbl_dersadı.Location = new Point(197, 209);
            lbl_dersadı.Name = "lbl_dersadı";
            lbl_dersadı.Size = new Size(100, 28);
            lbl_dersadı.TabIndex = 6;
            lbl_dersadı.Text = "DersinAdı";
            // 
            // lbl_not
            // 
            lbl_not.AutoSize = true;
            lbl_not.Location = new Point(200, 270);
            lbl_not.Name = "lbl_not";
            lbl_not.Size = new Size(43, 28);
            lbl_not.TabIndex = 7;
            lbl_not.Text = "not";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(471, 342);
            button2.Name = "button2";
            button2.Size = new Size(94, 53);
            button2.TabIndex = 9;
            button2.Text = "sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // kaydet
            // 
            kaydet.BackColor = Color.Green;
            kaydet.Location = new Point(371, 342);
            kaydet.Name = "kaydet";
            kaydet.Size = new Size(94, 53);
            kaydet.TabIndex = 10;
            kaydet.Text = "kaydet";
            kaydet.UseVisualStyleBackColor = false;
            kaydet.Click += kaydet_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.left_chevron;
            pictureBox1.Location = new Point(951, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ögrencinotu1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 630);
            Controls.Add(pictureBox1);
            Controls.Add(kaydet);
            Controls.Add(button2);
            Controls.Add(lbl_not);
            Controls.Add(lbl_dersadı);
            Controls.Add(lbl_ögrenicno);
            Controls.Add(bl_ögreniciAdı);
            Controls.Add(txt_not);
            Controls.Add(txt_dersin_adi);
            Controls.Add(txt_no);
            Controls.Add(txt_ogrenci_adı);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "ögrencinotu1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ögrencinotu1";
            Load += ögrencinotu1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_ogrenci_adı;
        private TextBox txt_no;
        private TextBox txt_dersin_adi;
        private TextBox txt_not;
        private Label bl_ögreniciAdı;
        private Label lbl_ögrenicno;
        private Label lbl_dersadı;
        private Label lbl_not;
        private Button button2;
        private Button kaydet;
        private PictureBox pictureBox1;
    }
}