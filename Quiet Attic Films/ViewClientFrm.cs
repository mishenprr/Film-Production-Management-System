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
    public partial class ViewClientFrm : Form
    {
        public ViewClientFrm()
        {
            InitializeComponent();
        }

        private void ViewClientFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qAFilmsDataSet1.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter1.Fill(this.qAFilmsDataSet1.Client);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client obj = new Client();
            obj.Show();
        }
    }
}
