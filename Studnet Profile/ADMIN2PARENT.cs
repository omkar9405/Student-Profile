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
    public partial class ADMIN2PARENT : Form
    {
        SqlDataAdapter SDA = new SqlDataAdapter();
        SqlCommand CMD = new SqlCommand();
        SqlConnection CON = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public ADMIN2PARENT()
        {
            InitializeComponent();
        }

        private void ADMIN2PARENT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet4.REGISTRATION_TABLE1' table. You can move, or remove it, as needed.
            this.rEGISTRATION_TABLE1TableAdapter.Fill(this.dataDataSet4.REGISTRATION_TABLE1);
            // TODO: This line of code loads data into the 'dataDataSet1.REGISTRATION_TABLE' table. You can move, or remove it, as needed.
            //this.rEGISTRATION_TABLETableAdapter.Fill(this.dataDataSet1.REGISTRATION_TABLE);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin AD = new admin();
            AD.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login LI = new Login();
            LI.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CON.Open();
                SqlCommand CMD = CON.CreateCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = " Select ENROLLMENT_NO,DEPARTMENT,NAME,FATHER_NAME,MOTHER_NAME,OCCUPATION,PERMANENT_ADDRESS,PHONE_NO2,OFFICE from REGISTRATION_TABLE1";

                CMD.ExecuteNonQuery();
                DataTable DT = new DataTable();
                SqlDataAdapter SDA = new SqlDataAdapter(CMD);
                SDA.Fill(DT);
                dataGridView2.DataSource = DT;
                CON.Close();
                MessageBox.Show("SHOW SUCCESSFULLY....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM REGISTRATION_TABLE1 WHERE ENROLLMENT_NO='" + textBox1.Text + "'", CON);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            dataGridView2.DataSource = DT;
            MessageBox.Show("SHOW SUCCESSFULLY....");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection CON = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SDA = new SqlDataAdapter(@"Select ENROLLMENT_NO,DEPARTMENT,NAME,FATHER_NAME,MOTHER_NAME,OCCUPATION,PERMANENT_ADDRESS,PHONE_NO2,OFFICE from REGISTRATION_TABLE1", CON);
           DataTable DT = new DataTable();
            SDA.Fill(DT);
            dataGridView2.DataSource = DT;

            MessageBox.Show("SHOW SUCCESSFULLY....");
    
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection CON = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SDA = new SqlDataAdapter(@"SELECT * FROM REGISTRATION_TABLE1 WHERE ENROLLMENT_NO='" + textBox1.Text + "'", CON);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            dataGridView2.DataSource = DT;
            MessageBox.Show("SHOW SUCCESSFULLY...");
       
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin AD = new admin();
            AD.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login LG = new Login();
            LG.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            printDocument1.Print();
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
