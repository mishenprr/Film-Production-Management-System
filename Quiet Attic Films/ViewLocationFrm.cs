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
    public partial class ViewLocationFrm : Form
    {
        public ViewLocationFrm()
        {
            InitializeComponent();
        }

        private void ViewLocationFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qAFilmsDataSet1.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter1.Fill(this.qAFilmsDataSet1.Location);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLocation obj = new FrmLocation();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
