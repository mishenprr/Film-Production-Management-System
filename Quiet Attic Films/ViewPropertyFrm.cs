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
    public partial class ViewPropertyFrm : Form
    {
        public ViewPropertyFrm()
        {
            InitializeComponent();
        }

        private void ViewPropertyFrm_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProperty obj = new FrmProperty();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
