using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web_MPham.Views
{
    public partial class LoginView : Form, ILoginView
    {
        public event EventHandler LoginButtonClicked;
        public string Username => textBox1.Text;
        public string Password => textBox2.Text;
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginButtonClicked.Invoke(sender, e);
        }
        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void NavigateToHomePage()
        {
            MessageBox.Show("Đăng nhập thành công!");
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            NavigateToRegister();
        }
        public void NavigateToRegister()
        {
            var Register = new RegisterView();
            Register.Show();
            this.Hide();
        }
    }
}
