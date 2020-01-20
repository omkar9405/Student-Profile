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
    public partial class MYPROFILE2 : Form
    {
        public static string SetValueForText1 = "";
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public MYPROFILE2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox7.Text;
            this.Close();
            REGISTRATION RG = new REGISTRATION();
            RG.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LI = new Login();
            LI.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox7.Text;
            this.Hide();
            MYPROFILE MP = new MYPROFILE();
            MP.Show();
        }

        private void MYPROFILE2_Load(object sender, EventArgs e)
        {
            try{
            textBox7.Text =MYPROFILE.SetValueForText1;
            SqlDataAdapter SDA = new SqlDataAdapter(@"SELECT * FROM REGISTRATION_TABLE1 WHERE ENROLLMENT_NO='" + textBox7.Text + "'", conn);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            textBox1.Text = DT.Rows[0][26].ToString();
            textBox8.Text = DT.Rows[0][27].ToString();
            textBox9.Text = DT.Rows[0][28].ToString();
            textBox2.Text = DT.Rows[0][29].ToString();
            textBox3.Text = DT.Rows[0][30].ToString();
            textBox6.Text = DT.Rows[0][31].ToString();
            textBox10.Text = DT.Rows[0][32].ToString();
            textBox11.Text = DT.Rows[0][33].ToString();
            textBox4.Text = DT.Rows[0][34].ToString();
            textBox5.Text = DT.Rows[0][35].ToString();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox7.Text;
            this.Hide();
            MYPROFILE3 MP3 = new MYPROFILE3();
            MP3.Show();
        }
    }
}
