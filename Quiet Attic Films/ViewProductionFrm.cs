using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quiet_Attic_Films
{
    public partial class ViewProductionFrm : Form
    {
        public ViewProductionFrm()
        {
            InitializeComponent();
        }

        private void ViewProductionFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qAFilmsDataSet1.Production' table. You can move, or remove it, as needed.
            this.productionTableAdapter.Fill(this.qAFilmsDataSet1.Production);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection ("Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * Production", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();    

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProduction obj = new FrmProduction();
            obj.Show();
        }
    }
}
