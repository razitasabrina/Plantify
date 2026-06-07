using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plantify
{
    public partial class UcBibit : UserControl
    {
        public UcBibit()
        {
            InitializeComponent();

            pbGambar.Click += SemuaKlik;
            lblNama.Click += SemuaKlik;
            lblKategori.Click += SemuaKlik;
            lblStock.Click += SemuaKlik;
            lblHarga.Click += SemuaKlik;
        }
        private void SemuaKlik(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
