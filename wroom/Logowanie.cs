using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wroom
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

           public bool logged = false;

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            if (login == "admin" && password == "admin")
            {
                logged = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane logowania!");
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void tbPassword_TextChanged_1(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
