using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_MPham.Models;
using web_MPham.Views;
using web_MPham.Properties;
using web_MPham._Repisitories;

namespace web_MPham.Presenter
{
    class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly IPetRepository _account;

        public LoginPresenter(ILoginView view, IPetRepository account)
        {
            _view = view;
            _account = account;

            _view.LoginButtonClicked += OnLoginButtonClicked;
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var username = _view.Username;
            var password = _view.Password;

            if (_account.Login(username, password))
            {
                _view.NavigateToHomePage();
            }
            else
            {
                _view.ShowErrorMessage("Tên đăng nhập hoặc mật khẩu chưa đúng");
            }
        }
    }
}
