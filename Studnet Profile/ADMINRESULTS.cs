using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace studentprofiledesign1
{
    public partial class ADMINRESULTS : Form
    {
        SqlCommand CMD = new SqlCommand();
        SqlConnection CON = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
       
        public ADMINRESULTS()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LG = new Login();
            LG.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin AD = new admin();
            AD.Show();
        }

        private void ADMINRESULTS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet1.tbRESULT' table. You can move, or remove it, as needed.
            this.tbRESULTTableAdapter.Fill(this.dataDataSet1.tbRESULT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  CON.Open();
            SqlCommand CMD = CON.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = " Select ENROLLMENT_NO,COURSE,ACADEMIC_YEAR,SUB_1,SUB_2,SUB_3,SUB_4,SUB_5,SUB_6,TOTAL,PERCENTAGE,SESSIONAL,IMAGE from dtRESULT";

            CMD.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(CMD);
            SDA.Fill(DT);
            dataGridView1.DataSource = DT;
            CON.Close();
            MessageBox.Show("SHOW SUCCESSFULLY....");
            */
            try
            {
                SqlConnection CON = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                SqlDataAdapter SDA = new SqlDataAdapter(@"SELECT ENROLLMENT_NO,COURSE,ACADEMIC_YEAR,SUB_1,SUB_2,SUB_3,SUB_4,SUB_5,SUB_6,TOTAL,PERCENTAGE,SESSIONAL,IMAGE FROM tbRESULT", CON);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM tbRESULT WHERE ENROLLMENT_NO='" + textBox1.Text + "'", CON);
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
    }
}
