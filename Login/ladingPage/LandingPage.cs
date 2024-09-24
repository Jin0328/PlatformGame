using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class LandingPage : Form
    {
        private Login loginForm;
        public LandingPage(Login login, string username)
        {
            InitializeComponent();

            loginForm = login;
            lblName.Text = username;
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {

        }

        private void LadingPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm.resetUser();
            loginForm.resetPassword();
            loginForm.reset_wrongUser();
            loginForm.reset_wrongPassword();
            this.Hide();
            loginForm.Show();

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
