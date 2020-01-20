using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace studentprofiledesign1
{
    public partial class PARENTS_DETAILS : Form
    {
        public static string SetValueForText1 = "";
        SqlConnection CON = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand COMMAND;
        
        public PARENTS_DETAILS()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
            textBox1.Focus();
        }
        
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            REFFERENCE_DETAILS rd = new REFFERENCE_DETAILS();
            rd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            SetValueForText1 = ENROLLTXT.Text;
            this.Hide();
            REGISTRATION RG = new REGISTRATION();
            RG.Show();

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try{
            CON.Open();
            COMMAND = CON.CreateCommand();
            COMMAND.CommandType = CommandType.Text;
            COMMAND.CommandText = "UPDATE REGISTRATION_TABLE1 SET FATHER_NAME='" + textBox1.Text + "',MOTHER_NAME='" + textBox2.Text + "',OCCUPATION='" + textBox3.Text + "',PHONE_NO2='" + textBox4.Text + "',OFFICE='" + textBox5.Text + "',PERMANENT_ADDRESS='" + textBox6.Text + "' WHERE ENROLLMENT_NO='" + ENROLLTXT.Text + "'";
            COMMAND.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("SAVED SUCCESSFULLY....");
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
       
            }

        private void PARENTS_DETAILS_Load(object sender, EventArgs e)
        {
            ENROLLTXT.Text = REGISTRATION.SetValueForText1;
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
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox6.Focus();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLTXT.Text;
            this.Hide();
            REFFERENCE_DETAILS rd = new REFFERENCE_DETAILS();
            rd.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
    
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
    
        }

       
       
        
     }
}