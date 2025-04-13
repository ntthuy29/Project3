using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_MPham.Views
{
    interface IRegisterView
    {
        string fullName { get; }
        string phoneNumber { get; }
        DateTime Birthday { get; }
        string address { get; }
        string username { get; }
        string password { get; }
        bool status { get; }
        void ShowMessage(string mesage);
        void Close();
        event EventHandler RegisterClicked;
    }
}
