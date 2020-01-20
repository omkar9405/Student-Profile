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
    public partial class admin3refference : Form
    {
        SqlConnection CON = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlDataAdapter SDA;
        DataTable DT;
        public admin3refference()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin AD = new admin();
            AD.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login AD = new Login();
            AD.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection CON = new SqlConnection();
                SDA = new SqlDataAdapter("SELECT * FROM REGISTRATION_TABLE1 WHERE ENROLLMENT_NO='" + textBox1.Text + "'", CON);
                DT = new DataTable();
                SDA.Fill(DT);
                dataGridView1.DataSource = DT;
                MessageBox.Show("SHOW SUCCESSFULLY....");
                //textBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void admin3refference_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet7.REGISTRATION_TABLE1' table. You can move, or remove it, as needed.
            this.rEGISTRATION_TABLE1TableAdapter.Fill(this.dataDataSet7.REGISTRATION_TABLE1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try{
            SqlConnection CON = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SDA = new SqlDataAdapter(@"SELECT ENROLLMENT_NO,FRIEND1_NAME,FRIEND1_CLASS,FRIEND1_COURSE,FRIEND1_ROLL_NO,FRIEND1_PHONE_NO,FRIEND2_NAME,FRIEND2_CLASS,FRIEND2_COURSE,FRIEND2_ROLL_NO,FRIEND2_PHONE_NO FROM REGISTRATION_TABLE1", CON);
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

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            printDocument1.Print();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rEGISTRATION_TABLE1TableAdapter.FillBy(this.dataDataSet7.REGISTRATION_TABLE1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
