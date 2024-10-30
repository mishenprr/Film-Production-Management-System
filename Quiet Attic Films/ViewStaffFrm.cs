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
    public partial class ViewStaffFrm : Form
    {
        public ViewStaffFrm()
        {
            InitializeComponent();
        }

        private void ViewStaffFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qAFilmsDataSet1.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.qAFilmsDataSet1.Staff);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffFrm obj = new StaffFrm();  
            obj.Show();
            
        }
    }
}
