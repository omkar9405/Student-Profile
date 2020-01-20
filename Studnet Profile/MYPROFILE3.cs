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
    public partial class MYPROFILE3 : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";

        SqlCommand COMMAND;
        DataTable DT;
        SqlDataAdapter sda;
        SqlConnection conn;
        public MYPROFILE3()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            MYPROFILE2 MP2 = new MYPROFILE2();
            MP2.Show();
        }

        private void MYPROFILE3_Load(object sender, EventArgs e)
        {
            ENROLLBOX.Text = MYPROFILE2.SetValueForText1;
            try
            {

                conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                COMMAND = new SqlCommand("Select * From DOCUMENTS Where ENROLLMENT_NO=@ENROLLMENT_NO and CERTIFICATE_NO=@NO", conn);
                COMMAND.Parameters.Add("@ENROLLMENT_NO", SqlDbType.VarChar).Value = ENROLLBOX.Text;
                COMMAND.Parameters.Add("@NO", SqlDbType.VarChar).Value = textBox1.Text;
                sda = new SqlDataAdapter(COMMAND);
                DT = new DataTable();
                sda.Fill(DT);
                if (DT.Rows.Count == 1)
                {
                    textBox12.Text = DT.Rows[0][1].ToString();
                    textBox15.Text = DT.Rows[0][2].ToString();
                    textBox32.Text = DT.Rows[0][3].ToString();
                    pictureBox1.Image = Image.FromFile(textBox32.Text);

                }
                else
                {
                    // MessageBox.Show("PLEASE FILL RECORDS...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

            try{
                conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                COMMAND = new SqlCommand("Select * From DOCUMENTS Where ENROLLMENT_NO=@ENROLLMENT_NO and CERTIFICATE_NO=@NO", conn);
                COMMAND.Parameters.Add("@ENROLLMENT_NO", SqlDbType.VarChar).Value = ENROLLBOX.Text;
                COMMAND.Parameters.Add("@NO", SqlDbType.VarChar).Value = textBox5.Text;
                sda = new SqlDataAdapter(COMMAND);
                DT = new DataTable();
                sda.Fill(DT);
                if (DT.Rows.Count == 1)
                {
                    textBox4.Text = DT.Rows[0][1].ToString();
                    textBox3.Text = DT.Rows[0][2].ToString();
                    textBox2.Text = DT.Rows[0][3].ToString();
                    pictureBox2.Image = Image.FromFile(textBox2.Text);

                   
                }
                else
                {
                    // MessageBox.Show("PLEASE FILL RECORDS...");
                }
            }
                 catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try{
          
                conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                COMMAND = new SqlCommand("Select * From DOCUMENTS Where ENROLLMENT_NO=@ENROLLMENT_NO and CERTIFICATE_NO=@NO", conn);
                COMMAND.Parameters.Add("@ENROLLMENT_NO", SqlDbType.VarChar).Value = ENROLLBOX.Text;
                COMMAND.Parameters.Add("@NO", SqlDbType.VarChar).Value = textBox9.Text;
                sda = new SqlDataAdapter(COMMAND);
                DT = new DataTable();
                sda.Fill(DT);
                if (DT.Rows.Count == 1)
                {
                    textBox13.Text = DT.Rows[0][1].ToString();
                    textBox11.Text = DT.Rows[0][2].ToString();
                    textBox10.Text = DT.Rows[0][3].ToString();
                    pictureBox4.Image = Image.FromFile(textBox10.Text);

                }
                else
                {
                    //MessageBox.Show("PLEASE FILL RECORDS..."); 
                   

                }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               
             try{
                conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                COMMAND = new SqlCommand("Select * From DOCUMENTS Where ENROLLMENT_NO=@ENROLLMENT_NO and CERTIFICATE_NO=@NO", conn);
                COMMAND.Parameters.Add("@ENROLLMENT_NO", SqlDbType.VarChar).Value = ENROLLBOX.Text;
                COMMAND.Parameters.Add("@NO", SqlDbType.VarChar).Value = textBox23.Text;
                sda = new SqlDataAdapter(COMMAND);
                DT = new DataTable();
                sda.Fill(DT);
                if (DT.Rows.Count == 1)
                {
                    textBox22.Text = DT.Rows[0][1].ToString();
                    textBox21.Text = DT.Rows[0][2].ToString();
                    textBox20.Text = DT.Rows[0][3].ToString();
                    pictureBox6.Image = Image.FromFile(textBox20.Text);

                    
                }
                else
                {
                    // MessageBox.Show("PLEASE FILL RECORDS...");
                    

                }
             }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try{
          
                conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                COMMAND = new SqlCommand("Select * From DOCUMENTS Where ENROLLMENT_NO=@ENROLLMENT_NO and CERTIFICATE_NO=@NO", conn);
                COMMAND.Parameters.Add("@ENROLLMENT_NO", SqlDbType.VarChar).Value = ENROLLBOX.Text;
                COMMAND.Parameters.Add("@NO", SqlDbType.VarChar).Value = textBox19.Text;
                sda = new SqlDataAdapter(COMMAND);
                DT = new DataTable();
                sda.Fill(DT);
                if (DT.Rows.Count == 1)
                {
                    textBox18.Text = DT.Rows[0][1].ToString();
                    textBox17.Text = DT.Rows[0][2].ToString();
                    textBox16.Text = DT.Rows[0][3].ToString();
                    pictureBox5.Image = Image.FromFile(textBox16.Text);

   
                }
                else
                {
                    // MessageBox.Show("PLEASE FILL RECORDS...");
                 
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
             try{
                 conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                COMMAND = new SqlCommand("Select * From DOCUMENTS Where ENROLLMENT_NO=@ENROLLMENT_NO and CERTIFICATE_NO=@NO", conn);
                COMMAND.Parameters.Add("@ENROLLMENT_NO", SqlDbType.VarChar).Value = ENROLLBOX.Text;
                COMMAND.Parameters.Add("@NO", SqlDbType.VarChar).Value = textBox19.Text;
                sda = new SqlDataAdapter(COMMAND);
                DT = new DataTable();
                sda.Fill(DT);
                if (DT.Rows.Count == 1)
                {

                    textBox8.Text = DT.Rows[0][1].ToString();
                    textBox7.Text = DT.Rows[0][2].ToString();
                    textBox6.Text = DT.Rows[0][3].ToString();
                    pictureBox3.Image = Image.FromFile(textBox6.Text);



                }
                else
                {
                    // MessageBox.Show("PLEASE FILL RECORDS...");
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
          
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LG = new Login();
            LG.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            SetValueForText2 = textBox1.Text;
           CERTIFICATE1  sr = new CERTIFICATE1();
            sr.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            SetValueForText2 = textBox5.Text;
            CERTIFICATE1 sr = new CERTIFICATE1();
            sr.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            SetValueForText2 = textBox9.Text;
            CERTIFICATE1 sr = new CERTIFICATE1();
            sr.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            SetValueForText2 = textBox23.Text;
            CERTIFICATE1 sr = new CERTIFICATE1();
            sr.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            SetValueForText2 = textBox19.Text;
            CERTIFICATE1 sr = new CERTIFICATE1();
            sr.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            SetValueForText2 = textBox14.Text;
            CERTIFICATE1 sr = new CERTIFICATE1();
            sr.Show();
        }
    }
}
