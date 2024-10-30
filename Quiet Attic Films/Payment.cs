using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiet_Attic_Films
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard obj = new Dashboard();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";
            commandString = "SELECT * FROM Payment WHERE PaymentID = '" + txtpaymentid.Text + "'";

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
                txttype.Text = reader[1].ToString();
                txtamount.Text = reader[2].ToString();
                txtpaiddate.Text = reader[3].ToString();
                txtenddate.Text = reader[4].ToString();
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";
            commandString = "INSERT INTO Payment VALUES ('" + txttype.Text + "','" + txtamount.Text + "','" + txtpaiddate.Text + "','" + txtenddate.Text + "')";

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
            commandString = "UPDATE Payment SET PaymentType = '" + txttype.Text + "', PaymentAmount = '" + txtamount.Text + "', PaymentPaid = '" + txtpaiddate.Text + "', PaymentEnd = '" + txtenddate.Text + "' where PaymentID = '" + txtpaymentid.Text + "'";
            if (MessageBox.Show("Are you sure, you want to Update this record?", "Sure?", MessageBoxButtons.YesNo) == DialogResult.No) { return; }

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Updated Succesfully");
            txtpaymentid.Focus();
            conn.Close();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=QAFilms;Integrated Security=True";

            commandString = "DELETE Production FROM Payment where Payment.PaymentID = '" + txtpaymentid.Text + "'";
            if (MessageBox.Show("Are you sure, you want to delete this record?", "Sure?", MessageBoxButtons.YesNo) == DialogResult.No) { return; }
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");
            conn.Close();
        }
    }
}
