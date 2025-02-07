namespace not_uygulamsı_veritabanlı_
{
    partial class frm_notları_göster
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
            cmb_ders_secin = new ComboBox();
            label1 = new Label();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmb_ders_secin
            // 
            cmb_ders_secin.FormattingEnabled = true;
            cmb_ders_secin.Items.AddRange(new object[] { "fen", "MATEMATİK" });
            cmb_ders_secin.Location = new Point(316, 91);
            cmb_ders_secin.Margin = new Padding(4);
            cmb_ders_secin.Name = "cmb_ders_secin";
            cmb_ders_secin.Size = new Size(206, 36);
            cmb_ders_secin.TabIndex = 0;
            cmb_ders_secin.SelectedIndexChanged += cmb_ders_secin_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 94);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 1;
            label1.Text = "ders secin ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(206, 213);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(469, 284);
            listBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.left_chevron;
            pictureBox1.Location = new Point(843, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frm_notları_göster
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 592);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(cmb_ders_secin);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "frm_notları_göster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "notları göster";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_ders_secin;
        private Label label1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
    }
}