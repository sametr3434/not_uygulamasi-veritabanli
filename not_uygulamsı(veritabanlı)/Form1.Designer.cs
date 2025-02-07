namespace not_uygulamsı_veritabanlı_
{
    partial class not_girişi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAdı = new TextBox();
            txtOkulNo = new TextBox();
            txtDersinAdı = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_Notu = new TextBox();
            btn_giris = new Button();
            btn_silme = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtAdı
            // 
            txtAdı.Location = new Point(236, 51);
            txtAdı.Name = "txtAdı";
            txtAdı.Size = new Size(199, 34);
            txtAdı.TabIndex = 0;
            // 
            // txtOkulNo
            // 
            txtOkulNo.Location = new Point(236, 112);
            txtOkulNo.Name = "txtOkulNo";
            txtOkulNo.Size = new Size(199, 34);
            txtOkulNo.TabIndex = 1;
            // 
            // txtDersinAdı
            // 
            txtDersinAdı.Location = new Point(236, 174);
            txtDersinAdı.Name = "txtDersinAdı";
            txtDersinAdı.Size = new Size(199, 34);
            txtDersinAdı.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 63);
            label1.Name = "label1";
            label1.Size = new Size(121, 27);
            label1.TabIndex = 3;
            label1.Text = "ögrenci adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 119);
            label2.Name = "label2";
            label2.Size = new Size(85, 27);
            label2.TabIndex = 4;
            label2.Text = "okul no";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 181);
            label3.Name = "label3";
            label3.Size = new Size(107, 27);
            label3.TabIndex = 5;
            label3.Text = "dersin adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 237);
            label4.Name = "label4";
            label4.Size = new Size(61, 27);
            label4.TabIndex = 7;
            label4.Text = "Notu";
            // 
            // txt_Notu
            // 
            txt_Notu.Location = new Point(236, 230);
            txt_Notu.Name = "txt_Notu";
            txt_Notu.Size = new Size(199, 34);
            txt_Notu.TabIndex = 6;
            // 
            // btn_giris
            // 
            btn_giris.BackColor = Color.Green;
            btn_giris.ForeColor = SystemColors.ButtonFace;
            btn_giris.Location = new Point(236, 280);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(94, 40);
            btn_giris.TabIndex = 8;
            btn_giris.Text = "GİRİS";
            btn_giris.UseVisualStyleBackColor = false;
            btn_giris.Click += btn_giris_Click;
            // 
            // btn_silme
            // 
            btn_silme.BackColor = Color.FromArgb(192, 0, 0);
            btn_silme.ForeColor = SystemColors.ButtonFace;
            btn_silme.Location = new Point(336, 280);
            btn_silme.Name = "btn_silme";
            btn_silme.Size = new Size(94, 40);
            btn_silme.TabIndex = 9;
            btn_silme.Text = "SİL";
            btn_silme.UseVisualStyleBackColor = false;
            btn_silme.Click += btn_silme_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.left_chevron;
            pictureBox1.Location = new Point(927, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // not_girişi
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 375);
            Controls.Add(pictureBox1);
            Controls.Add(btn_silme);
            Controls.Add(btn_giris);
            Controls.Add(label4);
            Controls.Add(txt_Notu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDersinAdı);
            Controls.Add(txtOkulNo);
            Controls.Add(txtAdı);
            Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "not_girişi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdı;
        private TextBox txtOkulNo;
        private TextBox txtDersinAdı;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_Notu;
        private Button btn_giris;
        private Button btn_silme;
        private PictureBox pictureBox1;
    }
}
