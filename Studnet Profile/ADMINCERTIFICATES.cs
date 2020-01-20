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
    public partial class ADMINCERTIFICATES : Form
    {
        SqlCommand CMD = new SqlCommand();
        SqlConnection CON = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
       
        public ADMINCERTIFICATES()
        {
            InitializeComponent();
        }

        private void ADMINCERTIFICATES_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet5.DOCUMENTS' table. You can move, or remove it, as needed.
            this.dOCUMENTSTableAdapter.Fill(this.dataDataSet5.DOCUMENTS);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM DOCUMENTS WHERE ENROLLMENT_NO='" + textBox1.Text + "'", CON);
                DataTable DT = new DataTable();
                SDA.Fill(DT);
                dataGridView1.DataSource = DT;
                MessageBox.Show("SHOW SUCCESSFULLY....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CON.Open();
                SqlCommand CMD = CON.CreateCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = " Select ENROLLMENT_NO,CERTIFICATE_NO,NAME_OF_EVENT,NAME_OF_COLLEGE,UPLOAD from DOCUMENTS";

                CMD.ExecuteNonQuery();
                DataTable DT = new DataTable();
                SqlDataAdapter SDA = new SqlDataAdapter(CMD);
                SDA.Fill(DT);
                dataGridView1.DataSource = DT;
                CON.Close();
                MessageBox.Show("SHOW SUCCESSFULLY....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ADD = new admin();
            ADD.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LG = new Login();
            LG.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           // this.Hide();
            printDocument1.Print();
           
        }
    }
}
