using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using web_MPham.Models;
using web_MPham.Presenter;
using web_MPham.Views;
using web_MPham.Properties;
using web_MPham._Repisitories;

namespace web_MPham
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginView = new LoginView();
            PetRepository accountRepo = new PetRepository("Data Source=LAPTOP-2OB6S4LB;Initial Catalog=CNPM_WebMyPham;Integrated Security=True");

            var loginPresenter = new LoginPresenter(loginView, accountRepo);
            Application.Run(loginView);
        }
    }
}
