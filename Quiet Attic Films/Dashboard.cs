﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Quiet_Attic_Films
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProduction obj = new FrmProduction();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client obj = new Client();
            obj.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLocation obj = new FrmLocation();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProperty obj = new FrmProperty();
            obj.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment obj = new Payment();
            obj.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffFrm obj = new StaffFrm();
            obj.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
