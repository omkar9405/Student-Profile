namespace studentprofiledesign1
{
    partial class profilephoto
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.enrollbox = new System.Windows.Forms.TextBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(304, 526);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(171, 20);
            this.txtPath.TabIndex = 1;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(348, 557);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 2;
            this.back.Text = "EXIT";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // enrollbox
            // 
            this.enrollbox.Location = new System.Drawing.Point(127, 526);
            this.enrollbox.Name = "enrollbox";
            this.enrollbox.ReadOnly = true;
            this.enrollbox.Size = new System.Drawing.Size(171, 20);
            this.enrollbox.TabIndex = 3;
            this.enrollbox.TextChanged += new System.EventHandler(this.enrollbox_TextChanged);
            // 
            // picBox1
            // 
            this.picBox1.BackgroundImage = global::studentprofiledesign1.Properties.Resources.Profile_Icon;
            this.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox1.Location = new System.Drawing.Point(116, 45);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(368, 465);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 4;
            this.picBox1.TabStop = false;
            this.picBox1.Click += new System.EventHandler(this.picBox1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // profilephoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.enrollbox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.txtPath);
            this.Name = "profilephoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "profilephoto";
            this.Load += new System.EventHandler(this.profilephoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox enrollbox;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
    }
}