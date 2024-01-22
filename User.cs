using SQLite;

namespace StogaShopping
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public long PaymentInfo { get; set; }
        public string Address { get; set; }
        public string ProfilePhoto { get; set; }
    }
}