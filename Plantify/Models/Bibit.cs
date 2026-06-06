namespace plantify.Models
{
    public class Bibit
    {
        public int Id { get; set; }
        public string NamaBibit { get; set; }
        public string Kategori { get; set; }
        public string Deskripsi { get; set; }
        public decimal Harga { get; set; }
        public int Stok { get; set; }
        public string Satuan { get; set; }

        public Bibit() { }

        public Bibit(int id, string namaBibit, string kategori, string deskripsi, decimal harga, int stok, string satuan)
        {
            Id = id;
            NamaBibit = namaBibit;
            Kategori = kategori;
            Deskripsi = deskripsi;
            Harga = harga;
            Stok = stok;
            Satuan = satuan;
        }

        public bool TersediaStok()
        {
            return Stok > 0;
        }

        public string FormatHarga()
        {
            return Harga.ToString("C0", new System.Globalization.CultureInfo("id-ID"));
        }
    }
}