namespace studentprofiledesign1
{
    partial class admin3refference
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
            this.label1 = new System.Windows.Forms.Label();
            this.rEGISTRATIONTABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet2 = new studentprofiledesign1.DataDataSet2();
            this.rEGISTRATION_TABLETableAdapter = new studentprofiledesign1.DataDataSet2TableAdapters.REGISTRATION_TABLETableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button5 = new System.Windows.Forms.Button();
            this.rEGISTRATIONTABLE1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet7 = new studentprofiledesign1.DataDataSet7();
            this.rEGISTRATION_TABLE1TableAdapter = new studentprofiledesign1.DataDataSet7TableAdapters.REGISTRATION_TABLE1TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eNROLLMENTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRIEND1NAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRIEND1CLASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRIEND1COURSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRIEND1ROLLNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRIEND1PHONENODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRIEND2NAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRIEND2CLASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRIEND2COURSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRIEND2ROLLNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRIEND2PHONENODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRATIONTABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRATIONTABLE1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(315, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "REFFERENCE DETAILS OF STUDENTS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rEGISTRATIONTABLEBindingSource
            // 
            this.rEGISTRATIONTABLEBindingSource.DataMember = "REGISTRATION_TABLE";
            this.rEGISTRATIONTABLEBindingSource.DataSource = this.dataDataSet2;
            // 
            // dataDataSet2
            // 
            this.dataDataSet2.DataSetName = "DataDataSet2";
            this.dataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEGISTRATION_TABLETableAdapter
            // 
            this.rEGISTRATION_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(850, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "LOGOUT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(370, 535);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 26);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "ENROLLMENT NO";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "SEARCH";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(758, 537);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "SHOW ALL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(670, 535);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 30);
            this.button5.TabIndex = 11;
            this.button5.Text = "PRINT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // rEGISTRATIONTABLE1BindingSource
            // 
            this.rEGISTRATIONTABLE1BindingSource.DataMember = "REGISTRATION_TABLE1";
            this.rEGISTRATIONTABLE1BindingSource.DataSource = this.dataDataSet7;
            // 
            // dataDataSet7
            // 
            this.dataDataSet7.DataSetName = "DataDataSet7";
            this.dataDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEGISTRATION_TABLE1TableAdapter
            // 
            this.rEGISTRATION_TABLE1TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eNROLLMENTNODataGridViewTextBoxColumn,
            this.fRIEND1NAMEDataGridViewTextBoxColumn,
            this.fRIEND1CLASSDataGridViewTextBoxColumn,
            this.fRIEND1COURSEDataGridViewTextBoxColumn,
            this.fRIEND1ROLLNODataGridViewTextBoxColumn,
            this.fRIEND1PHONENODataGridViewTextBoxColumn,
            this.fRIEND2NAMEDataGridViewTextBoxColumn,
            this.fRIEND2CLASSDataGridViewTextBoxColumn,
            this.fRIEND2COURSEDataGridViewTextBoxColumn,
            this.fRIEND2ROLLNODataGridViewTextBoxColumn,
            this.fRIEND2PHONENODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rEGISTRATIONTABLE1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(998, 409);
            this.dataGridView1.TabIndex = 12;
            // 
            // eNROLLMENTNODataGridViewTextBoxColumn
            // 
            this.eNROLLMENTNODataGridViewTextBoxColumn.DataPropertyName = "ENROLLMENT_NO";
            this.eNROLLMENTNODataGridViewTextBoxColumn.HeaderText = "ENROLLMENT_NO";
            this.eNROLLMENTNODataGridViewTextBoxColumn.Name = "eNROLLMENTNODataGridViewTextBoxColumn";
            // 
            // fRIEND1NAMEDataGridViewTextBoxColumn
            // 
            this.fRIEND1NAMEDataGridViewTextBoxColumn.DataPropertyName = "FRIEND1_NAME";
            this.fRIEND1NAMEDataGridViewTextBoxColumn.HeaderText = "FRIEND1_NAME";
            this.fRIEND1NAMEDataGridViewTextBoxColumn.Name = "fRIEND1NAMEDataGridViewTextBoxColumn";
            // 
            // fRIEND1CLASSDataGridViewTextBoxColumn
            // 
            this.fRIEND1CLASSDataGridViewTextBoxColumn.DataPropertyName = "FRIEND1_CLASS";
            this.fRIEND1CLASSDataGridViewTextBoxColumn.HeaderText = "FRIEND1_CLASS";
            this.fRIEND1CLASSDataGridViewTextBoxColumn.Name = "fRIEND1CLASSDataGridViewTextBoxColumn";
            // 
            // fRIEND1COURSEDataGridViewTextBoxColumn
            // 
            this.fRIEND1COURSEDataGridViewTextBoxColumn.DataPropertyName = "FRIEND1_COURSE";
            this.fRIEND1COURSEDataGridViewTextBoxColumn.HeaderText = "FRIEND1_COURSE";
            this.fRIEND1COURSEDataGridViewTextBoxColumn.Name = "fRIEND1COURSEDataGridViewTextBoxColumn";
            // 
            // fRIEND1ROLLNODataGridViewTextBoxColumn
            // 
            this.fRIEND1ROLLNODataGridViewTextBoxColumn.DataPropertyName = "FRIEND1_ROLL_NO";
            this.fRIEND1ROLLNODataGridViewTextBoxColumn.HeaderText = "FRIEND1_ROLL_NO";
            this.fRIEND1ROLLNODataGridViewTextBoxColumn.Name = "fRIEND1ROLLNODataGridViewTextBoxColumn";
            // 
            // fRIEND1PHONENODataGridViewTextBoxColumn
            // 
            this.fRIEND1PHONENODataGridViewTextBoxColumn.DataPropertyName = "FRIEND1_PHONE_NO";
            this.fRIEND1PHONENODataGridViewTextBoxColumn.HeaderText = "FRIEND1_PHONE_NO";
            this.fRIEND1PHONENODataGridViewTextBoxColumn.Name = "fRIEND1PHONENODataGridViewTextBoxColumn";
            // 
            // fRIEND2NAMEDataGridViewTextBoxColumn
            // 
            this.fRIEND2NAMEDataGridViewTextBoxColumn.DataPropertyName = "FRIEND2_NAME";
            this.fRIEND2NAMEDataGridViewTextBoxColumn.HeaderText = "FRIEND2_NAME";
            this.fRIEND2NAMEDataGridViewTextBoxColumn.Name = "fRIEND2NAMEDataGridViewTextBoxColumn";
            // 
            // fRIEND2CLASSDataGridViewTextBoxColumn
            // 
            this.fRIEND2CLASSDataGridViewTextBoxColumn.DataPropertyName = "FRIEND2_CLASS";
            this.fRIEND2CLASSDataGridViewTextBoxColumn.HeaderText = "FRIEND2_CLASS";
            this.fRIEND2CLASSDataGridViewTextBoxColumn.Name = "fRIEND2CLASSDataGridViewTextBoxColumn";
            // 
            // fRIEND2COURSEDataGridViewTextBoxColumn
            // 
            this.fRIEND2COURSEDataGridViewTextBoxColumn.DataPropertyName = "FRIEND2_COURSE";
            this.fRIEND2COURSEDataGridViewTextBoxColumn.HeaderText = "FRIEND2_COURSE";
            this.fRIEND2COURSEDataGridViewTextBoxColumn.Name = "fRIEND2COURSEDataGridViewTextBoxColumn";
            // 
            // fRIEND2ROLLNODataGridViewTextBoxColumn
            // 
            this.fRIEND2ROLLNODataGridViewTextBoxColumn.DataPropertyName = "FRIEND2_ROLL_NO";
            this.fRIEND2ROLLNODataGridViewTextBoxColumn.HeaderText = "FRIEND2_ROLL_NO";
            this.fRIEND2ROLLNODataGridViewTextBoxColumn.Name = "fRIEND2ROLLNODataGridViewTextBoxColumn";
            // 
            // fRIEND2PHONENODataGridViewTextBoxColumn
            // 
            this.fRIEND2PHONENODataGridViewTextBoxColumn.DataPropertyName = "FRIEND2_PHONE_NO";
            this.fRIEND2PHONENODataGridViewTextBoxColumn.HeaderText = "FRIEND2_PHONE_NO";
            this.fRIEND2PHONENODataGridViewTextBoxColumn.Name = "fRIEND2PHONENODataGridViewTextBoxColumn";
            // 
            // admin3refference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::studentprofiledesign1.Properties.Resources.download__1_;
            this.ClientSize = new System.Drawing.Size(1028, 740);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "admin3refference";
            this.Text = "admin3refference";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admin3refference_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRATIONTABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRATIONTABLE1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DataDataSet2 dataDataSet2;
        private System.Windows.Forms.BindingSource rEGISTRATIONTABLEBindingSource;
        private DataDataSet2TableAdapters.REGISTRATION_TABLETableAdapter rEGISTRATION_TABLETableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button5;
        private DataDataSet7 dataDataSet7;
        private System.Windows.Forms.BindingSource rEGISTRATIONTABLE1BindingSource;
        private DataDataSet7TableAdapters.REGISTRATION_TABLE1TableAdapter rEGISTRATION_TABLE1TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNROLLMENTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRIEND1NAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRIEND1CLASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRIEND1COURSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRIEND1ROLLNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRIEND1PHONENODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRIEND2NAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRIEND2CLASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRIEND2COURSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRIEND2ROLLNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRIEND2PHONENODataGridViewTextBoxColumn;
    }
}