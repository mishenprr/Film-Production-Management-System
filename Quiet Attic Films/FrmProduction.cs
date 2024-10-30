using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quiet_Attic_Films
{
    public partial class FrmProduction : Form
    {
        public FrmProduction()
        {
            InitializeComponent();
        }

        private void FrmProduction_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";
            commandString = "INSERT INTO Production (Pro_Title, Pro_Description, StartDate, EndDate, ClientID) VALUES ('" + txtTitle.Text + "','" + txtDescription.Text + "','" + txtStart.Text + "','" + txtEnd.Text + "', '" + txtClientID.Text + "')";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Stored");
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewProductionFrm obj = new ViewProductionFrm();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString, commandString; 
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";
            commandString = "UPDATE Production SET Pro_Title = '" + txtTitle.Text + "', Pro_Description = '" + txtDescription.Text + "', StartDate = '" + txtStart.Text + "', EndDate = '" + txtEnd.Text + "' WHERE ProID = '" + txtProID.Text + "'";
            if (MessageBox.Show("Are you sure, you want to Update this record?", "Sure?", MessageBoxButtons.YesNo) == DialogResult.No) { return; }

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Updated Succesfully");
            txtProID.Focus();
            conn.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString, commandString; 
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";

            commandString = "DELETE Production FROM Production where Production.ProID = '" + txtProID.Text + "'";
            if (MessageBox.Show("Are you sure, you want to delete this record?", "Sure?", MessageBoxButtons.YesNo) == DialogResult.No) { return; }
            SqlConnection conn = new SqlConnection(connectionString); 
            SqlCommand comm = new SqlCommand(commandString, conn); 
            conn.Open(); 
            comm.ExecuteNonQuery(); 
            MessageBox.Show("Record Deleted Successfully"); 
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard obj = new Dashboard();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";
            commandString = "SELECT * FROM Production WHERE ProID = '"+txtProID.Text+"'";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(commandString, conn);
            SqlDataReader reader = null;

            try
            { conn.Open(); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            reader = cmd.ExecuteReader();

            while (reader.Read()) 
            {
                txtTitle.Text = reader[1].ToString();
                txtDescription.Text = reader[2].ToString();
                txtStart.Text = reader[3].ToString();
                txtEnd.Text = reader[4].ToString(); 
                txtClientID.Text = reader[5].ToString();    
            }
            conn.Close();

        }
    }
}
