﻿using System;
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
    public partial class SHOWRESULT4 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omkar\Documents\Visual Studio 2010\Projects\studentprofiledesign1\studentprofiledesign1\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public SHOWRESULT4()
        {
            InitializeComponent();
        }

        private void SHOWRESULT4_Load(object sender, EventArgs e)
        {
            enrollbox.Text = MYPROFILE6.SetValueForText1;
            textBox22.Text = MYPROFILE6.SetValueForText2;

            try
            {
                SqlDataAdapter SDA = new SqlDataAdapter(@"SELECT * FROM tbRESULT WHERE ENROLLMENT_NO='" + enrollbox.Text + "'AND COURSE='" + textBox22.Text + "'", conn);
                DataTable DT = new DataTable();
                SDA.Fill(DT);
                txtPath.Text = DT.Rows[0][12].ToString();
                picBox1.Image = Image.FromFile(txtPath.Text);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
            Bitmap BM = new Bitmap(this.picBox1.Width, this.picBox1.Height);
            picBox1.DrawToBitmap(BM, new Rectangle(0, 0, this.picBox1.Width, this.picBox1.Height));
            e.Graphics.DrawImage(BM, 10, 10);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
