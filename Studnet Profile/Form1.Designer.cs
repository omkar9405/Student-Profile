namespace studentprofiledesign1
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.regibtn = new System.Windows.Forms.Button();
            this.logbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PASSBOX = new System.Windows.Forms.TextBox();
            this.ENROLLBOX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(370, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT PROFILE";
            // 
            // regibtn
            // 
            this.regibtn.ForeColor = System.Drawing.Color.Black;
            this.regibtn.Location = new System.Drawing.Point(474, 486);
            this.regibtn.Name = "regibtn";
            this.regibtn.Size = new System.Drawing.Size(194, 32);
            this.regibtn.TabIndex = 3;
            this.regibtn.Text = "NEW REGISTRATION";
            this.regibtn.UseVisualStyleBackColor = true;
            this.regibtn.Click += new System.EventHandler(this.regibtn_Click);
            // 
            // logbtn
            // 
            this.logbtn.ForeColor = System.Drawing.Color.Black;
            this.logbtn.Location = new System.Drawing.Point(701, 487);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(75, 31);
            this.logbtn.TabIndex = 3;
            this.logbtn.Text = "LOGIN";
            this.logbtn.UseVisualStyleBackColor = true;
            this.logbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(805, 486);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1163, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 27);
            this.button4.TabIndex = 4;
            this.button4.Text = "ADMIN";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.PASSBOX);
            this.groupBox1.Controls.Add(this.ENROLLBOX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(474, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // PASSBOX
            // 
            this.PASSBOX.Location = new System.Drawing.Point(171, 58);
            this.PASSBOX.Name = "PASSBOX";
            this.PASSBOX.PasswordChar = '*';
            this.PASSBOX.Size = new System.Drawing.Size(208, 20);
            this.PASSBOX.TabIndex = 5;
            this.PASSBOX.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.PASSBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.PASSBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // ENROLLBOX
            // 
            this.ENROLLBOX.Location = new System.Drawing.Point(171, 22);
            this.ENROLLBOX.Name = "ENROLLBOX";
            this.ENROLLBOX.Size = new System.Drawing.Size(208, 20);
            this.ENROLLBOX.TabIndex = 6;
            this.ENROLLBOX.TextChanged += new System.EventHandler(this.ENROLLBOX_TextChanged);
            this.ENROLLBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.ENROLLBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ENROLLMENT NO.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(917, 691);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "ABOUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::studentprofiledesign1.Properties.Resources.powered_by_linux_by_rvc_2011_d4t5bc11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 760);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.logbtn);
            this.Controls.Add(this.regibtn);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regibtn;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PASSBOX;
        private System.Windows.Forms.TextBox ENROLLBOX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

