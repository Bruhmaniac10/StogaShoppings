using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StogaShopping
{
    public class User
    {

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<String> PaymentInfo { get; set; }
        public List<String> Addresses { get; set; }
        public string ProfilePhoto { get; set; }


        public void Done() { }
    }
}
