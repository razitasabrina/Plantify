namespace plantify.Forms
{
    partial class FormKatalog
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
            lblSambutan = new Label();
            txtCari = new TextBox();
            btnCari = new Button();
            lblKategori = new Label();
            pictureBox1 = new PictureBox();
            flpKatalog = new FlowLayoutPanel();
            pnlDetail = new Panel();
            pbDetail = new PictureBox();
            lblNamaProduk = new Label();
            lblDeskripsi = new Label();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDetail).BeginInit();
            SuspendLayout();
            // 
            // lblSambutan
            // 
            lblSambutan.AutoSize = true;
            lblSambutan.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSambutan.ForeColor = Color.FromArgb(75, 96, 67);
            lblSambutan.Location = new Point(67, 45);
            lblSambutan.Name = "lblSambutan";
            lblSambutan.Size = new Size(264, 35);
            lblSambutan.TabIndex = 0;
            lblSambutan.Text = "Selamat datang!";
            // 
            // txtCari
            // 
            txtCari.Location = new Point(547, 82);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(157, 27);
            txtCari.TabIndex = 1;
            txtCari.TextChanged += txtCari_TextChanged;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(75, 96, 67);
            btnCari.FlatStyle = FlatStyle.Popup;
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(710, 82);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(69, 27);
            btnCari.TabIndex = 2;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click_1;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKategori.ForeColor = Color.FromArgb(75, 96, 67);
            lblKategori.Location = new Point(543, 57);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(163, 20);
            lblKategori.TabIndex = 8;
            lblKategori.Text = "Cari Bibit dan Kategori:";
            lblKategori.Click += lblKategori_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Plantify.Properties.Resources.a7e06774_5e62_4ee1_a088_40968eabf182;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(55, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // flpKatalog
            // 
            flpKatalog.AutoScroll = true;
            flpKatalog.Location = new Point(27, 118);
            flpKatalog.Name = "flpKatalog";
            flpKatalog.Size = new Size(479, 320);
            flpKatalog.TabIndex = 11;
            // 
            // pnlDetail
            // 
            pnlDetail.BackColor = Color.White;
            pnlDetail.BorderStyle = BorderStyle.FixedSingle;
            pnlDetail.Controls.Add(lblDeskripsi);
            pnlDetail.Controls.Add(lblNamaProduk);
            pnlDetail.Controls.Add(pbDetail);
            pnlDetail.Location = new Point(548, 118);
            pnlDetail.Name = "pnlDetail";
            pnlDetail.Size = new Size(231, 320);
            pnlDetail.TabIndex = 12;
            // 
            // pbDetail
            // 
            pbDetail.BackgroundImageLayout = ImageLayout.Stretch;
            pbDetail.Location = new Point(12, 16);
            pbDetail.Name = "pbDetail";
            pbDetail.Size = new Size(209, 134);
            pbDetail.TabIndex = 0;
            pbDetail.TabStop = false;
            // 
            // lblNamaProduk
            // 
            lblNamaProduk.AutoSize = true;
            lblNamaProduk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaProduk.ForeColor = Color.FromArgb(75, 96, 67);
            lblNamaProduk.Location = new Point(12, 153);
            lblNamaProduk.Name = "lblNamaProduk";
            lblNamaProduk.Size = new Size(88, 20);
            lblNamaProduk.TabIndex = 1;
            lblNamaProduk.Text = "Nama Bibit";
            lblNamaProduk.Click += lblNamaProduk_Click;
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.ForeColor = Color.FromArgb(75, 96, 67);
            lblDeskripsi.Location = new Point(10, 183);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(211, 120);
            lblDeskripsi.TabIndex = 2;
            lblDeskripsi.Text = "Pilih bibit untuk melihat detail";
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(75, 96, 67);
            btnKembali.FlatStyle = FlatStyle.Popup;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(685, 20);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 13;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // FormKatalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 234, 209);
            ClientSize = new Size(800, 450);
            Controls.Add(btnKembali);
            Controls.Add(pnlDetail);
            Controls.Add(flpKatalog);
            Controls.Add(lblKategori);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(lblSambutan);
            Controls.Add(pictureBox1);
            Name = "FormKatalog";
            Text = "FormKatalog";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDetail.ResumeLayout(false);
            pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSambutan;
        private TextBox txtCari;
        private Button btnCari;
        private Label lblKategori;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flpKatalog;
        private Panel pnlDetail;
        private PictureBox pbDetail;
        private Label lblDeskripsi;
        private Label lblNamaProduk;
        private Button btnKembali;
    }
}