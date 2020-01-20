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
    public partial class MYPROFILE : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueFortext3 = "";
        public static string SetValueFortext4 = "";
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public MYPROFILE()
        {
            InitializeComponent();
          //  this.ActiveControl = ENROLLBOX;
           // ENROLLBOX.Focus();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            this.Hide();
            MYPROFILE2 RD = new MYPROFILE2();
            RD.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login li = new Login();
            li.Show();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LI = new Login();
            LI.Show();
        }

        private void MYPROFILE_Load(object sender, EventArgs e)
        {

           
                    try
                    {

                        ENROLLBOX.Text = PASSWORD.SetValueForText1;
                        PASSBOX.Text = PASSWORD.SetValueForText2;
                        ENROLLBOX.Text = MYPROFILE2.SetValueForText1;
                        ENROLLBOX.Text = Login.SetValueForText1;
                        PASSBOX.Text = Login.SetValueForText2;
                       

               SqlDataAdapter SDA = new SqlDataAdapter(@"SELECT * FROM REGISTRATION_TABLE1 WHERE ENROLLMENT_NO='" + ENROLLBOX.Text+ "' AND PASSWORD='" + PASSBOX.Text + "'", conn);
                DataTable DT = new DataTable();
                SDA.Fill(DT);
                ENROLLBOX.Text = DT.Rows[0][1].ToString();
                PASSBOX.Text = DT.Rows[0][2].ToString();
                textBox20.Text = DT.Rows[0][4].ToString();
                textBox21.Text = DT.Rows[0][5].ToString();
                textBox18.Text = DT.Rows[0][6].ToString();
                textBox8.Text = DT.Rows[0][7].ToString();
                textBox17.Text = DT.Rows[0][8].ToString();
                textBox9.Text = DT.Rows[0][9].ToString();
                textBox12.Text = DT.Rows[0][18].ToString();
                textBox6.Text = DT.Rows[0][11].ToString();
                textBox15.Text = DT.Rows[0][10].ToString();
                textBox7.Text = DT.Rows[0][12].ToString();
                textBox16.Text = DT.Rows[0][13].ToString();
                textBox11.Text = DT.Rows[0][14].ToString();
                textBox14.Text = DT.Rows[0][15].ToString();
                textBox13.Text = DT.Rows[0][16].ToString();
                textBox10.Text = DT.Rows[0][17].ToString();
                txtPath.Text = DT.Rows[0][25].ToString();
                picBox1.Image = Image.FromFile(txtPath.Text);
                textBox19.Text = DT.Rows[0][19].ToString();
                textBox1.Text = DT.Rows[0][20].ToString();
                textBox5.Text = DT.Rows[0][21].ToString();
                OCCUPATION.Text = DT.Rows[0][22].ToString();
                textBox3.Text = DT.Rows[0][23].ToString();
                textBox4.Text = DT.Rows[0][24].ToString();
           //     conn.Close();
                    
                
                 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        
    
       

        private void button3_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            this.Hide();
            MYPROFILE4 mp4 = new MYPROFILE4();
            mp4.Show();

        }

        private void OCCUPATION_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            this.Hide();
            MYPROFILE5 mp5 = new MYPROFILE5();
            mp5.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            this.Hide();
            MYPROFILE6 mp6 = new MYPROFILE6();
            mp6.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
               // ENROLLBOX.Text = Login.SetValueForText1;

                //PASSBOX.Text = Login.SetValueForText2;
                //ENROLLBOX.Text = PASSWORD.SetValueForText3;
                //PASSBOX.Text = PASSWORD.SetValueForText4;
                SqlDataAdapter SDA = new SqlDataAdapter(@"SELECT * FROM REGISTRATION_TABLE1 WHERE ENROLLMENT_NO='" + ENROLLBOX.Text + "'AND PASSWORD='"+PASSBOX.Text+"'", conn);
                DataTable DT = new DataTable();
                SDA.Fill(DT);
             /*   textBox20.Text = DT.Rows[0][4].ToString();
                textBox21.Text = DT.Rows[0][5].ToString();
                ENROLLBOX.Text = DT.Rows[0][1].ToString();
                textBox18.Text = DT.Rows[0][6].ToString();
                textBox8.Text = DT.Rows[0][7].ToString();
                PASSBOX.Text = DT.Rows[0][2].ToString();
                textBox17.Text = DT.Rows[0][8].ToString();
                textBox9.Text = DT.Rows[0][9].ToString();
                textBox12.Text = DT.Rows[0][18].ToString();
                textBox6.Text = DT.Rows[0][11].ToString();
                textBox15.Text = DT.Rows[0][10].ToString();
                textBox7.Text = DT.Rows[0][12].ToString();
                textBox16.Text = DT.Rows[0][13].ToString();
                textBox11.Text = DT.Rows[0][14].ToString();
                textBox14.Text = DT.Rows[0][15].ToString();
                textBox13.Text = DT.Rows[0][16].ToString();
                textBox10.Text = DT.Rows[0][17].ToString();
                txtPath.Text = DT.Rows[0][25].ToString();
                picBox1.Image = Image.FromFile(txtPath.Text);
                textBox19.Text = DT.Rows[0][19].ToString();
                textBox1.Text = DT.Rows[0][20].ToString();
                textBox5.Text = DT.Rows[0][21].ToString();
                OCCUPATION.Text = DT.Rows[0][22].ToString();
                textBox3.Text = DT.Rows[0][23].ToString();
                textBox4.Text = DT.Rows[0][24].ToString();
            */
                ENROLLBOX.Text = DT.Rows[0][1].ToString();
                PASSBOX.Text = DT.Rows[0][2].ToString();
                textBox20.Text = DT.Rows[0][4].ToString();
                textBox21.Text = DT.Rows[0][5].ToString();
                textBox18.Text = DT.Rows[0][6].ToString();
                textBox8.Text = DT.Rows[0][7].ToString();
                textBox17.Text = DT.Rows[0][8].ToString();
                textBox9.Text = DT.Rows[0][9].ToString();
                textBox12.Text = DT.Rows[0][18].ToString();
                textBox6.Text = DT.Rows[0][11].ToString();
                textBox15.Text = DT.Rows[0][10].ToString();
                textBox7.Text = DT.Rows[0][12].ToString();
                textBox16.Text = DT.Rows[0][13].ToString();
                textBox11.Text = DT.Rows[0][14].ToString();
                textBox14.Text = DT.Rows[0][15].ToString();
                textBox13.Text = DT.Rows[0][16].ToString();
                textBox10.Text = DT.Rows[0][17].ToString();
                txtPath.Text = DT.Rows[0][25].ToString();
                picBox1.Image = Image.FromFile(txtPath.Text);
                textBox19.Text = DT.Rows[0][19].ToString();
                textBox1.Text = DT.Rows[0][20].ToString();
                textBox5.Text = DT.Rows[0][21].ToString();
                OCCUPATION.Text = DT.Rows[0][22].ToString();
                textBox3.Text = DT.Rows[0][23].ToString();
                textBox4.Text = DT.Rows[0][24].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void picBox1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
           // this.Hide();
            profilephoto PF = new profilephoto();
            PF.Show();
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void ENROLLBOX_TextChanged(object sender, EventArgs e)
        {
            //ENROLLBOX.Text = Login.SetValueForText1;
           // ENROLLBOX.Text = PASSWORD.SetValueForText3;
            
              
        }

        private void PASSBOX_TextChanged(object sender, EventArgs e)
        {
            //PASSBOX.Text = Login.SetValueForText2;
            //PASSBOX.Text = PASSWORD.SetValueForText4;
        }

       
    }
}
