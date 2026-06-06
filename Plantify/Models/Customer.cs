namespace plantify.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Alamat { get; set; }
        public string NoHp { get; set; }

        public Customer() { }

        public Customer(int id, string nama, string email, string username, string alamat, string noHp)
        {
            Id = id;
            Nama = nama;
            Email = email;
            Username = username;
            Alamat = alamat;
            NoHp = noHp;
        }
    }
}