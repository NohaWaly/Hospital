namespace Project
{
    partial class Form4
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
            this.ID = new System.Windows.Forms.Label();
            this.DepCode = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.NurseName = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eMPLOYEEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEGENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nURSEBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalBDDataSet2 = new Project.HospitalBDDataSet2();
            this.nURSEBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalBDDataSet = new Project.HospitalBDDataSet();
            this.nURSETableAdapter = new Project.HospitalBDDataSetTableAdapters.NURSETableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.nURSEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalBDDataSet1 = new Project.HospitalBDDataSet1();
            this.nURSEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nURSETableAdapter1 = new Project.HospitalBDDataSet1TableAdapters.NURSETableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.nURSEBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.nURSEBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEETableAdapter = new Project.HospitalBDDataSetTableAdapters.EMPLOYEETableAdapter();
            this.eMPLOYEEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEETableAdapter1 = new Project.HospitalBDDataSet1TableAdapters.EMPLOYEETableAdapter();
            this.eMPLOYEETableAdapter2 = new Project.HospitalBDDataSet2TableAdapters.EMPLOYEETableAdapter();
            this.nURSETableAdapter2 = new Project.HospitalBDDataSet2TableAdapters.NURSETableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(36, 77);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(68, 20);
            this.ID.TabIndex = 1;
            this.ID.Text = "NurseID";
            // 
            // DepCode
            // 
            this.DepCode.AutoSize = true;
            this.DepCode.Location = new System.Drawing.Point(31, 201);
            this.DepCode.Name = "DepCode";
            this.DepCode.Size = new System.Drawing.Size(136, 20);
            this.DepCode.TabIndex = 2;
            this.DepCode.Text = "Department Code";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(31, 159);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(127, 20);
            this.phone.TabIndex = 3;
            this.phone.Text = "Nurse Phone no.";
            // 
            // NurseName
            // 
            this.NurseName.AutoSize = true;
            this.NurseName.Location = new System.Drawing.Point(36, 119);
            this.NurseName.Name = "NurseName";
            this.NurseName.Size = new System.Drawing.Size(93, 20);
            this.NurseName.TabIndex = 4;
            this.NurseName.Text = "NurseName";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(36, 240);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(90, 20);
            this.DOB.TabIndex = 5;
            this.DOB.Text = "Nurse DOB";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(36, 283);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(114, 20);
            this.address.TabIndex = 6;
            this.address.Text = "Nurse Address";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(36, 330);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(109, 20);
            this.gender.TabIndex = 7;
            this.gender.Text = "Nurse Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(522, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 37);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nurse";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(197, 237);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(197, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(197, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(197, 201);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(197, 324);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 26);
            this.textBox6.TabIndex = 14;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(197, 277);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 26);
            this.textBox7.TabIndex = 15;
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
            this.eMPLOYEEGENDERDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nURSEBindingSource6;
            this.dataGridView1.Location = new System.Drawing.Point(322, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(910, 320);
            this.dataGridView1.TabIndex = 17;
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
            // nURSEBindingSource6
            // 
            this.nURSEBindingSource6.DataMember = "NURSE";
            this.nURSEBindingSource6.DataSource = this.hospitalBDDataSet2;
            // 
            // hospitalBDDataSet2
            // 
            this.hospitalBDDataSet2.DataSetName = "HospitalBDDataSet2";
            this.hospitalBDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nURSEBindingSource5
            // 
            this.nURSEBindingSource5.DataMember = "NURSE";
            this.nURSEBindingSource5.DataSource = this.hospitalBDDataSet2;
            // 
            // eMPLOYEEBindingSource2
            // 
            this.eMPLOYEEBindingSource2.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource2.DataSource = this.hospitalBDDataSet2;
            // 
            // nURSEBindingSource
            // 
            this.nURSEBindingSource.DataMember = "NURSE";
            this.nURSEBindingSource.DataSource = this.hospitalBDDataSet;
            // 
            // hospitalBDDataSet
            // 
            this.hospitalBDDataSet.DataSetName = "HospitalBDDataSet";
            this.hospitalBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nURSETableAdapter
            // 
            this.nURSETableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nURSEBindingSource1
            // 
            this.nURSEBindingSource1.DataMember = "NURSE";
            this.nURSEBindingSource1.DataSource = this.hospitalBDDataSet;
            // 
            // hospitalBDDataSet1
            // 
            this.hospitalBDDataSet1.DataSetName = "HospitalBDDataSet1";
            this.hospitalBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nURSEBindingSource2
            // 
            this.nURSEBindingSource2.DataMember = "NURSE";
            this.nURSEBindingSource2.DataSource = this.hospitalBDDataSet1;
            // 
            // nURSETableAdapter1
            // 
            this.nURSETableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "Delete by ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(468, 435);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 38);
            this.button3.TabIndex = 20;
            this.button3.Text = "update by ID";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(834, 437);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 38);
            this.button4.TabIndex = 21;
            this.button4.Text = "Show data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1025, 438);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 37);
            this.button5.TabIndex = 22;
            this.button5.Text = "select form";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // nURSEBindingSource3
            // 
            this.nURSEBindingSource3.DataMember = "NURSE";
            this.nURSEBindingSource3.DataSource = this.hospitalBDDataSet1;
            // 
            // nURSEBindingSource4
            // 
            this.nURSEBindingSource4.DataMember = "NURSE";
            this.nURSEBindingSource4.DataSource = this.hospitalBDDataSet;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.hospitalBDDataSet;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // eMPLOYEEBindingSource1
            // 
            this.eMPLOYEEBindingSource1.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource1.DataSource = this.hospitalBDDataSet1;
            // 
            // eMPLOYEETableAdapter1
            // 
            this.eMPLOYEETableAdapter1.ClearBeforeFill = true;
            // 
            // eMPLOYEETableAdapter2
            // 
            this.eMPLOYEETableAdapter2.ClearBeforeFill = true;
            // 
            // nURSETableAdapter2
            // 
            this.nURSETableAdapter2.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(303, 436);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 37);
            this.button6.TabIndex = 23;
            this.button6.Text = "Delete by Name";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(631, 436);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(168, 38);
            this.button7.TabIndex = 24;
            this.button7.Text = "update by Name";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 515);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
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
            this.Controls.Add(this.NurseName);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.DepCode);
            this.Controls.Add(this.ID);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label DepCode;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label NurseName;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HospitalBDDataSet hospitalBDDataSet;
        private System.Windows.Forms.BindingSource nURSEBindingSource;
        private HospitalBDDataSetTableAdapters.NURSETableAdapter nURSETableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource nURSEBindingSource1;
        private HospitalBDDataSet1 hospitalBDDataSet1;
        private System.Windows.Forms.BindingSource nURSEBindingSource2;
        private HospitalBDDataSet1TableAdapters.NURSETableAdapter nURSETableAdapter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource nURSEBindingSource3;
        private System.Windows.Forms.BindingSource nURSEBindingSource4;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private HospitalBDDataSetTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource1;
        private HospitalBDDataSet1TableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter1;
        private HospitalBDDataSet2 hospitalBDDataSet2;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource2;
        private HospitalBDDataSet2TableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter2;
        private System.Windows.Forms.BindingSource nURSEBindingSource5;
        private HospitalBDDataSet2TableAdapters.NURSETableAdapter nURSETableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEGENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nURSEBindingSource6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}