using AutoLogDesktop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            PasswordTextBoxSignIn.PasswordChar = PasswordCheckBoxSignIn.Checked ? '\0' : '*';
        }
    }
}
