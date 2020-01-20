namespace studentprofiledesign1
{
    partial class ADMINCERTIFICATES
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
            this.eNROLLMENTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cERTIFICATENODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEOFEVENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEOFCOLLEGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPLOADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCUMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet5 = new studentprofiledesign1.DataDataSet5();
            this.dOCUMENTSTableAdapter = new studentprofiledesign1.DataDataSet5TableAdapters.DOCUMENTSTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eNROLLMENTNODataGridViewTextBoxColumn,
            this.cERTIFICATENODataGridViewTextBoxColumn,
            this.nAMEOFEVENTDataGridViewTextBoxColumn,
            this.nAMEOFCOLLEGEDataGridViewTextBoxColumn,
            this.uPLOADDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dOCUMENTSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(231, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // eNROLLMENTNODataGridViewTextBoxColumn
            // 
            this.eNROLLMENTNODataGridViewTextBoxColumn.DataPropertyName = "ENROLLMENT_NO";
            this.eNROLLMENTNODataGridViewTextBoxColumn.HeaderText = "ENROLLMENT_NO";
            this.eNROLLMENTNODataGridViewTextBoxColumn.Name = "eNROLLMENTNODataGridViewTextBoxColumn";
            // 
            // cERTIFICATENODataGridViewTextBoxColumn
            // 
            this.cERTIFICATENODataGridViewTextBoxColumn.DataPropertyName = "CERTIFICATE_NO";
            this.cERTIFICATENODataGridViewTextBoxColumn.HeaderText = "CERTIFICATE_NO";
            this.cERTIFICATENODataGridViewTextBoxColumn.Name = "cERTIFICATENODataGridViewTextBoxColumn";
            // 
            // nAMEOFEVENTDataGridViewTextBoxColumn
            // 
            this.nAMEOFEVENTDataGridViewTextBoxColumn.DataPropertyName = "NAME_OF_EVENT";
            this.nAMEOFEVENTDataGridViewTextBoxColumn.HeaderText = "NAME_OF_EVENT";
            this.nAMEOFEVENTDataGridViewTextBoxColumn.Name = "nAMEOFEVENTDataGridViewTextBoxColumn";
            // 
            // nAMEOFCOLLEGEDataGridViewTextBoxColumn
            // 
            this.nAMEOFCOLLEGEDataGridViewTextBoxColumn.DataPropertyName = "NAME_OF_COLLEGE";
            this.nAMEOFCOLLEGEDataGridViewTextBoxColumn.HeaderText = "NAME_OF_COLLEGE";
            this.nAMEOFCOLLEGEDataGridViewTextBoxColumn.Name = "nAMEOFCOLLEGEDataGridViewTextBoxColumn";
            // 
            // uPLOADDataGridViewTextBoxColumn
            // 
            this.uPLOADDataGridViewTextBoxColumn.DataPropertyName = "UPLOAD";
            this.uPLOADDataGridViewTextBoxColumn.HeaderText = "UPLOAD";
            this.uPLOADDataGridViewTextBoxColumn.Name = "uPLOADDataGridViewTextBoxColumn";
            // 
            // dOCUMENTSBindingSource
            // 
            this.dOCUMENTSBindingSource.DataMember = "DOCUMENTS";
            this.dOCUMENTSBindingSource.DataSource = this.dataDataSet5;
            // 
            // dataDataSet5
            // 
            this.dataDataSet5.DataSetName = "DataDataSet5";
            this.dataDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOCUMENTSTableAdapter
            // 
            this.dOCUMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CERTIFICATES";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "SHOW ALL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(538, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "GO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "SEARCH";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(354, 464);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 31);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(848, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "LOGOUT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(658, 508);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "PRINT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ADMINCERTIFICATES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::studentprofiledesign1.Properties.Resources._1d04fce092ebb7401e9a7169bd4a9e58__herta_ppt_template;
            this.ClientSize = new System.Drawing.Size(1020, 742);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ADMINCERTIFICATES";
            this.Text = "ADMINCERTIFICATES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ADMINCERTIFICATES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataDataSet5 dataDataSet5;
        private System.Windows.Forms.BindingSource dOCUMENTSBindingSource;
        private DataDataSet5TableAdapters.DOCUMENTSTableAdapter dOCUMENTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNROLLMENTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cERTIFICATENODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEOFEVENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEOFCOLLEGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPLOADDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}