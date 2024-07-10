using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AutoLogDesktop.Forms
{
    public partial class SignUpForm : Form
    {
        readonly SqlConnection connect = new SqlConnection();

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
                MessageBox.Show("Необходимо заполнить все поля", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                    try
                    {
                        if (PasswordTextBoxSignUp.Text != PasswordConfirmTextBoxSignUp.Text)
                        {
                            MessageBox.Show("Пароли не совпадают", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else 
                        {
                            connect.ConnectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ToString();
                            connect.Open();

                            String checkLogin = "SELECT COUNT(*) FROM UsersOrgs WHERE Login = @Login";

                            using (SqlCommand checkCMD = new SqlCommand(checkLogin, connect))
                            {
                                checkCMD.Parameters.AddWithValue("@Login", LoginTextBoxSignUp.Text.Trim());
                                int count = (int)checkCMD.ExecuteScalar();

                                if (count >= 1)
                                {
                                    MessageBox.Show(LoginTextBoxSignUp.Text.Trim() + " уже существует.", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    String insertData = "INSERT INTO UsersOrgs (OrganizationName, Login, Password)" + "VALUES(@OrganizationName, @Login, @Password)";

                                    using (SqlCommand insertCMD = new SqlCommand(insertData, connect))
                                    {
                                        insertCMD.Parameters.AddWithValue("@OrganizationName", OrganizationTextBoxSignUp.Text.Trim());
                                        insertCMD.Parameters.AddWithValue("@Login", LoginTextBoxSignUp.Text.Trim());
                                        insertCMD.Parameters.AddWithValue("@Password", PasswordTextBoxSignUp.Text.Trim());

                                        insertCMD.ExecuteNonQuery();

                                        MessageBox.Show("Успешная регистрация", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        SignInForm signInForm = new SignInForm();
                                        signInForm.Show();
                                        this.Hide();
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка соединения с базой данных: " + ex, "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
            }
        }

        private void PasswordConfirmCheckBoxSignUp_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBoxSignUp.PasswordChar = PasswordConfirmCheckBoxSignUp.Checked? '\0' : '*';
            PasswordConfirmTextBoxSignUp.PasswordChar = PasswordConfirmCheckBoxSignUp.Checked? '\0' : '*';
        }
    }
}
