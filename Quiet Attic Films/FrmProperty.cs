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
using System.Xml.Linq;

namespace Quiet_Attic_Films
{
    public partial class FrmProperty : Form
    {
        public FrmProperty()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";
            commandString = "INSERT INTO Property (PropertyType,PropertyCost ) VALUES ('" + txtType.Text + "','" + txtCost.Text + "')";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Stored");
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard obj = new Dashboard();
            obj.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionString, commandString; 
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";
            commandString = "UPDATE Property SET PropertyType = '" + txtType.Text + "', PropertyCost = '" + txtCost.Text + "' where PropertyID = '" + txtpropertyID.Text + "'";
            if (MessageBox.Show("Are you sure, you want to Update this record?", "Sure?", MessageBoxButtons.YesNo) == DialogResult.No) { return; }

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Updated Succesfully");
            txtpropertyID.Focus();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";

            commandString = "DELETE Property FROM Property where Property.PropertyID = '" + txtpropertyID.Text + "'";
            if (MessageBox.Show("Are you sure, you want to delete this record?", "Sure?", MessageBoxButtons.YesNo) == DialogResult.No) { return; }
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewPropertyFrm obj = new ViewPropertyFrm();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";
            commandString = "SELECT * FROM Property WHERE PropertyID = '" + txtpropertyID.Text + "'";

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
                txtType.Text = reader[1].ToString();
                txtCost.Text = reader[2].ToString();
            }
            conn.Close();
        }
    }
}
