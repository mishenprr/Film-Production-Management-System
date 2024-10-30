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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";
            commandString = "INSERT INTO Client VALUES ('" + txtclientname.Text + "' , '" + txtfname.Text + "','" + txtsecondname.Text + "','" + txtcompanyno.Text + "','" + txtstreet.Text + "','" + txtcity.Text + "','" + txtemail.Text + "','" + txtphone.Text + "')";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Stored");
            conn.Close();
        }

        private void txtclientname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtclient_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard obj = new Dashboard();
            obj.Show();
        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString, commandString; 
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";
            commandString = "UPDATE Client SET ClientName = '" + txtclient.Text + "', FirstName = '" + txtfname.Text + "', LastName = '" + txtsecondname.Text + "', CompanyNo = '" + txtcompanyno.Text + "', Street = '" + txtstreet.Text + "', Email = '" + txtemail.Text + "', Phone = '" + txtphone.Text + "' where ClientID = '" + txtclient.Text + "'";
            if (MessageBox.Show("Are you sure, you want to Update this record?", "Sure?", MessageBoxButtons.YesNo) == DialogResult.No) { return; }

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Updated Succesfully");
            txtclient.Focus();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString, commandString; 
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";
            commandString = "DELETE Client FROM Client where Client.ClientID = '" + txtclient.Text + "'";

            if (MessageBox.Show("Are you sure, you want to delete this record?", "Sure?", MessageBoxButtons.YesNo) == DialogResult.No) { return; }
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");
            conn.Close();
            txtclient.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewClientFrm obj = new ViewClientFrm();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";
            commandString = "SELECT * FROM Client WHERE ClientID = '" + txtclient.Text + "'";

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
                txtclientname.Text = reader[1].ToString();
                txtfname.Text = reader[2].ToString();
                txtsecondname.Text = reader[3].ToString();
                txtcompanyno.Text = reader[4].ToString();
                txtstreet.Text = reader[5].ToString();
                txtcity.Text = reader[6].ToString();        
                txtemail.Text = reader[7].ToString();   
                txtphone.Text = reader[8].ToString();   
            }
            conn.Close();
        }
    }
}
