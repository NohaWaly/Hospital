namespace Project
{
    partial class Form8
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hospitalBDDataSet2 = new Project.HospitalBDDataSet2();
            this.aPPOINTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPPOINTMENTTableAdapter = new Project.HospitalBDDataSet2TableAdapters.APPOINTMENTTableAdapter();
            this.aPPOINTMENTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPOINTMENTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnASelect = new System.Windows.Forms.Button();
            this.btnAdata = new System.Windows.Forms.Button();
            this.btnADelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doctor ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(185, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(185, 164);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(185, 209);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aPPOINTMENTNODataGridViewTextBoxColumn,
            this.pATIENTIDDataGridViewTextBoxColumn,
            this.eMPLOYEEIDDataGridViewTextBoxColumn,
            this.aPPOINTMENTDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aPPOINTMENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(350, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(551, 229);
            this.dataGridView1.TabIndex = 8;
            // 
            // hospitalBDDataSet2
            // 
            this.hospitalBDDataSet2.DataSetName = "HospitalBDDataSet2";
            this.hospitalBDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPPOINTMENTBindingSource
            // 
            this.aPPOINTMENTBindingSource.DataMember = "APPOINTMENT";
            this.aPPOINTMENTBindingSource.DataSource = this.hospitalBDDataSet2;
            // 
            // aPPOINTMENTTableAdapter
            // 
            this.aPPOINTMENTTableAdapter.ClearBeforeFill = true;
            // 
            // aPPOINTMENTNODataGridViewTextBoxColumn
            // 
            this.aPPOINTMENTNODataGridViewTextBoxColumn.DataPropertyName = "APPOINTMENT_NO_";
            this.aPPOINTMENTNODataGridViewTextBoxColumn.HeaderText = "APPOINTMENT_NO_";
            this.aPPOINTMENTNODataGridViewTextBoxColumn.Name = "aPPOINTMENTNODataGridViewTextBoxColumn";
            // 
            // pATIENTIDDataGridViewTextBoxColumn
            // 
            this.pATIENTIDDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_ID";
            this.pATIENTIDDataGridViewTextBoxColumn.HeaderText = "PATIENT_ID";
            this.pATIENTIDDataGridViewTextBoxColumn.Name = "pATIENTIDDataGridViewTextBoxColumn";
            // 
            // eMPLOYEEIDDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE_ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Name = "eMPLOYEEIDDataGridViewTextBoxColumn";
            // 
            // aPPOINTMENTDATEDataGridViewTextBoxColumn
            // 
            this.aPPOINTMENTDATEDataGridViewTextBoxColumn.DataPropertyName = "APPOINTMENT_DATE";
            this.aPPOINTMENTDATEDataGridViewTextBoxColumn.HeaderText = "APPOINTMENT_DATE";
            this.aPPOINTMENTDATEDataGridViewTextBoxColumn.Name = "aPPOINTMENTDATEDataGridViewTextBoxColumn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Appointment";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnASelect
            // 
            this.btnASelect.Location = new System.Drawing.Point(785, 316);
            this.btnASelect.Name = "btnASelect";
            this.btnASelect.Size = new System.Drawing.Size(116, 39);
            this.btnASelect.TabIndex = 24;
            this.btnASelect.Text = "Select form";
            this.btnASelect.UseVisualStyleBackColor = true;
            this.btnASelect.Click += new System.EventHandler(this.btnASelect_Click);
            // 
            // btnAdata
            // 
            this.btnAdata.Location = new System.Drawing.Point(484, 316);
            this.btnAdata.Name = "btnAdata";
            this.btnAdata.Size = new System.Drawing.Size(149, 39);
            this.btnAdata.TabIndex = 23;
            this.btnAdata.Text = "Show Data";
            this.btnAdata.UseVisualStyleBackColor = true;
            this.btnAdata.Click += new System.EventHandler(this.btnAdata_Click);
            // 
            // btnADelete
            // 
            this.btnADelete.Location = new System.Drawing.Point(314, 316);
            this.btnADelete.Name = "btnADelete";
            this.btnADelete.Size = new System.Drawing.Size(84, 39);
            this.btnADelete.TabIndex = 22;
            this.btnADelete.Text = "Delete";
            this.btnADelete.UseVisualStyleBackColor = true;
            this.btnADelete.Click += new System.EventHandler(this.btnADelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(32, 316);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(84, 39);
            this.btnadd.TabIndex = 21;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnPUpdate_Click);
            // 
            // btnPAdd
            // 
            this.btnPAdd.Location = new System.Drawing.Point(-112, 277);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(80, 39);
            this.btnPAdd.TabIndex = 20;
            this.btnPAdd.Text = "Add";
            this.btnPAdd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 39);
            this.button1.TabIndex = 25;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnASelect);
            this.Controls.Add(this.btnAdata);
            this.Controls.Add(this.btnADelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnPAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HospitalBDDataSet2 hospitalBDDataSet2;
        private System.Windows.Forms.BindingSource aPPOINTMENTBindingSource;
        private HospitalBDDataSet2TableAdapters.APPOINTMENTTableAdapter aPPOINTMENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPOINTMENTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPOINTMENTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnASelect;
        private System.Windows.Forms.Button btnAdata;
        private System.Windows.Forms.Button btnADelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnPAdd;
        private System.Windows.Forms.Button button1;
    }
}