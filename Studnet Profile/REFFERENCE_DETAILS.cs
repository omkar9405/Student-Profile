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
    public partial class REFFERENCE_DETAILS : Form
    {
        public static string SetValueForText1 = "";
        SqlConnection CON = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public REFFERENCE_DETAILS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            this.Hide();
            certificates CE=new certificates();
            CE.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PARENTS_DETAILS PD = new PARENTS_DETAILS();
            PD.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                CON.Open();
                SqlCommand COMMAND = CON.CreateCommand();
                COMMAND.CommandType = CommandType.Text;
                COMMAND.CommandText = "UPDATE REGISTRATION_TABLE1 SET FRIEND1_NAME='" + textBox1.Text + "',FRIEND1_CLASS='" + comboBox1.Text + "',FRIEND1_COURSE='" + comboBox2.Text + "',FRIEND1_ROLL_NO='" + textBox2.Text + "',FRIEND1_PHONE_NO='" + textBox3.Text + "',FRIEND2_NAME='" + textBox4.Text + "',FRIEND2_CLASS='" + comboBox3.Text + "',FRIEND2_COURSE='" + comboBox4.Text + "',FRIEND2_ROLL_NO='" + textBox5.Text + "',FRIEND2_PHONE_NO='" + textBox6.Text + "' WHERE ENROLLMENT_NO='" + ENROLLBOX.Text + "'";
                COMMAND.ExecuteNonQuery();
                CON.Close();
                MessageBox.Show("SAVED SUCCESSFULLY....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void REFFERENCE_DETAILS_Load(object sender, EventArgs e)
        {
            ENROLLBOX.Text = PARENTS_DETAILS.SetValueForText1;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
