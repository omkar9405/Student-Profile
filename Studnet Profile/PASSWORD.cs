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
    public partial class PASSWORD : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        SqlConnection CON = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public PASSWORD()
        {
            InitializeComponent();
            this.ActiveControl = ENROLLBOX;
            ENROLLBOX.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SetValueForText1 = ENROLLBOX.Text;
           // SetValueForText2 = textBox3.Text;

            try
            {
                if (textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("please check password!!!");
                }
                else
                {
                    CON.Open();
                    SqlCommand COMMAND = CON.CreateCommand();
                    COMMAND.CommandType = CommandType.Text;
                    COMMAND.CommandText = "UPDATE REGISTRATION_TABLE1 SET PASSWORD='" + textBox2.Text + "',CONFIRM_PASSWORD='" + textBox3.Text + "' WHERE ENROLLMENT_NO='" + ENROLLBOX.Text + "'";

                    COMMAND.ExecuteNonQuery();
                    CON.Close();
                    MessageBox.Show("SAVED SUCCESSFULLY....");

                    this.Hide();
                    Login MP = new Login();
                    MP.Show();
                 
      
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LG = new Login();
            LG.Show();
        }

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text )
            {
               
                button1.ForeColor = Color.Green;
                button1.Text = "save";
            }
            else 
            {
                button1.ForeColor = Color.Red;
                button1.Text = "wrong password!!!";
 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            
            this.Hide();
            certificates  CT = new certificates();
            CT.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
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
                textBox2.Focus();
            }

        }

        private void PASSWORD_Load(object sender, EventArgs e)
        {
            ENROLLBOX.Text = certificates.SetValueForText1;
          
           // SqlDataAdapter SDA = new SqlDataAdapter(@"SELECT * FROM REGISTRATION_TABLE1 WHERE ENROLLMENT_NO='" + ENROLLBOX.Text + "'", CON);
           // DataTable DT = new DataTable();
            //SDA.Fill(DT);
            //textBox3.Text = DT.Rows[0][1].ToString();
            //textBox2.Text = DT.Rows[0][2].ToString();
           
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
