using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_MPham.Models
{
    class Accounts
    {
        public string accountID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public string phoneNumber { get; set; }
        public string fullName { get; set; }
        public DateTime birthday { get; set; }
        public string status { get; set; }
        public string position { get; set; }
        public string address { get; set; }
        public bool Authenticate(string username, string password)
        {
            // Kiểm tra tài khoản mẫu
            return username == "admin" && password == "password123";
        }
    }
}
