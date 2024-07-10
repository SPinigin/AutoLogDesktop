using System;
using System.Windows.Forms;
using AutoLogDesktop.Forms;

namespace AutoLogDesktop
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUpButtonSignIn_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void PasswordCheckBoxSignIn_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordCheckBoxSignIn.Checked)
            {
                PasswordTextBoxSignIn.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordTextBoxSignIn.UseSystemPasswordChar = false;
            }
        }

    }
}
