namespace studentprofiledesign1
{
    partial class admin
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IMAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PICIMAGE = new System.Windows.Forms.DataGridViewImageColumn();
            this.ENROLLMENT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLLNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCADEMICYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RELIGION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BLOOD_GROUP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE_NO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AADHAR_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONFIRM_PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGISTRATIONTABLE1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet6 = new studentprofiledesign1.DataDataSet6();
            this.rEGISTRATIONTABLE1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet1 = new studentprofiledesign1.DataDataSet();
            this.rEGISTRATIONTABLEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet3 = new studentprofiledesign1.DataDataSet3();
            this.rEGISTRATIONTABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SHOW = new System.Windows.Forms.Button();
            this.bkbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rEGISTRATION_TABLE1TableAdapter = new studentprofiledesign1.DataDataSetTableAdapters.REGISTRATION_TABLE1TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.rEGISTRATION_TABLE1TableAdapter1 = new studentprofiledesign1.DataDataSet6TableAdapters.REGISTRATION_TABLE1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRATIONTABLE1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRATIONTABLE1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRATIONTABLEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRATIONTABLEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IMAGE,
            this.PICIMAGE,
            this.ENROLLMENT_NO,
            this.PASSWORD,
            this.dEPARTMENTDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.cLASSDataGridViewTextBoxColumn,
            this.rOLLNODataGridViewTextBoxColumn,
            this.aCADEMICYEARDataGridViewTextBoxColumn,
            this.BOD,
            this.RELIGION,
            this.CATEGORY,
            this.BLOOD_GROUP,
            this.ADDRESS,
            this.PHONE_NO1,
            this.EMAIL_ID,
            this.AADHAR_NO,
            this.GENDER,
            this.CONFIRM_PASSWORD,
            this.cASTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rEGISTRATIONTABLE1BindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView1.Location = new System.Drawing.Point(14, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(996, 561);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IMAGE
            // 
            this.IMAGE.DataPropertyName = "IMAGE";
            this.IMAGE.HeaderText = "IMAGE";
            this.IMAGE.Name = "IMAGE";
            this.IMAGE.ReadOnly = true;
            // 
            // PICIMAGE
            // 
            this.PICIMAGE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PICIMAGE.DataPropertyName = "PICIMAGE";
            this.PICIMAGE.HeaderText = "PICIMAGE";
            this.PICIMAGE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.PICIMAGE.Name = "PICIMAGE";
            this.PICIMAGE.ReadOnly = true;
            this.PICIMAGE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PICIMAGE.Width = 83;
            // 
            // ENROLLMENT_NO
            // 
            this.ENROLLMENT_NO.DataPropertyName = "ENROLLMENT_NO";
            this.ENROLLMENT_NO.HeaderText = "ENROLLMENT_NO";
            this.ENROLLMENT_NO.Name = "ENROLLMENT_NO";
            this.ENROLLMENT_NO.ReadOnly = true;
            // 
            // PASSWORD
            // 
            this.PASSWORD.DataPropertyName = "PASSWORD";
            this.PASSWORD.HeaderText = "PASSWORD";
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.ReadOnly = true;
            // 
            // dEPARTMENTDataGridViewTextBoxColumn
            // 
            this.dEPARTMENTDataGridViewTextBoxColumn.DataPropertyName = "DEPARTMENT";
            this.dEPARTMENTDataGridViewTextBoxColumn.HeaderText = "DEPARTMENT";
            this.dEPARTMENTDataGridViewTextBoxColumn.Name = "dEPARTMENTDataGridViewTextBoxColumn";
            this.dEPARTMENTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLASSDataGridViewTextBoxColumn
            // 
            this.cLASSDataGridViewTextBoxColumn.DataPropertyName = "CLASS";
            this.cLASSDataGridViewTextBoxColumn.HeaderText = "CLASS";
            this.cLASSDataGridViewTextBoxColumn.Name = "cLASSDataGridViewTextBoxColumn";
            this.cLASSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rOLLNODataGridViewTextBoxColumn
            // 
            this.rOLLNODataGridViewTextBoxColumn.DataPropertyName = "ROLL_NO";
            this.rOLLNODataGridViewTextBoxColumn.HeaderText = "ROLL_NO";
            this.rOLLNODataGridViewTextBoxColumn.Name = "rOLLNODataGridViewTextBoxColumn";
            this.rOLLNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aCADEMICYEARDataGridViewTextBoxColumn
            // 
            this.aCADEMICYEARDataGridViewTextBoxColumn.DataPropertyName = "ACADEMIC_YEAR";
            this.aCADEMICYEARDataGridViewTextBoxColumn.HeaderText = "ACADEMIC_YEAR";
            this.aCADEMICYEARDataGridViewTextBoxColumn.Name = "aCADEMICYEARDataGridViewTextBoxColumn";
            this.aCADEMICYEARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BOD
            // 
            this.BOD.DataPropertyName = "BOD";
            this.BOD.HeaderText = "BOD";
            this.BOD.Name = "BOD";
            this.BOD.ReadOnly = true;
            // 
            // RELIGION
            // 
            this.RELIGION.DataPropertyName = "RELIGION";
            this.RELIGION.HeaderText = "RELIGION";
            this.RELIGION.Name = "RELIGION";
            this.RELIGION.ReadOnly = true;
            // 
            // CATEGORY
            // 
            this.CATEGORY.DataPropertyName = "CATEGORY";
            this.CATEGORY.HeaderText = "CATEGORY";
            this.CATEGORY.Name = "CATEGORY";
            this.CATEGORY.ReadOnly = true;
            // 
            // BLOOD_GROUP
            // 
            this.BLOOD_GROUP.DataPropertyName = "BLOOD_GROUP";
            this.BLOOD_GROUP.HeaderText = "BLOOD_GROUP";
            this.BLOOD_GROUP.Name = "BLOOD_GROUP";
            this.BLOOD_GROUP.ReadOnly = true;
            // 
            // ADDRESS
            // 
            this.ADDRESS.DataPropertyName = "ADDRESS";
            this.ADDRESS.HeaderText = "ADDRESS";
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.ReadOnly = true;
            // 
            // PHONE_NO1
            // 
            this.PHONE_NO1.DataPropertyName = "PHONE_NO1";
            this.PHONE_NO1.HeaderText = "PHONE_NO1";
            this.PHONE_NO1.Name = "PHONE_NO1";
            this.PHONE_NO1.ReadOnly = true;
            // 
            // EMAIL_ID
            // 
            this.EMAIL_ID.DataPropertyName = "EMAIL_ID";
            this.EMAIL_ID.HeaderText = "EMAIL_ID";
            this.EMAIL_ID.Name = "EMAIL_ID";
            this.EMAIL_ID.ReadOnly = true;
            // 
            // AADHAR_NO
            // 
            this.AADHAR_NO.DataPropertyName = "AADHAR_NO";
            this.AADHAR_NO.HeaderText = "AADHAR_NO";
            this.AADHAR_NO.Name = "AADHAR_NO";
            this.AADHAR_NO.ReadOnly = true;
            // 
            // GENDER
            // 
            this.GENDER.DataPropertyName = "GENDER";
            this.GENDER.HeaderText = "GENDER";
            this.GENDER.Name = "GENDER";
            this.GENDER.ReadOnly = true;
            // 
            // CONFIRM_PASSWORD
            // 
            this.CONFIRM_PASSWORD.DataPropertyName = "CONFIRM_PASSWORD";
            this.CONFIRM_PASSWORD.HeaderText = "CONFIRM_PASSWORD";
            this.CONFIRM_PASSWORD.Name = "CONFIRM_PASSWORD";
            this.CONFIRM_PASSWORD.ReadOnly = true;
            // 
            // cASTDataGridViewTextBoxColumn
            // 
            this.cASTDataGridViewTextBoxColumn.DataPropertyName = "CAST";
            this.cASTDataGridViewTextBoxColumn.HeaderText = "CAST";
            this.cASTDataGridViewTextBoxColumn.Name = "cASTDataGridViewTextBoxColumn";
            this.cASTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEGISTRATIONTABLE1BindingSource1
            // 
            this.rEGISTRATIONTABLE1BindingSource1.DataMember = "REGISTRATION_TABLE1";
            this.rEGISTRATIONTABLE1BindingSource1.DataSource = this.dataDataSet6;
            // 
            // dataDataSet6
            // 
            this.dataDataSet6.DataSetName = "DataDataSet6";
            this.dataDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEGISTRATIONTABLE1BindingSource
            // 
            this.rEGISTRATIONTABLE1BindingSource.DataMember = "REGISTRATION_TABLE1";
            this.rEGISTRATIONTABLE1BindingSource.DataSource = this.dataDataSet1;
            // 
            // dataDataSet1
            // 
            this.dataDataSet1.DataSetName = "DataDataSet";
            this.dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEGISTRATIONTABLEBindingSource1
            // 
            this.rEGISTRATIONTABLEBindingSource1.DataMember = "REGISTRATION_TABLE";
            this.rEGISTRATIONTABLEBindingSource1.DataSource = this.dataDataSet3;
            // 
            // dataDataSet3
            // 
            this.dataDataSet3.DataSetName = "DataDataSet3";
            this.dataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SHOW
            // 
            this.SHOW.Location = new System.Drawing.Point(827, 627);
            this.SHOW.Name = "SHOW";
            this.SHOW.Size = new System.Drawing.Size(157, 44);
            this.SHOW.TabIndex = 2;
            this.SHOW.Text = "SHOW ALL RECORDS";
            this.SHOW.UseVisualStyleBackColor = true;
            this.SHOW.Click += new System.EventHandler(this.SHOW_Click);
            // 
            // bkbtn
            // 
            this.bkbtn.Location = new System.Drawing.Point(25, 4);
            this.bkbtn.Name = "bkbtn";
            this.bkbtn.Size = new System.Drawing.Size(75, 38);
            this.bkbtn.TabIndex = 3;
            this.bkbtn.Text = "back";
            this.bkbtn.UseVisualStyleBackColor = true;
            this.bkbtn.Click += new System.EventHandler(this.bkbtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 623);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "PARENT DETAILS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(39, 677);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 49);
            this.button3.TabIndex = 8;
            this.button3.Text = "REFFERENCE DETAILS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rEGISTRATION_TABLE1TableAdapter
            // 
            this.rEGISTRATION_TABLE1TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 667);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "SEARCH";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(425, 667);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 23);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(174, 677);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 49);
            this.button4.TabIndex = 11;
            this.button4.Text = "CERTIFICATES";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(911, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 36);
            this.button6.TabIndex = 12;
            this.button6.Text = "LOGOUT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(413, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "REGISTRATION DETAILS";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(174, 624);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 48);
            this.button5.TabIndex = 14;
            this.button5.Text = "RESULTS";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(727, 627);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 44);
            this.button7.TabIndex = 15;
            this.button7.Text = "PRINT";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // rEGISTRATION_TABLE1TableAdapter1
            // 
            this.rEGISTRATION_TABLE1TableAdapter1.ClearBeforeFill = true;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::studentprofiledesign1.Properties.Resources.download;
            this.ClientSize = new System.Drawing.Size(1020, 742);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bkbtn);
            this.Controls.Add(this.SHOW);
            this.Controls.Add(this.dataGridView1);
            this.Name = "admin";
            this.Text = "FORM1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRATIONTABLE1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRATIONTABLE1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRATIONTABLEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRATIONTABLEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SHOW;
     //   private DataDataSet1 dataDataSet;
        private System.Windows.Forms.BindingSource rEGISTRATIONTABLEBindingSource;
       // private DataDataSet1TableAdapters.REGISTRATION_TABLETableAdapter rEGISTRATION_TABLETableAdapter;
        private System.Windows.Forms.Button bkbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private DataDataSet3 dataDataSet3;
        private System.Windows.Forms.BindingSource rEGISTRATIONTABLEBindingSource1;
        //  private DataDataSet3TableAdapters.REGISTRATION_TABLETableAdapter rEGISTRATION_TABLETableAdapter1;
        private DataDataSet dataDataSet1;
        private System.Windows.Forms.BindingSource rEGISTRATIONTABLE1BindingSource;
        private DataDataSetTableAdapters.REGISTRATION_TABLE1TableAdapter rEGISTRATION_TABLE1TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataDataSet6 dataDataSet6;
        private System.Windows.Forms.BindingSource rEGISTRATIONTABLE1BindingSource1;
        private DataDataSet6TableAdapters.REGISTRATION_TABLE1TableAdapter rEGISTRATION_TABLE1TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMAGE;
        private System.Windows.Forms.DataGridViewImageColumn PICIMAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENROLLMENT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLLNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCADEMICYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn RELIGION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn BLOOD_GROUP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE_NO1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AADHAR_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONFIRM_PASSWORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTDataGridViewTextBoxColumn;
    }
}