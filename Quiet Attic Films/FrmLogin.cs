using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiet_Attic_Films
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if ((username == "Admin") && (password == "1234"))
            {
                this.Hide();
                MessageBox.Show("Login Successful");
                Dashboard obj = new Dashboard();
                obj.Show();
            }
            else if ((username == "User") && (password == "123"))
            {
                this.Hide();
                MessageBox.Show("Login Successful");
                UserDashboard obj = new UserDashboard();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Try Again!");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
