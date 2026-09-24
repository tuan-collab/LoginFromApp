using System;
using System.Windows.Forms;

namespace LoginFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Tick -> hiện mật khẩu, Bỏ tick -> ẩn mật khẩu (*)
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            // TODO: xử lý logic đăng nhập thật (kiểm tra tài khoản trong DB...)
            MessageBox.Show(
                $"Đăng nhập thành công với tài khoản: {txtUsername.Text}",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Kiểm tra không để trống Tên đăng nhập & Mật khẩu, báo lỗi qua ErrorProvider
        private bool ValidateInputs()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Tên đăng nhập không được để trống!");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtUsername, "");
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Mật khẩu không được để trống!");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtPassword, "");
            }

            return isValid;
        }
    }
}