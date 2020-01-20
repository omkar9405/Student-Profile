using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace studentprofiledesign1
{
    public partial class REGISTRATION : Form

    {
       
        public static string SetValueForText1 = "";
        SqlConnection CON = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand COMMAND = new SqlCommand();
      
        public REGISTRATION()
        {
            InitializeComponent();
            this.ActiveControl = DEPARTBOX;
            DEPARTBOX.Focus();
            
        }

      
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                ENROLLBOX.Text = MYPROFILE2.SetValueForText1;

                ENROLLBOX.Text = PARENTS_DETAILS.SetValueForText1;

                ENROLLBOX.Text = SEM1.SetValueForText1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            }

        
        private void label15_Click(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {   
           
            this.Close();
            PARENTS_DETAILS PD = new PARENTS_DETAILS();
            PD.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            this.Close();
            SEM1 S1 = new SEM1();
            S1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            SEM2 S2 = new SEM2();
            S2.Show();
        }

       

        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "JPG|*.jpg|PNG|*.png";
                // of.Filter = "png files(*.png)|*.png|jpg files(*.jpg) *.jpg|All files(*.*)|*.*";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = of.FileName.ToString();
                    picBox1.ImageLocation = txtPath.Text;
                }
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }


            
        }

        private void ROLLBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void DEPARTBOX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login ln = new Login();
            ln.Show();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            
            try
            {

                CON.Open();
                byte[] images = null;
                FileStream stream = new FileStream(txtPath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                string sqlQuery = "insert into REGISTRATION_TABLE1(DEPARTMENT,CLASS,ENROLLMENT_NO,ACADEMIC_YEAR,ROLL_NO,IMAGE,PICIMAGE,NAME,RELIGION,BOD,CATEGORY,CAST,GENDER,BLOOD_GROUP,ADDRESS,PHONE_NO1,EMAIL_ID,AADHAR_NO) values('" + DEPARTBOX.Text + "','" + CLASSBOX.Text + "','" + ENROLLBOX.Text + "','" + YEARBOX.Text + "','" + ROLLBOX.Text + "','" + txtPath.Text + "',@images,'" + NAMEBOX.Text + "','" + RELIGIONBOX.Text + "','" + DATE.Value.ToString() + "','" + CATEGORYBOX.Text + "','" + CASTBOX.Text + "','" + GENDERBOX.Text + "','" + BLOODBOX.Text + "','" + ADDRESSBOX.Text + "','" + PHONEBOX.Text + "','" + EMAILBOX.Text + "','" + AADHARBOX.Text + "')";
                COMMAND = new SqlCommand(sqlQuery, CON);
                COMMAND.Parameters.Add(new SqlParameter("@images", images));
                int n = COMMAND.ExecuteNonQuery();
                CON.Close();
                MessageBox.Show(n.ToString() + "inserted..SAVED SUCCESSFULLY....");
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
            Login lg = new Login();
            lg.Show();

        }

        private void AADHARBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void ENROLLBOX_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

       
        private void DEPARTBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CLASSBOX.Focus();
            }
        }

        private void CLASSBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ENROLLBOX.Focus();
            }

        }

        private void ENROLLBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                YEARBOX.Focus();
            }

        }

        private void YEARBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ROLLBOX.Focus();
            }

        }

        private void ROLLBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NAMEBOX.Focus();
            }

        }

        private void NAMEBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RELIGIONBOX.Focus();
            }

        }

        private void PHONEBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            this.Hide();
            SEMESTER3 S3 =new SEMESTER3();
            S3.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            this.Hide();
            SEM4 S4 = new SEM4();
            S4.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            this.Hide();
            SEM5 S5 = new SEM5();
            S5.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            this.Hide();
            SEM6 S6 = new SEM6();
            S6.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            this.Hide();
            PARENTS_DETAILS pd = new PARENTS_DETAILS();
            pd.Show();
 
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SetValueForText1 = ENROLLBOX.Text;
            try
            {
                CON.Open();
                //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                COMMAND = new SqlCommand("Select * From REGISTRATION_TABLE1 Where ENROLLMENT_NO=@ENROLLMENT_NO and PASSWORD=@PASSWORD", CON);
                COMMAND.Parameters.Add("@ENROLLMENT_NO", SqlDbType.VarChar).Value = ENROLLBOX.Text;
                COMMAND.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = textBox1.Text;
                SqlDataAdapter sda = new SqlDataAdapter(COMMAND);

                DataTable dt = new DataTable();

                sda.Fill(dt);
                CON.Close();
                if (dt.Rows.Count == 1)
                {
                    CON.Open();
                    byte[] images = null;
                    FileStream stream = new FileStream(txtPath.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    images = brs.ReadBytes((int)stream.Length);

                    string sqlQuery = "UPDATE REGISTRATION_TABLE1 SET DEPARTMENT='" + DEPARTBOX.Text + "',CLASS='" + CLASSBOX.Text + "',ENROLLMENT_NO='" + ENROLLBOX.Text + "',ACADEMIC_YEAR='" + YEARBOX.Text + "',ROLL_NO='" + ROLLBOX.Text + "',IMAGE='" + txtPath.Text + "',PICIMAGE=@IMAGES,NAME='" + NAMEBOX.Text + "',RELIGION='" + RELIGIONBOX.Text + "',BOD='" + DATE.Value.ToString() + "',CATEGORY='" + CATEGORYBOX.Text + "',CAST='" + CASTBOX.Text + "',GENDER='" + GENDERBOX.Text + "',BLOOD_GROUP='" + BLOODBOX.Text + "',ADDRESS='" + ADDRESSBOX.Text + "',PHONE_NO1='" + PHONEBOX.Text + "',EMAIL_ID='" + EMAILBOX.Text + "',AADHAR_NO='" + AADHARBOX.Text + "' WHERE ENROLLMENT_NO='" + ENROLLBOX.Text + "' AND PASSWORD='" + textBox1.Text + "'";
                    COMMAND = new SqlCommand(sqlQuery, CON);
                    COMMAND.Parameters.Add(new SqlParameter("@images", images));
                    int n = COMMAND.ExecuteNonQuery();
                    CON.Close();
                    MessageBox.Show(n.ToString() + "UPDATED..SAVED SUCCESSFULLY....");


                }

                else
                {

                    MessageBox.Show("PLEASE CHECK ENROLLMENT_NO OR PASSWORD!!!");
                    ENROLLBOX.Text = "";
                    textBox1.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void DATE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CATEGORYBOX.Focus();
            }

        }

        private void RELIGIONBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               DATE.Focus();
            }

        }

        private void CATEGORYBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CASTBOX.Focus();
            }

        }

        private void CASTBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GENDERBOX.Focus();
            }

        }

        private void GENDERBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BLOODBOX.Focus();
            }

        }

        private void BLOODBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ADDRESSBOX.Focus();
            }

        }

        private void ADDRESSBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               PHONEBOX.Focus();
            }

        }

        private void PHONEBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EMAILBOX.Focus();
            }

        }

        private void EMAILBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AADHARBOX.Focus();
            }

        }

        private void AADHARBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                savebtn.Focus();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                COMMAND = new SqlCommand("Select * From REGISTRATION_TABLE1 Where ENROLLMENT_NO=@ENROLLMENT_NO and PASSWORD=@PASSWORD", CON);
                COMMAND.Parameters.Add("@ENROLLMENT_NO", SqlDbType.VarChar).Value = ENROLLBOX.Text;
                COMMAND.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = textBox1.Text;
                SqlDataAdapter sda = new SqlDataAdapter(COMMAND);

                DataTable DT = new DataTable();

                sda.Fill(DT);
                if (DT.Rows.Count == 1)
                {

                    ENROLLBOX.Text = DT.Rows[0][1].ToString();
                    DEPARTBOX.Text = DT.Rows[0][4].ToString();
                    CLASSBOX.Text = DT.Rows[0][5].ToString();
                    YEARBOX.Text = DT.Rows[0][6].ToString();
                    ROLLBOX.Text = DT.Rows[0][7].ToString();
                    NAMEBOX.Text = DT.Rows[0][8].ToString();
                    RELIGIONBOX.Text = DT.Rows[0][9].ToString();
                    txtPath.Text = DT.Rows[0][25].ToString();
                    picBox1.Image = Image.FromFile(txtPath.Text);


                    DATE.Text = DT.Rows[0][10].ToString();

                    CATEGORYBOX.Text = DT.Rows[0][11].ToString();
                    CASTBOX.Text = DT.Rows[0][12].ToString();
                    GENDERBOX.Text = DT.Rows[0][18].ToString();
                    BLOODBOX.Text = DT.Rows[0][13].ToString();
                    ADDRESSBOX.Text = DT.Rows[0][14].ToString();
                    PHONEBOX.Text = DT.Rows[0][15].ToString();
                    EMAILBOX.Text = DT.Rows[0][16].ToString();
                    AADHARBOX.Text = DT.Rows[0][17].ToString();
                }
                else
                {

                    MessageBox.Show(" PLEASE CHECK PASSWORD ...");

                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
       
        }

        private void ENROLLBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void ROLLBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void YEARBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void PHONEBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void AADHARBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void NAMEBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }

        }

        private void RELIGIONBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }

        }

        private void CATEGORYBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }

        }

        private void CASTBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }

        }

        private void ADDRESSBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsSymbol(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            
            {
                e.Handled = true;

            }

        }

        private void EMAILBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void YEARBOX_TextChanged(object sender, EventArgs e)
        {

        }

       
       
        
    }
}
