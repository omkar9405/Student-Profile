using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace studentprofiledesign1
{
    public partial class Login : Form
    {
        public static string SetValueForText1 = "";
       public static string SetValueForText2 = "";
       SqlCommand COMMAND ;
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = ENROLLBOX;
            ENROLLBOX.Focus();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            SetValueForText1 = ENROLLBOX.Text;
             SetValueForText2 = PASSBOX.Text;

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            COMMAND=new SqlCommand("Select * From REGISTRATION_TABLE1 Where ENROLLMENT_NO=@ENROLLMENT_NO and PASSWORD=@PASSWORD", con);
            COMMAND.Parameters.Add("@ENROLLMENT_NO", SqlDbType.VarChar).Value = ENROLLBOX.Text;
            COMMAND.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = PASSBOX.Text;
            SqlDataAdapter sda = new SqlDataAdapter(COMMAND); 

            DataTable dt = new DataTable();
           
            sda.Fill(dt);
            if (dt.Rows.Count ==1)

            {
                this.Hide();
                MYPROFILE ss = new MYPROFILE();
                ss.Show();
            
               
               }
            
            else {

                MessageBox.Show("PLEASE CHECK USERNAME OR PASSWORD!!!");
                ENROLLBOX.Text = "";
                PASSBOX.Text = "";
            
            
            }

            
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMINLOGIN ad = new ADMINLOGIN();
            ad.Show();
        }

        private void regibtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            REGISTRATION RE = new REGISTRATION();
            RE.Show();
            ENROLLBOX.Text = "";
            PASSBOX.Text = "";
       
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

            ENROLLBOX.Text = PASSWORD.SetValueForText1;
            PASSBOX.Text = PASSWORD.SetValueForText2;
       //     ENROLLBOX.Text = "";
        //    PASSBOX.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PASSBOX.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logbtn.Focus();
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ENROLLBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aboutpage AP = new aboutpage();
            AP.Show();
        }
    }
}
