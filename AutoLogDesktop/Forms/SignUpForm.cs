using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AutoLogDesktop.Forms
{
    public partial class SignUpForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=MAGICBOOKPROSPI\\SQLEXPRESS;Database=SibSoftAppDb;Trusted_Connection=True;Connect Timeout=30");

        public SignUpForm()
        {
            InitializeComponent();
        }


        private void CloseLabel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SignInForm singInForm = new SignInForm();
            singInForm.Show();
            this.Hide();
        }

        private void SignUpButtonSignUp_Click(object sender, EventArgs e)
        {
            if (OrganizationTextBoxSignUp.Text == "" || LoginTextBoxSignUp.Text == "" || PasswordTextBoxSignUp.Text == "" || PasswordConfirmTextBoxSignUp.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                    try
                    {
                        connect.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка соединения с базой данных: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }
    }
}
