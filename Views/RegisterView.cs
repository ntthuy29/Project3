using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using web_MPham._Repisitories;
using web_MPham.Models;
using web_MPham.Presenter;
using web_MPham.Properties;
using web_MPham.Views;

namespace web_MPham.Views
{
    public partial class RegisterView: Form, IRegisterView
    {
        public event EventHandler RegisterClicked;
        public string fullName => txtHVT.Text;
        public string phoneNumber => txtSDT.Text;
        public DateTime Birthday => dtpBirthday.Value;
        public string address => txtDiaChi.Text;
        public string username => txtusername.Text;
        public string password => txtpassword.Text;
        public bool status => ckbKichhoat.Checked;
        public RegisterView()
        {
            InitializeComponent();
            var repo = new PetRepository("Data Source=LAPTOP-2OB6S4LB;Initial Catalog=CNPM_WebMyPham;Integrated Security=True"); // hoặc AccountRepository nếu đúng
            var presenter = new RegisterPresenter(this, repo);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnDKy_Click(object sender, EventArgs e)
        {
            RegisterClicked?.Invoke(sender, e);
        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterView_Load(object sender, EventArgs e)
        {

        }
    }
}
