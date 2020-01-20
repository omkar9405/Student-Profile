namespace studentprofiledesign1
{
    partial class ADMIN2PARENT
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rEGISTRATIONTABLE1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet4 = new studentprofiledesign1.DataDataSet4();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rEGISTRATION_TABLE1TableAdapter = new studentprofiledesign1.DataDataSet4TableAdapters.REGISTRATION_TABLE1TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.eNROLLMENTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FATHER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTHER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OCCUPATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERMANENT_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE_NO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRATIONTABLE1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eNROLLMENTNODataGridViewTextBoxColumn,
            this.dEPARTMENTDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.FATHER_NAME,
            this.MOTHER_NAME,
            this.OCCUPATION,
            this.PERMANENT_ADDRESS,
            this.PHONE_NO2,
            this.OFFICE});
            this.dataGridView2.DataSource = this.rEGISTRATIONTABLE1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(39, 81);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(944, 262);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // rEGISTRATIONTABLE1BindingSource
            // 
            this.rEGISTRATIONTABLE1BindingSource.DataMember = "REGISTRATION_TABLE1";
            this.rEGISTRATIONTABLE1BindingSource.DataSource = this.dataDataSet4;
            // 
            // dataDataSet4
            // 
            this.dataDataSet4.DataSetName = "DataDataSet4";
            this.dataDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ENROLLMENT NO";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(389, 375);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 34);
            this.textBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "SEARCH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(763, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "SHOW ALL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // rEGISTRATION_TABLE1TableAdapter
            // 
            this.rEGISTRATION_TABLE1TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(431, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "PARENT DETAILS";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(919, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 51);
            this.button4.TabIndex = 7;
            this.button4.Text = "LOGOUT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(675, 375);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 34);
            this.button5.TabIndex = 8;
            this.button5.Text = "PRINT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // eNROLLMENTNODataGridViewTextBoxColumn
            // 
            this.eNROLLMENTNODataGridViewTextBoxColumn.DataPropertyName = "ENROLLMENT_NO";
            this.eNROLLMENTNODataGridViewTextBoxColumn.HeaderText = "ENROLLMENT_NO";
            this.eNROLLMENTNODataGridViewTextBoxColumn.Name = "eNROLLMENTNODataGridViewTextBoxColumn";
            // 
            // dEPARTMENTDataGridViewTextBoxColumn
            // 
            this.dEPARTMENTDataGridViewTextBoxColumn.DataPropertyName = "DEPARTMENT";
            this.dEPARTMENTDataGridViewTextBoxColumn.HeaderText = "DEPARTMENT";
            this.dEPARTMENTDataGridViewTextBoxColumn.Name = "dEPARTMENTDataGridViewTextBoxColumn";
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // FATHER_NAME
            // 
            this.FATHER_NAME.DataPropertyName = "FATHER_NAME";
            this.FATHER_NAME.HeaderText = "FATHER_NAME";
            this.FATHER_NAME.Name = "FATHER_NAME";
            // 
            // MOTHER_NAME
            // 
            this.MOTHER_NAME.DataPropertyName = "MOTHER_NAME";
            this.MOTHER_NAME.HeaderText = "MOTHER_NAME";
            this.MOTHER_NAME.Name = "MOTHER_NAME";
            // 
            // OCCUPATION
            // 
            this.OCCUPATION.DataPropertyName = "OCCUPATION";
            this.OCCUPATION.HeaderText = "OCCUPATION";
            this.OCCUPATION.Name = "OCCUPATION";
            // 
            // PERMANENT_ADDRESS
            // 
            this.PERMANENT_ADDRESS.DataPropertyName = "PERMANENT_ADDRESS";
            this.PERMANENT_ADDRESS.HeaderText = "PERMANENT_ADDRESS";
            this.PERMANENT_ADDRESS.Name = "PERMANENT_ADDRESS";
            // 
            // PHONE_NO2
            // 
            this.PHONE_NO2.DataPropertyName = "PHONE_NO2";
            this.PHONE_NO2.HeaderText = "PHONE_NO2";
            this.PHONE_NO2.Name = "PHONE_NO2";
            // 
            // OFFICE
            // 
            this.OFFICE.DataPropertyName = "OFFICE";
            this.OFFICE.HeaderText = "OFFICE";
            this.OFFICE.Name = "OFFICE";
            // 
            // ADMIN2PARENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::studentprofiledesign1.Properties.Resources.download__2_;
            this.ClientSize = new System.Drawing.Size(1020, 610);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "ADMIN2PARENT";
            this.Text = "ADMIN2PARENT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ADMIN2PARENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRATIONTABLE1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
       // private System.Windows.Forms.Label label1;
       /* private DataDataSet1 dataDataSet1;
        private System.Windows.Forms.BindingSource rEGISTRATIONTABLEBindingSource;
        private DataDataSet1TableAdapters.REGISTRATION_TABLETableAdapter rEGISTRATION_TABLETableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn fATHERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOTHERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCCUPATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oFFICEDataGridViewTextBoxColumn;
       private System.Windows.Forms.DataGridViewTextBoxColumn pERMANENTADDRESSDataGridViewTextBoxColumn;*/
        private DataDataSet4 dataDataSet4;
        private System.Windows.Forms.BindingSource rEGISTRATIONTABLE1BindingSource;
        private DataDataSet4TableAdapters.REGISTRATION_TABLE1TableAdapter rEGISTRATION_TABLE1TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNROLLMENTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FATHER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTHER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn OCCUPATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERMANENT_ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE_NO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFICE;
    }
}