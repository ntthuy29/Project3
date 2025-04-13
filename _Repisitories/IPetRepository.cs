using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_MPham.Models;

namespace web_MPham._Repisitories
{
    interface IPetRepository
    {
        bool Login(string username, string password);
        string GenerateNextAccount();
        void Register(Accounts account);
    }
}
