using qlythuquanAdmin.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlythuquanAdmin.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_click(object sender, EventArgs e)
        {
            var user = LoginService.Login(txtAcc.Text, txtPwd.Text);
            if (user != null && user.RoleId == 1)
            {
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
