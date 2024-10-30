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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProduction obj = new FrmProduction();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client obj = new Client();
            obj.Show();
        }

        private void btnlocation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLocation obj = new FrmLocation();
            obj.Show();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProperty obj = new FrmProperty();
            obj.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffFrm obj = new StaffFrm();
            obj.Show();
        }
    }
}
