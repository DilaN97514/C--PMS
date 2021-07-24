using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (inputUserId.Text == "Admin" && inputPassword.Text == "admin")
            {
                Home hm = new Home();
                hm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!");
            }
        }
    }
}
