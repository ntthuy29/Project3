using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_MPham._Repisitories;
using web_MPham.Models;
using web_MPham.Views;
namespace web_MPham.Presenter
{
    class RegisterPresenter
    {
        private readonly IRegisterView _view;
        private readonly IPetRepository _repo;

        public RegisterPresenter(IRegisterView view, IPetRepository repo)
        {
            _view = view;
            _repo = repo;
            _view.RegisterClicked += OnRegisterClicked;
        }
        private void OnRegisterClicked(object sender, EventArgs e)
        {
            var account = new Accounts
            {
                accountID = _repo.GenerateNextAccount(),
                fullName = _view.fullName,
                phoneNumber = _view.phoneNumber,
                birthday = _view.Birthday,
                address = _view.address,
                Username = _view.username,
                Password = _view.password,
                status = _view.status ? "1" : "0",
                position = "Customer"
            };

            _repo.Register(account);
            _view.ShowMessage("Đăng ký thành công!");
            _view.Close();
        }
    }
}
