namespace Project
{
    partial class Form6
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eMPLOYEEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEGENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rANKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalBDDataSet2 = new Project.HospitalBDDataSet2();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.DoctorName = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.DepCode = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.dOCTORTableAdapter = new Project.HospitalBDDataSet2TableAdapters.DOCTORTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(994, 498);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 37);
            this.button5.TabIndex = 43;
            this.button5.Text = "select form";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(798, 498);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 37);
            this.button4.TabIndex = 42;
            this.button4.Text = "Show data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(459, 497);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 38);
            this.button3.TabIndex = 41;
            this.button3.Text = "update by ID";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 37);
            this.button2.TabIndex = 40;
            this.button2.Text = "Delete by ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 37);
            this.button1.TabIndex = 39;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPLOYEEIDDataGridViewTextBoxColumn,
            this.dEPCODEDataGridViewTextBoxColumn,
            this.pHONENODataGridViewTextBoxColumn,
            this.eMPLOYEENAMEDataGridViewTextBoxColumn,
            this.eMPLOYEEDOBDataGridViewTextBoxColumn,
            this.eMPLOYEEADDRESSDataGridViewTextBoxColumn,
            this.eMPLOYEEGENDERDataGridViewTextBoxColumn,
            this.rANKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dOCTORBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(322, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(858, 320);
            this.dataGridView1.TabIndex = 38;
            // 
            // eMPLOYEEIDDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE_ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Name = "eMPLOYEEIDDataGridViewTextBoxColumn";
            // 
            // dEPCODEDataGridViewTextBoxColumn
            // 
            this.dEPCODEDataGridViewTextBoxColumn.DataPropertyName = "DEP_CODE";
            this.dEPCODEDataGridViewTextBoxColumn.HeaderText = "DEP_CODE";
            this.dEPCODEDataGridViewTextBoxColumn.Name = "dEPCODEDataGridViewTextBoxColumn";
            // 
            // pHONENODataGridViewTextBoxColumn
            // 
            this.pHONENODataGridViewTextBoxColumn.DataPropertyName = "PHONE_NO_";
            this.pHONENODataGridViewTextBoxColumn.HeaderText = "PHONE_NO_";
            this.pHONENODataGridViewTextBoxColumn.Name = "pHONENODataGridViewTextBoxColumn";
            // 
            // eMPLOYEENAMEDataGridViewTextBoxColumn
            // 
            this.eMPLOYEENAMEDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_NAME";
            this.eMPLOYEENAMEDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE_NAME";
            this.eMPLOYEENAMEDataGridViewTextBoxColumn.Name = "eMPLOYEENAMEDataGridViewTextBoxColumn";
            // 
            // eMPLOYEEDOBDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEDOBDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_DOB";
            this.eMPLOYEEDOBDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE_DOB";
            this.eMPLOYEEDOBDataGridViewTextBoxColumn.Name = "eMPLOYEEDOBDataGridViewTextBoxColumn";
            // 
            // eMPLOYEEADDRESSDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEADDRESSDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_ADDRESS";
            this.eMPLOYEEADDRESSDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE_ADDRESS";
            this.eMPLOYEEADDRESSDataGridViewTextBoxColumn.Name = "eMPLOYEEADDRESSDataGridViewTextBoxColumn";
            // 
            // eMPLOYEEGENDERDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEGENDERDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_GENDER";
            this.eMPLOYEEGENDERDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE_GENDER";
            this.eMPLOYEEGENDERDataGridViewTextBoxColumn.Name = "eMPLOYEEGENDERDataGridViewTextBoxColumn";
            // 
            // rANKDataGridViewTextBoxColumn
            // 
            this.rANKDataGridViewTextBoxColumn.DataPropertyName = "RANK";
            this.rANKDataGridViewTextBoxColumn.HeaderText = "RANK";
            this.rANKDataGridViewTextBoxColumn.Name = "rANKDataGridViewTextBoxColumn";
            // 
            // dOCTORBindingSource
            // 
            this.dOCTORBindingSource.DataMember = "DOCTOR";
            this.dOCTORBindingSource.DataSource = this.hospitalBDDataSet2;
            // 
            // hospitalBDDataSet2
            // 
            this.hospitalBDDataSet2.DataSetName = "HospitalBDDataSet2";
            this.hospitalBDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(169, 334);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 26);
            this.textBox7.TabIndex = 37;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(169, 381);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 26);
            this.textBox6.TabIndex = 36;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(169, 258);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 35;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(169, 213);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 34;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(169, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 294);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(486, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 37);
            this.label9.TabIndex = 30;
            this.label9.Text = "Doctor";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(8, 387);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(63, 20);
            this.gender.TabIndex = 29;
            this.gender.Text = "Gender";
            this.gender.Click += new System.EventHandler(this.gender_Click);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(8, 340);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(68, 20);
            this.address.TabIndex = 28;
            this.address.Text = "Address";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(8, 297);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(44, 20);
            this.DOB.TabIndex = 27;
            this.DOB.Text = "DOB";
            // 
            // DoctorName
            // 
            this.DoctorName.AutoSize = true;
            this.DoctorName.Location = new System.Drawing.Point(8, 176);
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.Size = new System.Drawing.Size(51, 20);
            this.DoctorName.TabIndex = 26;
            this.DoctorName.Text = "Name";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(3, 216);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(81, 20);
            this.phone.TabIndex = 25;
            this.phone.Text = "Phone no.";
            // 
            // DepCode
            // 
            this.DepCode.AutoSize = true;
            this.DepCode.Location = new System.Drawing.Point(3, 258);
            this.DepCode.Name = "DepCode";
            this.DepCode.Size = new System.Drawing.Size(136, 20);
            this.DepCode.TabIndex = 24;
            this.DepCode.Text = "Department Code";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(8, 134);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 23;
            this.ID.Text = "ID";
            // 
            // dOCTORTableAdapter
            // 
            this.dOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Rank";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(168, 426);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 26);
            this.textBox8.TabIndex = 45;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(294, 499);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 37);
            this.button6.TabIndex = 46;
            this.button6.Text = "Delete by Name";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(626, 497);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 38);
            this.button7.TabIndex = 47;
            this.button7.Text = "update by name";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 604);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.address);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.DoctorName);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.DepCode);
            this.Controls.Add(this.ID);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label DoctorName;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label DepCode;
        private System.Windows.Forms.Label ID;
        private HospitalBDDataSet2 hospitalBDDataSet2;
        private System.Windows.Forms.BindingSource dOCTORBindingSource;
        private HospitalBDDataSet2TableAdapters.DOCTORTableAdapter dOCTORTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEGENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rANKDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}