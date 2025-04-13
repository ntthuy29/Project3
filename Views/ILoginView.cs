using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_MPham.Views
{
    interface ILoginView
    {
        string Username {get;}
        string Password {get;}
        void ShowErrorMessage(string message);
        void NavigateToHomePage();
        void NavigateToRegister();
        event EventHandler LoginButtonClicked;
    }
}
