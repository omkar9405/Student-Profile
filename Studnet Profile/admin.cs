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
    
    public partial class admin : Form
    {
        SqlConnection CON = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommandBuilder SCB;
        SqlDataAdapter SDA;
        DataTable DT;
        public admin()
        {
            InitializeComponent();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           // SCB = new SqlCommandBuilder(SDA);
            //SDA.Update(DT);
        }

        private void SHOW_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection CON = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                SDA = new SqlDataAdapter(@"SELECT IMAGE,PICIMAGE,ENROLLMENT_NO, PASSWORD, CONFIRM_PASSWORD, DEPARTMENT, CLASS, ACADEMIC_YEAR, ROLL_NO, NAME, RELIGION, BOD, CATEGORY, CAST, BLOOD_GROUP, ADDRESS, PHONE_NO1, EMAIL_ID, AADHAR_NO, GENDER FROM REGISTRATION_TABLE1", CON);
                DT = new DataTable();
                SDA.Fill(DT);
                dataGridView1.DataSource = DT;

                MessageBox.Show("SHOW SUCCESSFULLY....");
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

        private void bkbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lN = new Login();
            lN.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN2PARENT AP = new ADMIN2PARENT();
            AP.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            try
            {
                SqlConnection CON = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                SDA = new SqlDataAdapter(@"SELECT IMAGE,PICIMAGE,ENROLLMENT_NO, PASSWORD, CONFIRM_PASSWORD, DEPARTMENT, CLASS, ACADEMIC_YEAR, ROLL_NO, NAME, RELIGION, BOD, CATEGORY, CAST, BLOOD_GROUP, ADDRESS, PHONE_NO1, EMAIL_ID, AADHAR_NO, GENDER FROM REGISTRATION_TABLE1 WHERE ENROLLMENT_NO='"+textBox1.Text+"'", CON);
                DT = new DataTable();
                SDA.Fill(DT);
                dataGridView1.DataSource = DT;

                MessageBox.Show("SHOW SUCCESSFULLY....");
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin3refference AR = new admin3refference();
            AR.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SCB = new SqlCommandBuilder(SDA);
            SDA.Update(DT);

        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMINCERTIFICATES AC = new ADMINCERTIFICATES();
            AC.Show();
        }

        private void admin_Load(object sender, EventArgs e)
        {
          

            // TODO: This line of code loads data into the 'dataDataSet6.REGISTRATION_TABLE1' table. You can move, or remove it, as needed.
            this.rEGISTRATION_TABLE1TableAdapter1.Fill(this.dataDataSet6.REGISTRATION_TABLE1);
            
            try
            {
                SqlConnection CON = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                string qry = "select * from REGISTRATION_TABLE1";
                SqlCommand COMMAND = new SqlCommand(qry, CON);
                SDA = new SqlDataAdapter(COMMAND);
                DT = new DataTable();
                SDA.Fill(DT);
                dataGridView1.DataSource = DT;
               // dataGridView1.RowTemplate.Height = 300;
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Height = 114;
                
                }
                DataGridViewImageColumn IMAGE = new DataGridViewImageColumn();
                IMAGE = (DataGridViewImageColumn)dataGridView1.Columns[36];
                IMAGE.ImageLayout = DataGridViewImageCellLayout.Stretch;
                SDA.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (CON.State == ConnectionState.Open)
                {
                    CON.Close();

                }
            }


        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ADMINRESULTS AR = new ADMINRESULTS();
            AR.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
     PrintDialog printDialog = new PrintDialog();            
     printDialog.Document = printDocument1;
     printDialog.UseEXDialog = true;    
    //Get the document
     if (DialogResult.OK == printDialog.ShowDialog())
     {
         printDocument1.DocumentName = "Test Page Print";                
         printDocument1.Print();
     }
   

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap BM = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(BM,new Rectangle(0,0,this.dataGridView1.Width,this.dataGridView1.Height));
            e.Graphics.DrawImage(BM,10,10);
            

         /* bool more = MyDataGridViewPrinter.DrawDataGridView(e.Graphics);
          if (more == true)
        e.HasMorePages = true;

            */
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LG = new Login();
            LG.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder scb = new SqlCommandBuilder();
                SDA.Update(DT);
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
    }
}
