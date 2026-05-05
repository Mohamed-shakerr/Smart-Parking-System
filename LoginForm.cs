using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Treat placeholder text as empty
            if (username == "Username") username = "";
            if (password == "Password") password = "";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Please enter both username and password.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(username)) txtUsername.Focus();
                else txtPassword.Focus();
                return;
            }

            if (username == "admin" && password == "admin")
            {
                HomeForm home = new HomeForm();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid username or password. Please try again.",
                    "Authentication Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword_ForcePlaceholder();
                txtUsername.Focus();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Password")
            {
                txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
            }
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "Default Credentials\n\nUsername: admin\nPassword: admin\n\nPlease contact the system administrator to change your credentials.",
                "Forgot Password",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.FromArgb(27, 42, 74);
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.FromArgb(150, 150, 150);
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.FromArgb(27, 42, 74);
                txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword_ForcePlaceholder();
            }
        }

        private void txtPassword_ForcePlaceholder()
        {
            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.FromArgb(150, 150, 150);
            txtPassword.PasswordChar = '\0';
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
