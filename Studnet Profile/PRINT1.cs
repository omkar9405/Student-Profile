using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace studentprofiledesign1
{
    public partial class PRINT1 : Form
    {
       /* int X,Y,XWIDTH,YHEIGHT,CELLWIDTH,CELLHEIGHT;
        Font FON;
        Rectangle REC;
        StringFormat STRING;*/
        public PRINT1()
        {
            InitializeComponent();
        }

       private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          /*   X = 170;
             Y = 360;
             XWIDTH = 190;
             YHEIGHT = 20;
             CELLWIDTH = 300;
             CELLHEIGHT = 370;
             FON = new Font(FontFamily.GenericSerif, 12, FontStyle.Regular);
             REC = new Rectangle(X,10,XWIDTH,YHEIGHT);
             STRING = new StringFormat();
             STRING.Alignment = StringAlignment.Center;

             STRING.LineAlignment = StringAlignment.Center;
             e.Graphics.FillRectangle(Brushes.WhiteSmoke, REC);
             e.Graphics.DrawRectangle(Pens.Black,REC);
             //e.Graphics.DrawString(Form.ActiveForm.HeaderText, FON, Brushes.Black, REC, STRING);
           */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog = System.Windows.Forms.DialogResult.Yes)
            {
                printDocument1.Print();
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewControl1.Zoom = 1.2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewControl1.AutoZoom = true;
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
