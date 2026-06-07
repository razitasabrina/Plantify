namespace Plantify
{
    partial class UcBibit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbGambar = new PictureBox();
            lblNama = new Label();
            lblKategori = new Label();
            lblStock = new Label();
            lblHarga = new Label();
            ((System.ComponentModel.ISupportInitialize)pbGambar).BeginInit();
            SuspendLayout();
            // 
            // pbGambar
            // 
            pbGambar.Location = new Point(10, 10);
            pbGambar.Name = "pbGambar";
            pbGambar.Size = new Size(90, 59);
            pbGambar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGambar.TabIndex = 0;
            pbGambar.TabStop = false;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(10, 72);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(91, 20);
            lblNama.TabIndex = 1;
            lblNama.Text = "Bibit Tomat";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKategori.Location = new Point(13, 92);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(40, 17);
            lblKategori.TabIndex = 2;
            lblKategori.Text = "Sayur";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(12, 109);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(64, 17);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stock : 20";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(13, 127);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(56, 17);
            lblHarga.TabIndex = 4;
            lblHarga.Text = "Rp5.000";
            // 
            // UcBibit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblHarga);
            Controls.Add(lblStock);
            Controls.Add(lblKategori);
            Controls.Add(lblNama);
            Controls.Add(pbGambar);
            Name = "UcBibit";
            Size = new Size(118, 148);
            ((System.ComponentModel.ISupportInitialize)pbGambar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbGambar;
        private Label lblNama;
        private Label lblKategori;
        private Label lblStock;
        private Label lblHarga;
    }
}
