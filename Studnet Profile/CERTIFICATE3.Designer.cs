﻿namespace studentprofiledesign1
{
    partial class CERTIFICATE3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.enrollbox = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox22
            // 
            this.textBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.Location = new System.Drawing.Point(273, 0);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(100, 31);
            this.textBox22.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(198, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "SEMESTER";
            // 
            // enrollbox
            // 
            this.enrollbox.Location = new System.Drawing.Point(112, 518);
            this.enrollbox.Name = "enrollbox";
            this.enrollbox.ReadOnly = true;
            this.enrollbox.Size = new System.Drawing.Size(171, 20);
            this.enrollbox.TabIndex = 38;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(337, 544);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 37;
            this.back.Text = "EXIT";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(289, 518);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(171, 20);
            this.txtPath.TabIndex = 36;
            // 
            // picBox1
            // 
            this.picBox1.BackgroundImage = global::studentprofiledesign1.Properties.Resources.student_ID_1281;
            this.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox1.Location = new System.Drawing.Point(12, 37);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(546, 465);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 39;
            this.picBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // CERTIFICATE3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 572);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.enrollbox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.txtPath);
            this.Name = "CERTIFICATE3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CERTIFICATE3";
            this.Load += new System.EventHandler(this.CERTIFICATE3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.TextBox enrollbox;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}