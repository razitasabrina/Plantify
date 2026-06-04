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
            ((System.ComponentModel.ISupportInitialize)dgvKatalog).BeginInit();
            SuspendLayout();
            // 
            // lblSambutan
            // 
            lblSambutan.AutoSize = true;
            lblSambutan.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSambutan.ForeColor = Color.FromArgb(75, 96, 67);
            lblSambutan.Location = new Point(112, 37);
            lblSambutan.Name = "lblSambutan";
            lblSambutan.Size = new Size(264, 35);
            lblSambutan.TabIndex = 0;
            lblSambutan.Text = "Selamat datang!";
            // 
            // txtCari
            // 
            txtCari.Location = new Point(67, 110);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(237, 27);
            txtCari.TabIndex = 1;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(75, 96, 67);
            btnCari.FlatStyle = FlatStyle.Popup;
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(344, 110);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(94, 29);
            btnCari.TabIndex = 2;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(495, 110);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(247, 28);
            cmbKategori.TabIndex = 3;
            // 
            // dgvKatalog
            // 
            dgvKatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKatalog.Location = new Point(67, 175);
            dgvKatalog.Name = "dgvKatalog";
            dgvKatalog.RowHeadersWidth = 51;
            dgvKatalog.Size = new Size(371, 188);
            dgvKatalog.TabIndex = 4;
            // 
            // rtbDetail
            // 
            rtbDetail.Location = new Point(499, 175);
            rtbDetail.Name = "rtbDetail";
            rtbDetail.Size = new Size(243, 188);
            rtbDetail.TabIndex = 5;
            rtbDetail.Text = "";
            // 
            // btnBeli
            // 
            btnBeli.BackColor = Color.FromArgb(75, 96, 67);
            btnBeli.FlatStyle = FlatStyle.Popup;
            btnBeli.ForeColor = Color.White;
            btnBeli.Location = new Point(336, 389);
            btnBeli.Name = "btnBeli";
            btnBeli.Size = new Size(102, 36);
            btnBeli.TabIndex = 6;
            btnBeli.Text = "Beli";
            btnBeli.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(75, 96, 67);
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(636, 45);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Keluar";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // FormKatalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 234, 209);
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnBeli);
            Controls.Add(rtbDetail);
            Controls.Add(dgvKatalog);
            Controls.Add(cmbKategori);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(lblSambutan);
            Name = "FormKatalog";
            Text = "FormKatalog";
            ((System.ComponentModel.ISupportInitialize)dgvKatalog).EndInit();
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
    }
}