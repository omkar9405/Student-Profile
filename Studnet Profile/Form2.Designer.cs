namespace studentprofiledesign1
{
    partial class REGISTRATION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTRATION));
            this.backbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DEPARTBOX = new System.Windows.Forms.ComboBox();
            this.CLASSBOX = new System.Windows.Forms.ComboBox();
            this.ROLLBOX = new System.Windows.Forms.TextBox();
            this.YEARBOX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ENROLLBOX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GENDERBOX = new System.Windows.Forms.ComboBox();
            this.DATE = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.AADHARBOX = new System.Windows.Forms.TextBox();
            this.CASTBOX = new System.Windows.Forms.TextBox();
            this.ADDRESSBOX = new System.Windows.Forms.TextBox();
            this.BLOODBOX = new System.Windows.Forms.TextBox();
            this.RELIGIONBOX = new System.Windows.Forms.TextBox();
            this.EMAILBOX = new System.Windows.Forms.TextBox();
            this.PHONEBOX = new System.Windows.Forms.TextBox();
            this.CATEGORYBOX = new System.Windows.Forms.TextBox();
            this.NAMEBOX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            resources.ApplyResources(this.backbtn, "backbtn");
            this.backbtn.Name = "backbtn";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.DEPARTBOX);
            this.groupBox1.Controls.Add(this.CLASSBOX);
            this.groupBox1.Controls.Add(this.ROLLBOX);
            this.groupBox1.Controls.Add(this.YEARBOX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ENROLLBOX);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // DEPARTBOX
            // 
            this.DEPARTBOX.FormattingEnabled = true;
            this.DEPARTBOX.Items.AddRange(new object[] {
            resources.GetString("DEPARTBOX.Items"),
            resources.GetString("DEPARTBOX.Items1"),
            resources.GetString("DEPARTBOX.Items2"),
            resources.GetString("DEPARTBOX.Items3"),
            resources.GetString("DEPARTBOX.Items4")});
            resources.ApplyResources(this.DEPARTBOX, "DEPARTBOX");
            this.DEPARTBOX.Name = "DEPARTBOX";
            this.DEPARTBOX.Tag = "";
            this.DEPARTBOX.SelectedIndexChanged += new System.EventHandler(this.DEPARTBOX_SelectedIndexChanged);
            this.DEPARTBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DEPARTBOX_KeyDown);
            // 
            // CLASSBOX
            // 
            this.CLASSBOX.FormattingEnabled = true;
            this.CLASSBOX.Items.AddRange(new object[] {
            resources.GetString("CLASSBOX.Items"),
            resources.GetString("CLASSBOX.Items1"),
            resources.GetString("CLASSBOX.Items2"),
            resources.GetString("CLASSBOX.Items3"),
            resources.GetString("CLASSBOX.Items4"),
            resources.GetString("CLASSBOX.Items5"),
            resources.GetString("CLASSBOX.Items6"),
            resources.GetString("CLASSBOX.Items7"),
            resources.GetString("CLASSBOX.Items8"),
            resources.GetString("CLASSBOX.Items9"),
            resources.GetString("CLASSBOX.Items10"),
            resources.GetString("CLASSBOX.Items11"),
            resources.GetString("CLASSBOX.Items12"),
            resources.GetString("CLASSBOX.Items13"),
            resources.GetString("CLASSBOX.Items14")});
            resources.ApplyResources(this.CLASSBOX, "CLASSBOX");
            this.CLASSBOX.Name = "CLASSBOX";
            this.CLASSBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CLASSBOX_KeyDown);
            // 
            // ROLLBOX
            // 
            resources.ApplyResources(this.ROLLBOX, "ROLLBOX");
            this.ROLLBOX.Name = "ROLLBOX";
            this.ROLLBOX.TextChanged += new System.EventHandler(this.ROLLBOX_TextChanged);
            this.ROLLBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ROLLBOX_KeyDown);
            this.ROLLBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ROLLBOX_KeyPress);
            // 
            // YEARBOX
            // 
            resources.ApplyResources(this.YEARBOX, "YEARBOX");
            this.YEARBOX.Name = "YEARBOX";
            this.YEARBOX.TextChanged += new System.EventHandler(this.YEARBOX_TextChanged);
            this.YEARBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.YEARBOX_KeyDown);
            this.YEARBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YEARBOX_KeyPress);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ENROLLBOX
            // 
            resources.ApplyResources(this.ENROLLBOX, "ENROLLBOX");
            this.ENROLLBOX.Name = "ENROLLBOX";
            this.ENROLLBOX.TextChanged += new System.EventHandler(this.ENROLLBOX_TextChanged);
            this.ENROLLBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ENROLLBOX_KeyDown);
            this.ENROLLBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ENROLLBOX_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.GENDERBOX);
            this.groupBox2.Controls.Add(this.DATE);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.AADHARBOX);
            this.groupBox2.Controls.Add(this.CASTBOX);
            this.groupBox2.Controls.Add(this.ADDRESSBOX);
            this.groupBox2.Controls.Add(this.BLOODBOX);
            this.groupBox2.Controls.Add(this.RELIGIONBOX);
            this.groupBox2.Controls.Add(this.EMAILBOX);
            this.groupBox2.Controls.Add(this.PHONEBOX);
            this.groupBox2.Controls.Add(this.CATEGORYBOX);
            this.groupBox2.Controls.Add(this.NAMEBOX);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // GENDERBOX
            // 
            this.GENDERBOX.FormattingEnabled = true;
            this.GENDERBOX.Items.AddRange(new object[] {
            resources.GetString("GENDERBOX.Items"),
            resources.GetString("GENDERBOX.Items1")});
            resources.ApplyResources(this.GENDERBOX, "GENDERBOX");
            this.GENDERBOX.Name = "GENDERBOX";
            this.GENDERBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GENDERBOX_KeyDown);
            // 
            // DATE
            // 
            this.DATE.AllowDrop = true;
            resources.ApplyResources(this.DATE, "DATE");
            this.DATE.Name = "DATE";
            this.DATE.Value = new System.DateTime(2018, 1, 19, 21, 16, 39, 0);
            this.DATE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DATE_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button6);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // button10
            // 
            resources.ApplyResources(this.button10, "button10");
            this.button10.Name = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            resources.ApplyResources(this.button9, "button9");
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // AADHARBOX
            // 
            resources.ApplyResources(this.AADHARBOX, "AADHARBOX");
            this.AADHARBOX.Name = "AADHARBOX";
            this.AADHARBOX.TextChanged += new System.EventHandler(this.AADHARBOX_TextChanged);
            this.AADHARBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AADHARBOX_KeyDown);
            this.AADHARBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AADHARBOX_KeyPress);
            // 
            // CASTBOX
            // 
            resources.ApplyResources(this.CASTBOX, "CASTBOX");
            this.CASTBOX.Name = "CASTBOX";
            this.CASTBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CASTBOX_KeyDown);
            this.CASTBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CASTBOX_KeyPress);
            // 
            // ADDRESSBOX
            // 
            resources.ApplyResources(this.ADDRESSBOX, "ADDRESSBOX");
            this.ADDRESSBOX.Name = "ADDRESSBOX";
            this.ADDRESSBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ADDRESSBOX_KeyDown);
            this.ADDRESSBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ADDRESSBOX_KeyPress);
            // 
            // BLOODBOX
            // 
            resources.ApplyResources(this.BLOODBOX, "BLOODBOX");
            this.BLOODBOX.Name = "BLOODBOX";
            this.BLOODBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BLOODBOX_KeyDown);
            // 
            // RELIGIONBOX
            // 
            resources.ApplyResources(this.RELIGIONBOX, "RELIGIONBOX");
            this.RELIGIONBOX.Name = "RELIGIONBOX";
            this.RELIGIONBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RELIGIONBOX_KeyDown);
            this.RELIGIONBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RELIGIONBOX_KeyPress);
            // 
            // EMAILBOX
            // 
            resources.ApplyResources(this.EMAILBOX, "EMAILBOX");
            this.EMAILBOX.Name = "EMAILBOX";
            this.EMAILBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EMAILBOX_KeyDown);
            this.EMAILBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EMAILBOX_KeyPress);
            // 
            // PHONEBOX
            // 
            resources.ApplyResources(this.PHONEBOX, "PHONEBOX");
            this.PHONEBOX.Name = "PHONEBOX";
            this.PHONEBOX.TextChanged += new System.EventHandler(this.PHONEBOX_TextChanged);
            this.PHONEBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PHONEBOX_KeyDown);
            this.PHONEBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PHONEBOX_KeyPress);
            // 
            // CATEGORYBOX
            // 
            resources.ApplyResources(this.CATEGORYBOX, "CATEGORYBOX");
            this.CATEGORYBOX.Name = "CATEGORYBOX";
            this.CATEGORYBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CATEGORYBOX_KeyDown);
            this.CATEGORYBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CATEGORYBOX_KeyPress);
            // 
            // NAMEBOX
            // 
            resources.ApplyResources(this.NAMEBOX, "NAMEBOX");
            this.NAMEBOX.Name = "NAMEBOX";
            this.NAMEBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NAMEBOX_KeyDown);
            this.NAMEBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NAMEBOX_KeyPress);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // savebtn
            // 
            resources.ApplyResources(this.savebtn, "savebtn");
            this.savebtn.Name = "savebtn";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // picBox1
            // 
            this.picBox1.BackgroundImage = global::studentprofiledesign1.Properties.Resources.Profile_Icon;
            resources.ApplyResources(this.picBox1, "picBox1");
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox1.Name = "picBox1";
            this.picBox1.TabStop = false;
            this.picBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // txtPath
            // 
            resources.ApplyResources(this.txtPath, "txtPath");
            this.txtPath.Name = "txtPath";
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Name = "label19";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // REGISTRATION
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::studentprofiledesign1.Properties.Resources.download;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "REGISTRATION";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox DEPARTBOX;
        private System.Windows.Forms.ComboBox CLASSBOX;
        private System.Windows.Forms.TextBox ROLLBOX;
        private System.Windows.Forms.TextBox YEARBOX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ENROLLBOX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox AADHARBOX;
        private System.Windows.Forms.TextBox CASTBOX;
        private System.Windows.Forms.TextBox ADDRESSBOX;
        private System.Windows.Forms.TextBox BLOODBOX;
        private System.Windows.Forms.TextBox RELIGIONBOX;
        private System.Windows.Forms.TextBox EMAILBOX;
        private System.Windows.Forms.TextBox PHONEBOX;
        private System.Windows.Forms.TextBox CATEGORYBOX;
        private System.Windows.Forms.TextBox NAMEBOX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DateTimePicker DATE;
        private System.Windows.Forms.ComboBox GENDERBOX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.PictureBox picBox1;
    }
}