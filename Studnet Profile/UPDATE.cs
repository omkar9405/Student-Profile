using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace studentprofiledesign1
{
    public partial class ADMINLOGIN : Form
    {
        public ADMINLOGIN()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
            textBox1.Focus();
        }

        private void UPDATE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="OMKARPOWAR" && textBox2.Text == "OMKAR123" )
            {
                this.Hide();
                admin AD = new admin();
                AD.Show();

            }
            else
            {
                MessageBox.Show("Please check your USERNAME. and PASSWORD!!");
                textBox1.Text = " ";
                textBox2.Text = " ";

            }

        }    
        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login LG = new Login();
            LG.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
