namespace not_uygulamsı_veritabanlı_
{
    partial class ögretmen_ana_ekran
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ögretmen_ana_ekran));
            pictureBox1 = new PictureBox();
            pnl_ust = new Panel();
            pnl_yan_menü = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            tr_acilan_pencere = new System.Windows.Forms.Timer(components);
            tr_kapalan_penecere = new System.Windows.Forms.Timer(components);
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnl_ust.SuspendLayout();
            pnl_yan_menü.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.yesil_arti;
            pictureBox1.Location = new Point(12, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pnl_ust
            // 
            pnl_ust.BackColor = Color.FromArgb(128, 128, 255);
            pnl_ust.Controls.Add(pictureBox1);
            pnl_ust.Location = new Point(0, 2);
            pnl_ust.Name = "pnl_ust";
            pnl_ust.Size = new Size(992, 70);
            pnl_ust.TabIndex = 1;
            // 
            // pnl_yan_menü
            // 
            pnl_yan_menü.Anchor = AnchorStyles.Left;
            pnl_yan_menü.BackColor = Color.SlateBlue;
            pnl_yan_menü.Controls.Add(pictureBox4);
            pnl_yan_menü.Controls.Add(pictureBox3);
            pnl_yan_menü.Controls.Add(pictureBox2);
            pnl_yan_menü.Location = new Point(-14, 68);
            pnl_yan_menü.Name = "pnl_yan_menü";
            pnl_yan_menü.Size = new Size(260, 550);
            pnl_yan_menü.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(92, 149);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(97, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(92, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(97, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseHover += pictureBox2_MouseHover;
            // 
            // tr_acilan_pencere
            // 
            tr_acilan_pencere.Interval = 10;
            tr_acilan_pencere.Tick += tr_acilan_pencere_Tick;
            // 
            // tr_kapalan_penecere
            // 
            tr_kapalan_penecere.Interval = 10;
            tr_kapalan_penecere.Tick += tr_kapalan_penecere_Tick;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(90, 256);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(97, 80);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // ögretmen_ana_ekran
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 614);
            Controls.Add(pnl_yan_menü);
            Controls.Add(pnl_ust);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "ögretmen_ana_ekran";
            Text = "ögretmen ana ekranı";
            Load += ögretmen_ana_ekran_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnl_ust.ResumeLayout(false);
            pnl_yan_menü.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel pnl_ust;
        private Panel pnl_yan_menü;
        private System.Windows.Forms.Timer tr_acilan_pencere;
        private System.Windows.Forms.Timer tr_kapalan_penecere;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}