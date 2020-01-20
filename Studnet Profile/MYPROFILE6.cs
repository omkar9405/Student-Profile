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
    public partial class MYPROFILE6 : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        SqlConnection con;
        SqlCommand COMMAND;
        DataTable DT;
        SqlDataAdapter sda;
        public MYPROFILE6()
        {
            InitializeComponent();
        }

        private void MYPROFILE6_Load(object sender, EventArgs e)
        {
            textBox11.Text = MYPROFILE.SetValueForText1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox11.Text;
            this.Hide();
            MYPROFILE MP = new MYPROFILE();
            MP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            COMMAND = new SqlCommand("Select * From tbRESULT Where ENROLLMENT_NO=@ENROLLMENT_NO and COURSE=@COURSE", con);
            COMMAND.Parameters.Add("@ENROLLMENT_NO", SqlDbType.VarChar).Value = textBox11.Text;
            COMMAND.Parameters.Add("@COURSE", SqlDbType.VarChar).Value = textBox23.Text;
            sda = new SqlDataAdapter(COMMAND);

            DT = new DataTable();

            sda.Fill(DT);
            if (DT.Rows.Count == 1)
            {

                SUB.Text = DT.Rows[0][3].ToString();
                textBox2.Text = DT.Rows[0][4].ToString();
                textBox3.Text = DT.Rows[0][5].ToString();
                textBox4.Text = DT.Rows[0][6].ToString();
                textBox5.Text = DT.Rows[0][7].ToString();
                textBox6.Text = DT.Rows[0][8].ToString();
                textBox7.Text = DT.Rows[0][11].ToString();
                textBox8.Text = DT.Rows[0][9].ToString();
                textBox9.Text = DT.Rows[0][10].ToString();
                textBox12.Text = DT.Rows[0][2].ToString();
                txtPath1.Text = DT.Rows[0][12].ToString();
                picBox1.Image = Image.FromFile(txtPath1.Text);

            }
            else
            {
                MessageBox.Show("PLEASE FILL RESULTS....");
            }
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            COMMAND = new SqlCommand("Select * From tbRESULT Where ENROLLMENT_NO=@ENROLLMENT_NO and COURSE=@COURSE", con);
            COMMAND.Parameters.Add("@ENROLLMENT_NO", SqlDbType.VarChar).Value = textBox11.Text;
            COMMAND.Parameters.Add("@COURSE", SqlDbType.VarChar).Value = textBox22.Text;
            sda = new SqlDataAdapter(COMMAND);

            DT = new DataTable();

            sda.Fill(DT);
            if (DT.Rows.Count == 1)
            {

                textBox13.Text = DT.Rows[0][3].ToString();
                textBox21.Text = DT.Rows[0][4].ToString();
                textBox20.Text = DT.Rows[0][5].ToString();
                textBox19.Text = DT.Rows[0][6].ToString();
                textBox18.Text = DT.Rows[0][7].ToString();
                textBox17.Text = DT.Rows[0][8].ToString();
                textBox15.Text = DT.Rows[0][11].ToString();
                textBox14.Text = DT.Rows[0][9].ToString();
                textBox16.Text = DT.Rows[0][10].ToString();
                textBox10.Text = DT.Rows[0][2].ToString();
                txtPath2.Text = DT.Rows[0][12].ToString();
                pictureBox1.Image = Image.FromFile(txtPath2.Text);

            }
            else
            {
                MessageBox.Show("PLEASE FILL RESULTS....");
            }
            
        }

        private void picBox1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox11.Text;
            SetValueForText2 = textBox23.Text;
            SHOWRESULT4 sf2 = new SHOWRESULT4();
            sf2.Show();
       
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox11.Text;
            SetValueForText2 = textBox22.Text;
            SHOWRESULT4 sf2 = new SHOWRESULT4();
            sf2.Show();
       
        }
    }
}
