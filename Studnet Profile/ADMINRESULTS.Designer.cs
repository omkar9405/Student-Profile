namespace studentprofiledesign1
{
    partial class ADMINRESULTS
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eNROLLMENTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOURSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCADEMICYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUB1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUB2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUB3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUB4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUB5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUB6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERCENTAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sESSIONALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbRESULTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet1 = new studentprofiledesign1.DataDataSet1();
            this.tbRESULTTableAdapter = new studentprofiledesign1.DataDataSet1TableAdapters.tbRESULTTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRESULTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "RESULTS";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(937, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 35);
            this.button4.TabIndex = 13;
            this.button4.Text = "LOGOUT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(295, 602);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 31);
            this.textBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 605);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "SEARCH";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 602);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "GO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "SHOW ALL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eNROLLMENTNODataGridViewTextBoxColumn,
            this.cOURSEDataGridViewTextBoxColumn,
            this.aCADEMICYEARDataGridViewTextBoxColumn,
            this.sUB1DataGridViewTextBoxColumn,
            this.sUB2DataGridViewTextBoxColumn,
            this.sUB3DataGridViewTextBoxColumn,
            this.sUB4DataGridViewTextBoxColumn,
            this.sUB5DataGridViewTextBoxColumn,
            this.sUB6DataGridViewTextBoxColumn,
            this.tOTALDataGridViewTextBoxColumn,
            this.pERCENTAGEDataGridViewTextBoxColumn,
            this.sESSIONALDataGridViewTextBoxColumn,
            this.iMAGEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbRESULTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1006, 497);
            this.dataGridView1.TabIndex = 14;
            // 
            // eNROLLMENTNODataGridViewTextBoxColumn
            // 
            this.eNROLLMENTNODataGridViewTextBoxColumn.DataPropertyName = "ENROLLMENT_NO";
            this.eNROLLMENTNODataGridViewTextBoxColumn.HeaderText = "ENROLLMENT_NO";
            this.eNROLLMENTNODataGridViewTextBoxColumn.Name = "eNROLLMENTNODataGridViewTextBoxColumn";
            // 
            // cOURSEDataGridViewTextBoxColumn
            // 
            this.cOURSEDataGridViewTextBoxColumn.DataPropertyName = "COURSE";
            this.cOURSEDataGridViewTextBoxColumn.HeaderText = "COURSE";
            this.cOURSEDataGridViewTextBoxColumn.Name = "cOURSEDataGridViewTextBoxColumn";
            // 
            // aCADEMICYEARDataGridViewTextBoxColumn
            // 
            this.aCADEMICYEARDataGridViewTextBoxColumn.DataPropertyName = "ACADEMIC_YEAR";
            this.aCADEMICYEARDataGridViewTextBoxColumn.HeaderText = "ACADEMIC_YEAR";
            this.aCADEMICYEARDataGridViewTextBoxColumn.Name = "aCADEMICYEARDataGridViewTextBoxColumn";
            // 
            // sUB1DataGridViewTextBoxColumn
            // 
            this.sUB1DataGridViewTextBoxColumn.DataPropertyName = "SUB_1";
            this.sUB1DataGridViewTextBoxColumn.HeaderText = "SUB_1";
            this.sUB1DataGridViewTextBoxColumn.Name = "sUB1DataGridViewTextBoxColumn";
            // 
            // sUB2DataGridViewTextBoxColumn
            // 
            this.sUB2DataGridViewTextBoxColumn.DataPropertyName = "SUB_2";
            this.sUB2DataGridViewTextBoxColumn.HeaderText = "SUB_2";
            this.sUB2DataGridViewTextBoxColumn.Name = "sUB2DataGridViewTextBoxColumn";
            // 
            // sUB3DataGridViewTextBoxColumn
            // 
            this.sUB3DataGridViewTextBoxColumn.DataPropertyName = "SUB_3";
            this.sUB3DataGridViewTextBoxColumn.HeaderText = "SUB_3";
            this.sUB3DataGridViewTextBoxColumn.Name = "sUB3DataGridViewTextBoxColumn";
            // 
            // sUB4DataGridViewTextBoxColumn
            // 
            this.sUB4DataGridViewTextBoxColumn.DataPropertyName = "SUB_4";
            this.sUB4DataGridViewTextBoxColumn.HeaderText = "SUB_4";
            this.sUB4DataGridViewTextBoxColumn.Name = "sUB4DataGridViewTextBoxColumn";
            // 
            // sUB5DataGridViewTextBoxColumn
            // 
            this.sUB5DataGridViewTextBoxColumn.DataPropertyName = "SUB_5";
            this.sUB5DataGridViewTextBoxColumn.HeaderText = "SUB_5";
            this.sUB5DataGridViewTextBoxColumn.Name = "sUB5DataGridViewTextBoxColumn";
            // 
            // sUB6DataGridViewTextBoxColumn
            // 
            this.sUB6DataGridViewTextBoxColumn.DataPropertyName = "SUB_6";
            this.sUB6DataGridViewTextBoxColumn.HeaderText = "SUB_6";
            this.sUB6DataGridViewTextBoxColumn.Name = "sUB6DataGridViewTextBoxColumn";
            // 
            // tOTALDataGridViewTextBoxColumn
            // 
            this.tOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.Name = "tOTALDataGridViewTextBoxColumn";
            // 
            // pERCENTAGEDataGridViewTextBoxColumn
            // 
            this.pERCENTAGEDataGridViewTextBoxColumn.DataPropertyName = "PERCENTAGE";
            this.pERCENTAGEDataGridViewTextBoxColumn.HeaderText = "PERCENTAGE";
            this.pERCENTAGEDataGridViewTextBoxColumn.Name = "pERCENTAGEDataGridViewTextBoxColumn";
            // 
            // sESSIONALDataGridViewTextBoxColumn
            // 
            this.sESSIONALDataGridViewTextBoxColumn.DataPropertyName = "SESSIONAL";
            this.sESSIONALDataGridViewTextBoxColumn.HeaderText = "SESSIONAL";
            this.sESSIONALDataGridViewTextBoxColumn.Name = "sESSIONALDataGridViewTextBoxColumn";
            // 
            // iMAGEDataGridViewTextBoxColumn
            // 
            this.iMAGEDataGridViewTextBoxColumn.DataPropertyName = "IMAGE";
            this.iMAGEDataGridViewTextBoxColumn.HeaderText = "IMAGE";
            this.iMAGEDataGridViewTextBoxColumn.Name = "iMAGEDataGridViewTextBoxColumn";
            // 
            // tbRESULTBindingSource
            // 
            this.tbRESULTBindingSource.DataMember = "tbRESULT";
            this.tbRESULTBindingSource.DataSource = this.dataDataSet1;
            // 
            // dataDataSet1
            // 
            this.dataDataSet1.DataSetName = "DataDataSet1";
            this.dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbRESULTTableAdapter
            // 
            this.tbRESULTTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(732, 604);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 30);
            this.button5.TabIndex = 15;
            this.button5.Text = "PRINT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ADMINRESULTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::studentprofiledesign1.Properties.Resources._87e6267127e79f5283c00ccaf6e6f0fd__powerpoint_themes_powerpoint_presentations;
            this.ClientSize = new System.Drawing.Size(1028, 750);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ADMINRESULTS";
            this.Text = "ADMINRESULTS";
            this.Load += new System.EventHandler(this.ADMINRESULTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRESULTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataDataSet1 dataDataSet1;
        private System.Windows.Forms.BindingSource tbRESULTBindingSource;
        private DataDataSet1TableAdapters.tbRESULTTableAdapter tbRESULTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNROLLMENTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOURSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCADEMICYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUB1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUB2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUB3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUB4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUB5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUB6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERCENTAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sESSIONALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}