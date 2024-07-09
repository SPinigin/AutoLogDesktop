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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            LoadingPanel.Width += 15;
            if (LoadingPanel.Width >= 600)
            {
                LoadingTimer.Stop();

                SignInForm loginForm = new SignInForm();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
