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

namespace Quiet_Attic_Films
{
    public partial class StaffFrm : Form
    {
        public StaffFrm()
        {
            InitializeComponent();
        }

        private void StaffFrm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffType obj = new StaffType();    
            obj.Show(); 

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard obj = new Dashboard();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";
            commandString = "INSERT INTO Staff VALUES ('" + txtstaffname.Text + "','" + txtstaffgender.Text + "','" + txtstaffaddress.Text + "','" + txtstafftele.Text + "' , '" + txtemail.Text + "')";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Stored");
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";
            commandString = "UPDATE Staff SET Staff_Name = '" + txtstaffname.Text + "', Staff_Gender = '" + txtstaffgender.Text + "', Staff_Address = '" + txtstaffaddress.Text + "', Staff_Telephone = '" + txtstafftele.Text + "' , Staff_Email = '" + txtemail.Text + "' where StaffID = '" + txtstaffid.Text + "'";
            if (MessageBox.Show("Are you sure, you want to Update this record?", "Sure?", MessageBoxButtons.YesNo) == DialogResult.No) { return; }

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Updated Succesfully");
            txtstaffid.Focus();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";

            commandString = "DELETE Staff FROM Staff where Staff.StaffID = '" + txtstaffid.Text + "'";
            if (MessageBox.Show("Are you sure, you want to delete this record?", "Sure?", MessageBoxButtons.YesNo) == DialogResult.No) { return; }
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";
            commandString = "SELECT * FROM Staff WHERE StaffID = '" + txtstaffid.Text + "'";
           
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
                txtstaffname.Text = reader[1].ToString();
                txtstaffgender.Text = reader[2].ToString();
                txtstaffaddress.Text = reader[3].ToString();
                txtstafftele.Text = reader[4].ToString();
                txtemail.Text = reader[5].ToString();   
            }
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStaffFrm obj = new ViewStaffFrm();
            obj.Show();
        }
    }
}
