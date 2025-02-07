namespace not_uygulamsı_veritabanlı_
{
    partial class frm_not_degistirme
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
            label1 = new Label();
            txt_okul_no = new TextBox();
            txt_degisecek_ders = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_yeni_notu = new TextBox();
            btn_degistir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 68);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 0;
            label1.Text = "okul no";
            // 
            // txt_okul_no
            // 
            txt_okul_no.Location = new Point(348, 68);
            txt_okul_no.Name = "txt_okul_no";
            txt_okul_no.Size = new Size(125, 34);
            txt_okul_no.TabIndex = 1;
            txt_okul_no.TextChanged += txt_okul_no_TextChanged;
            // 
            // txt_degisecek_ders
            // 
            txt_degisecek_ders.Location = new Point(348, 140);
            txt_degisecek_ders.Name = "txt_degisecek_ders";
            txt_degisecek_ders.Size = new Size(125, 34);
            txt_degisecek_ders.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 143);
            label2.Name = "label2";
            label2.Size = new Size(194, 28);
            label2.TabIndex = 3;
            label2.Text = "hangi ders degisecek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 223);
            label3.Name = "label3";
            label3.Size = new Size(175, 28);
            label3.TabIndex = 5;
            label3.Text = "yeni notunu giriniz";
            // 
            // txt_yeni_notu
            // 
            txt_yeni_notu.Location = new Point(348, 220);
            txt_yeni_notu.Name = "txt_yeni_notu";
            txt_yeni_notu.Size = new Size(125, 34);
            txt_yeni_notu.TabIndex = 4;
            // 
            // btn_degistir
            // 
            btn_degistir.Location = new Point(348, 330);
            btn_degistir.Name = "btn_degistir";
            btn_degistir.Size = new Size(95, 54);
            btn_degistir.TabIndex = 6;
            btn_degistir.Text = "degistir";
            btn_degistir.UseVisualStyleBackColor = true;
            btn_degistir.Click += btn_degistir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.left_chevron;
            pictureBox1.Location = new Point(1005, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frm_not_degistirme
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 644);
            Controls.Add(pictureBox1);
            Controls.Add(btn_degistir);
            Controls.Add(label3);
            Controls.Add(txt_yeni_notu);
            Controls.Add(label2);
            Controls.Add(txt_degisecek_ders);
            Controls.Add(txt_okul_no);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "frm_not_degistirme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "not degistirme sayfası";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_okul_no;
        private TextBox txt_degisecek_ders;
        private Label label2;
        private Label label3;
        private TextBox txt_yeni_notu;
        private Button btn_degistir;
        private PictureBox pictureBox1;
    }
}