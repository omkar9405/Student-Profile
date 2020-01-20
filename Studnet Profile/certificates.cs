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
    public partial class certificates : Form
    {
        public static string SetValueForText1 = "";
        SqlConnection CON = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public certificates()
        {
            InitializeComponent();
            this.ActiveControl = textBox12;
            textBox12.Focus();
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            textBox32.Text = of.FileName;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            textBox31.Text = of.FileName;
          }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            textBox28.Text = of.FileName;
          }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            textBox29.Text = of.FileName;
          }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            textBox30.Text = of.FileName;
         }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            textBox25.Text = of.FileName;
         }

        
        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LG = new Login();
            LG.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            this.Hide();
            PASSWORD PS=new PASSWORD();
            PS.Show();

        }

        
        private void certificates_Load(object sender, EventArgs e)
        {
            ENROLLBOX.Text = REFFERENCE_DETAILS.SetValueForText1;
            /*try
            {
                
                SqlDataAdapter SDA = new SqlDataAdapter(@"SELECT * FROM DOCUMENTS WHERE ENROLLMENT_NO='" + ENROLLBOX.Text + "'", CON);
                DataTable DT = new DataTable();
                SDA.Fill(DT);
                textBox12.Text = DT.Rows[0][1].ToString();
                textBox7.Text = DT.Rows[1][1].ToString();
                textBox3.Text = DT.Rows[2][1].ToString();
                textBox13.Text = DT.Rows[3][1].ToString();
                textBox17.Text = DT.Rows[4][1].ToString();
                textBox6.Text = DT.Rows[5][1].ToString();

                textBox15.Text = DT.Rows[0][2].ToString();
                textBox18.Text = DT.Rows[1][2].ToString();
                textBox21.Text = DT.Rows[2][2].ToString();
                textBox20.Text = DT.Rows[3][2].ToString();
                textBox19.Text = DT.Rows[4][2].ToString();
                textBox24.Text = DT.Rows[5][2].ToString();

                textBox32.Text = DT.Rows[0][3].ToString();
                textBox31.Text = DT.Rows[1][3].ToString();
                textBox28.Text = DT.Rows[2][3].ToString();
                textBox29.Text = DT.Rows[3][3].ToString();
                textBox30.Text = DT.Rows[4][3].ToString();
                textBox25.Text = DT.Rows[5][3].ToString();

            }
            
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
       */
            

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
          
            try{
            CON.Open();
            SqlCommand COMMAND = CON.CreateCommand();
            COMMAND.CommandType = CommandType.Text;
            COMMAND.CommandText = "INSERT INTO DOCUMENTS(CERTIFICATE_NO,NAME_OF_EVENT,NAME_OF_COLLEGE,UPLOAD,ENROLLMENT_NO) VALUES('" + textBox1.Text + "','" + textBox12.Text + "','" + textBox15.Text + "','" + textBox32.Text + "','" + ENROLLBOX.Text + "')";
            COMMAND.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("SAVED 1st CERTIFICATES....");
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            finally
            {
                if (CON.State == ConnectionState.Open)
                {
                    CON.Close();

                }
            }

           
       
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try{
            CON.Open();
            SqlCommand COMMAND = CON.CreateCommand();
            COMMAND.CommandType = CommandType.Text;
            COMMAND.CommandText = "INSERT INTO DOCUMENTS(CERTIFICATE_NO,NAME_OF_EVENT,NAME_OF_COLLEGE,UPLOAD,ENROLLMENT_NO) VALUES('" + textBox2.Text + "','" + textBox7.Text + "','" + textBox18.Text + "','" + textBox31.Text + "','" + ENROLLBOX.Text + "')";
            COMMAND.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("SAVED 2nd CERTIFICATES....");
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            finally
            {
                if (CON.State == ConnectionState.Open)
                {
                    CON.Close();

                }
            }

       
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try{
            CON.Open();
            SqlCommand COMMAND = CON.CreateCommand();
            COMMAND.CommandType = CommandType.Text;
            COMMAND.CommandText = "INSERT INTO DOCUMENTS(CERTIFICATE_NO,NAME_OF_EVENT,NAME_OF_COLLEGE,UPLOAD,ENROLLMENT_NO) VALUES('" + textBox4.Text + "','" + textBox3.Text + "','" + textBox21.Text + "','" + textBox28.Text + "','" + ENROLLBOX.Text + "')";
            COMMAND.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("SAVED 3rd CERTIFICATES....");
             }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            finally
            {
                if (CON.State == ConnectionState.Open)
                {
                    CON.Close();

                }
            }

       
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            try{
            CON.Open();
            SqlCommand COMMAND = CON.CreateCommand();
            COMMAND.CommandType = CommandType.Text;
            COMMAND.CommandText = "INSERT INTO DOCUMENTS(CERTIFICATE_NO,NAME_OF_EVENT,NAME_OF_COLLEGE,UPLOAD,ENROLLMENT_NO) VALUES('" + textBox5.Text + "','" + textBox13.Text + "','" + textBox20.Text + "','" + textBox29.Text + "','" + ENROLLBOX.Text + "')";
            COMMAND.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("SAVED 4th CERTIFICATES....");
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            finally
            {
                if (CON.State == ConnectionState.Open)
                {
                    CON.Close();

                }
            }

       
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            try{
            CON.Open();
            SqlCommand COMMAND = CON.CreateCommand();
            COMMAND.CommandType = CommandType.Text;
            COMMAND.CommandText = "INSERT INTO DOCUMENTS(CERTIFICATE_NO,NAME_OF_EVENT,NAME_OF_COLLEGE,UPLOAD,ENROLLMENT_NO) VALUES('" + textBox8.Text + "','" + textBox17.Text + "','" + textBox19.Text + "','" + textBox30.Text + "','" + ENROLLBOX.Text + "')";
            COMMAND.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("SAVED 5th CERTIFICATES....");
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            finally
            {
                if (CON.State == ConnectionState.Open)
                {
                    CON.Close();

                }
            }

       
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            try{
            CON.Open();
            SqlCommand COMMAND = CON.CreateCommand();
            COMMAND.CommandType = CommandType.Text;
            COMMAND.CommandText = "INSERT INTO DOCUMENTS(CERTIFICATE_NO,NAME_OF_EVENT,NAME_OF_COLLEGE,UPLOAD,ENROLLMENT_NO) VALUES('" + textBox10.Text + "','" + textBox6.Text + "','" + textBox24.Text + "','" + textBox25.Text + "','" + ENROLLBOX.Text + "')";
            COMMAND.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("SAVED 6tH CERTIFICATES....");
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            finally
            {
                if (CON.State == ConnectionState.Open)
                {
                    CON.Close();

                }
            }

       
            }


        private void button13_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            this.Hide();
            REFFERENCE_DETAILS RF = new REFFERENCE_DETAILS();
            RF.Show();
        }

        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox15.Focus();
            }

        }

        private void textBox15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox7.Focus();
            }

        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox18.Focus();
            }

        }

        private void textBox18_KeyDown(object sender, KeyEventArgs e)
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
                textBox21.Focus();
            }

        }

        private void textBox21_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox13.Focus();
            }

        }

        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox20.Focus();
            }

        }

        private void textBox20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox17.Focus();
            }

        }

        private void textBox17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox19.Focus();
            }

        }

        private void textBox19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox6.Focus();
            }

        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox24.Focus();
            }

        }

        private void textBox24_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox12.Focus();
            }

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
