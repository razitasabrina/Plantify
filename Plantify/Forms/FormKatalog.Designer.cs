namespace Plantify.Forms
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
            cmbKategori = new ComboBox();
            dgvKatalog = new DataGridView();
            rtbDetail = new RichTextBox();
            btnBeli = new Button();
            btnLogout = new Button();
            lblKategori = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvKatalog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            txtCari.Location = new Point(67, 110);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(229, 27);
            txtCari.TabIndex = 1;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(75, 96, 67);
            btnCari.FlatStyle = FlatStyle.Popup;
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(320, 110);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(94, 29);
            btnCari.TabIndex = 2;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(477, 110);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(193, 28);
            cmbKategori.TabIndex = 3;
            // 
            // dgvKatalog
            // 
            dgvKatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKatalog.Location = new Point(67, 175);
            dgvKatalog.Name = "dgvKatalog";
            dgvKatalog.RowHeadersWidth = 51;
            dgvKatalog.Size = new Size(347, 188);
            dgvKatalog.TabIndex = 4;
            // 
            // rtbDetail
            // 
            rtbDetail.Location = new Point(477, 175);
            rtbDetail.Name = "rtbDetail";
            rtbDetail.Size = new Size(265, 188);
            rtbDetail.TabIndex = 5;
            rtbDetail.Text = "";
            // 
            // btnBeli
            // 
            btnBeli.BackColor = Color.FromArgb(75, 96, 67);
            btnBeli.FlatStyle = FlatStyle.Popup;
            btnBeli.ForeColor = Color.White;
            btnBeli.Location = new Point(312, 386);
            btnBeli.Name = "btnBeli";
            btnBeli.Size = new Size(102, 36);
            btnBeli.TabIndex = 6;
            btnBeli.Text = "Beli";
            btnBeli.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(156, 0, 18);
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(599, 45);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKategori.ForeColor = Color.FromArgb(75, 96, 67);
            lblKategori.Location = new Point(676, 115);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(69, 20);
            lblKategori.TabIndex = 8;
            lblKategori.Text = "Kategori";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.a7e06774_5e62_4ee1_a088_40968eabf182;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(55, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources._657ba50e_f1b8_4521_91d4_f45c6c3e1d9b;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(699, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 35);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // FormKatalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 234, 209);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(lblKategori);
            Controls.Add(btnLogout);
            Controls.Add(btnBeli);
            Controls.Add(rtbDetail);
            Controls.Add(dgvKatalog);
            Controls.Add(cmbKategori);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(lblSambutan);
            Controls.Add(pictureBox1);
            Name = "FormKatalog";
            Text = "FormKatalog";
            ((System.ComponentModel.ISupportInitialize)dgvKatalog).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSambutan;
        private TextBox txtCari;
        private Button btnCari;
        private ComboBox cmbKategori;
        private DataGridView dgvKatalog;
        private RichTextBox rtbDetail;
        private Button btnBeli;
        private Button btnLogout;
        private Label lblKategori;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}