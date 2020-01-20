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
    public partial class SEM1 : Form
    {
        public static string SetValueForText1 = "";
        SqlConnection con;
        SqlDataAdapter sda;
        DataTable DT;
        SqlCommand COMMAND;
        public SEM1()
        {
            InitializeComponent();
        }

      

        
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                COMMAND = con.CreateCommand();
                COMMAND.CommandType = CommandType.Text;
                COMMAND.CommandText = "insert into tbRESULT(ENROLLMENT_NO,COURSE,ACADEMIC_YEAR,SUB_1,SUB_2,SUB_3,SUB_4,SUB_5,SUB_6,TOTAL,PERCENTAGE,SESSIONAL,IMAGE) values('" + textBox11.Text + "','" + textBox12.Text + "','" + textBox10.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox7.Text + "','" + txtPath1.Text + "')";
                COMMAND.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("SAVED SUCCESSFULLY....");
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            txtPath1.Text = of.FileName;
            picBox1.Image = Image.FromFile(txtPath1.Text);

        }

        
        private void SEM1_Load(object sender, EventArgs e)
        {
            textBox11.Text = REGISTRATION.SetValueForText1;
            
           }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SetValueForText1 = textBox11.Text;
            this.Hide();
            REGISTRATION RD = new REGISTRATION();
            RD.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
              con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            COMMAND = new SqlCommand("Select * From tbRESULT Where ENROLLMENT_NO=@ENROLLMENT_NO and COURSE=@COURSE", con);
            COMMAND.Parameters.Add("@ENROLLMENT_NO", SqlDbType.VarChar).Value = textBox11.Text;
            COMMAND.Parameters.Add("@COURSE", SqlDbType.VarChar).Value = textBox12.Text;
            sda = new SqlDataAdapter(COMMAND);

            DT = new DataTable();

            sda.Fill(DT);
            if (DT.Rows.Count == 1)
            {

                textBox12.Text = DT.Rows[0][1].ToString();
                textBox1.Text = DT.Rows[0][3].ToString();
                textBox2.Text = DT.Rows[0][4].ToString();
                textBox3.Text = DT.Rows[0][5].ToString();
                textBox4.Text = DT.Rows[0][6].ToString();
                textBox5.Text = DT.Rows[0][7].ToString();
                textBox6.Text = DT.Rows[0][8].ToString();
                textBox7.Text = DT.Rows[0][11].ToString();
                textBox8.Text = DT.Rows[0][9].ToString();
                textBox9.Text = DT.Rows[0][10].ToString();
                textBox10.Text = DT.Rows[0][2].ToString();
                txtPath1.Text = DT.Rows[0][12].ToString();
                picBox1.Image = Image.FromFile(txtPath1.Text);

            }
            else
            {
                MessageBox.Show("please fill results...");
            }
        }

    }
}
