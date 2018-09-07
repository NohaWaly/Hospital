namespace Project
{
    partial class Form1
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
            this.patient_ID = new System.Windows.Forms.Label();
            this.patient_DOB = new System.Windows.Forms.Label();
            this.patient_Address = new System.Windows.Forms.Label();
            this.patient_gender = new System.Windows.Forms.Label();
            this.patient_name = new System.Windows.Forms.Label();
            this.Patient = new System.Windows.Forms.Label();
            this.txtboxPname = new System.Windows.Forms.TextBox();
            this.txtboxPaddress = new System.Windows.Forms.TextBox();
            this.txtboxPDOB = new System.Windows.Forms.TextBox();
            this.txtboxPID = new System.Windows.Forms.TextBox();
            this.txtBoxPgender = new System.Windows.Forms.TextBox();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.btnPUpdate = new System.Windows.Forms.Button();
            this.btnPDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pATIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTGENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTCONTACTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalBDDataSet = new Project.HospitalBDDataSet();
            this.btnPdata = new System.Windows.Forms.Button();
            this.patient_contact = new System.Windows.Forms.Label();
            this.txtboxPcontact = new System.Windows.Forms.TextBox();
            this.pATIENTTableAdapter = new Project.HospitalBDDataSetTableAdapters.PATIENTTableAdapter();
            this.btnPSelect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // patient_ID
            // 
            this.patient_ID.AutoSize = true;
            this.patient_ID.Location = new System.Drawing.Point(69, 77);
            this.patient_ID.Name = "patient_ID";
            this.patient_ID.Size = new System.Drawing.Size(26, 20);
            this.patient_ID.TabIndex = 0;
            this.patient_ID.Text = "ID";
            this.patient_ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // patient_DOB
            // 
            this.patient_DOB.AutoSize = true;
            this.patient_DOB.Location = new System.Drawing.Point(69, 215);
            this.patient_DOB.Name = "patient_DOB";
            this.patient_DOB.Size = new System.Drawing.Size(44, 20);
            this.patient_DOB.TabIndex = 1;
            this.patient_DOB.Text = "DOB";
            this.patient_DOB.Click += new System.EventHandler(this.label2_Click);
            // 
            // patient_Address
            // 
            this.patient_Address.AutoSize = true;
            this.patient_Address.Location = new System.Drawing.Point(69, 261);
            this.patient_Address.Name = "patient_Address";
            this.patient_Address.Size = new System.Drawing.Size(68, 20);
            this.patient_Address.TabIndex = 2;
            this.patient_Address.Text = "Address";
            this.patient_Address.Click += new System.EventHandler(this.patient_Address_Click);
            // 
            // patient_gender
            // 
            this.patient_gender.AutoSize = true;
            this.patient_gender.Location = new System.Drawing.Point(69, 167);
            this.patient_gender.Name = "patient_gender";
            this.patient_gender.Size = new System.Drawing.Size(63, 20);
            this.patient_gender.TabIndex = 3;
            this.patient_gender.Text = "Gender";
            // 
            // patient_name
            // 
            this.patient_name.AutoSize = true;
            this.patient_name.Location = new System.Drawing.Point(69, 125);
            this.patient_name.Name = "patient_name";
            this.patient_name.Size = new System.Drawing.Size(51, 20);
            this.patient_name.TabIndex = 4;
            this.patient_name.Text = "Name";
            // 
            // Patient
            // 
            this.Patient.AutoSize = true;
            this.Patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient.Location = new System.Drawing.Point(491, 9);
            this.Patient.Name = "Patient";
            this.Patient.Size = new System.Drawing.Size(116, 37);
            this.Patient.TabIndex = 6;
            this.Patient.Text = "Patient";
            this.Patient.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtboxPname
            // 
            this.txtboxPname.Location = new System.Drawing.Point(222, 119);
            this.txtboxPname.Name = "txtboxPname";
            this.txtboxPname.Size = new System.Drawing.Size(184, 26);
            this.txtboxPname.TabIndex = 7;
            this.txtboxPname.TextChanged += new System.EventHandler(this.txtboxPname_TextChanged);
            // 
            // txtboxPaddress
            // 
            this.txtboxPaddress.Location = new System.Drawing.Point(222, 255);
            this.txtboxPaddress.Name = "txtboxPaddress";
            this.txtboxPaddress.Size = new System.Drawing.Size(184, 26);
            this.txtboxPaddress.TabIndex = 8;
            // 
            // txtboxPDOB
            // 
            this.txtboxPDOB.Location = new System.Drawing.Point(222, 209);
            this.txtboxPDOB.Name = "txtboxPDOB";
            this.txtboxPDOB.Size = new System.Drawing.Size(184, 26);
            this.txtboxPDOB.TabIndex = 9;
            // 
            // txtboxPID
            // 
            this.txtboxPID.Location = new System.Drawing.Point(222, 71);
            this.txtboxPID.Name = "txtboxPID";
            this.txtboxPID.Size = new System.Drawing.Size(184, 26);
            this.txtboxPID.TabIndex = 10;
            this.txtboxPID.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtBoxPgender
            // 
            this.txtBoxPgender.Location = new System.Drawing.Point(222, 167);
            this.txtBoxPgender.Name = "txtBoxPgender";
            this.txtBoxPgender.Size = new System.Drawing.Size(184, 26);
            this.txtBoxPgender.TabIndex = 11;
            // 
            // btnPAdd
            // 
            this.btnPAdd.Location = new System.Drawing.Point(15, 364);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(80, 39);
            this.btnPAdd.TabIndex = 12;
            this.btnPAdd.Text = "Add";
            this.btnPAdd.UseVisualStyleBackColor = true;
            this.btnPAdd.Click += new System.EventHandler(this.btnPAdd_Click);
            // 
            // btnPUpdate
            // 
            this.btnPUpdate.Location = new System.Drawing.Point(124, 364);
            this.btnPUpdate.Name = "btnPUpdate";
            this.btnPUpdate.Size = new System.Drawing.Size(138, 39);
            this.btnPUpdate.TabIndex = 13;
            this.btnPUpdate.Text = "Update by ID";
            this.btnPUpdate.UseVisualStyleBackColor = true;
            this.btnPUpdate.Click += new System.EventHandler(this.btnPUpdate_Click);
            // 
            // btnPDelete
            // 
            this.btnPDelete.Location = new System.Drawing.Point(476, 364);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(143, 39);
            this.btnPDelete.TabIndex = 14;
            this.btnPDelete.Text = "Delete by ID";
            this.btnPDelete.UseVisualStyleBackColor = true;
            this.btnPDelete.Click += new System.EventHandler(this.btnPDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pATIENTIDDataGridViewTextBoxColumn,
            this.pATIENTDOBDataGridViewTextBoxColumn,
            this.pATIENTGENDERDataGridViewTextBoxColumn,
            this.pATIENTNAMEDataGridViewTextBoxColumn,
            this.pATIENTADDRESSDataGridViewTextBoxColumn,
            this.pATIENTCONTACTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pATIENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(520, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(650, 245);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pATIENTIDDataGridViewTextBoxColumn
            // 
            this.pATIENTIDDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_ID";
            this.pATIENTIDDataGridViewTextBoxColumn.HeaderText = "PATIENT_ID";
            this.pATIENTIDDataGridViewTextBoxColumn.Name = "pATIENTIDDataGridViewTextBoxColumn";
            // 
            // pATIENTDOBDataGridViewTextBoxColumn
            // 
            this.pATIENTDOBDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_DOB";
            this.pATIENTDOBDataGridViewTextBoxColumn.HeaderText = "PATIENT_DOB";
            this.pATIENTDOBDataGridViewTextBoxColumn.Name = "pATIENTDOBDataGridViewTextBoxColumn";
            // 
            // pATIENTGENDERDataGridViewTextBoxColumn
            // 
            this.pATIENTGENDERDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_GENDER";
            this.pATIENTGENDERDataGridViewTextBoxColumn.HeaderText = "PATIENT_GENDER";
            this.pATIENTGENDERDataGridViewTextBoxColumn.Name = "pATIENTGENDERDataGridViewTextBoxColumn";
            // 
            // pATIENTNAMEDataGridViewTextBoxColumn
            // 
            this.pATIENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_NAME";
            this.pATIENTNAMEDataGridViewTextBoxColumn.HeaderText = "PATIENT_NAME";
            this.pATIENTNAMEDataGridViewTextBoxColumn.Name = "pATIENTNAMEDataGridViewTextBoxColumn";
            // 
            // pATIENTADDRESSDataGridViewTextBoxColumn
            // 
            this.pATIENTADDRESSDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_ADDRESS";
            this.pATIENTADDRESSDataGridViewTextBoxColumn.HeaderText = "PATIENT_ADDRESS";
            this.pATIENTADDRESSDataGridViewTextBoxColumn.Name = "pATIENTADDRESSDataGridViewTextBoxColumn";
            // 
            // pATIENTCONTACTDataGridViewTextBoxColumn
            // 
            this.pATIENTCONTACTDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_CONTACT";
            this.pATIENTCONTACTDataGridViewTextBoxColumn.HeaderText = "PATIENT_CONTACT";
            this.pATIENTCONTACTDataGridViewTextBoxColumn.Name = "pATIENTCONTACTDataGridViewTextBoxColumn";
            // 
            // pATIENTBindingSource
            // 
            this.pATIENTBindingSource.DataMember = "PATIENT";
            this.pATIENTBindingSource.DataSource = this.hospitalBDDataSet;
            // 
            // hospitalBDDataSet
            // 
            this.hospitalBDDataSet.DataSetName = "HospitalBDDataSet";
            this.hospitalBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPdata
            // 
            this.btnPdata.Location = new System.Drawing.Point(845, 364);
            this.btnPdata.Name = "btnPdata";
            this.btnPdata.Size = new System.Drawing.Size(149, 39);
            this.btnPdata.TabIndex = 16;
            this.btnPdata.Text = "Show Data";
            this.btnPdata.UseVisualStyleBackColor = true;
            this.btnPdata.Click += new System.EventHandler(this.btnPdata_Click);
            // 
            // patient_contact
            // 
            this.patient_contact.AutoSize = true;
            this.patient_contact.Location = new System.Drawing.Point(69, 299);
            this.patient_contact.Name = "patient_contact";
            this.patient_contact.Size = new System.Drawing.Size(65, 20);
            this.patient_contact.TabIndex = 17;
            this.patient_contact.Text = "Contact";
            // 
            // txtboxPcontact
            // 
            this.txtboxPcontact.Location = new System.Drawing.Point(222, 299);
            this.txtboxPcontact.Name = "txtboxPcontact";
            this.txtboxPcontact.Size = new System.Drawing.Size(184, 26);
            this.txtboxPcontact.TabIndex = 18;
            // 
            // pATIENTTableAdapter
            // 
            this.pATIENTTableAdapter.ClearBeforeFill = true;
            // 
            // btnPSelect
            // 
            this.btnPSelect.Location = new System.Drawing.Point(1054, 364);
            this.btnPSelect.Name = "btnPSelect";
            this.btnPSelect.Size = new System.Drawing.Size(116, 39);
            this.btnPSelect.TabIndex = 19;
            this.btnPSelect.Text = "Select form";
            this.btnPSelect.UseVisualStyleBackColor = true;
            this.btnPSelect.Click += new System.EventHandler(this.btnPSelect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 39);
            this.button1.TabIndex = 20;
            this.button1.Text = "Delete by Name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 39);
            this.button2.TabIndex = 21;
            this.button2.Text = "Update by Name";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 438);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPSelect);
            this.Controls.Add(this.txtboxPcontact);
            this.Controls.Add(this.patient_contact);
            this.Controls.Add(this.btnPdata);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPDelete);
            this.Controls.Add(this.btnPUpdate);
            this.Controls.Add(this.btnPAdd);
            this.Controls.Add(this.txtBoxPgender);
            this.Controls.Add(this.txtboxPID);
            this.Controls.Add(this.txtboxPDOB);
            this.Controls.Add(this.txtboxPaddress);
            this.Controls.Add(this.txtboxPname);
            this.Controls.Add(this.Patient);
            this.Controls.Add(this.patient_name);
            this.Controls.Add(this.patient_gender);
            this.Controls.Add(this.patient_Address);
            this.Controls.Add(this.patient_DOB);
            this.Controls.Add(this.patient_ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patient_ID;
        private System.Windows.Forms.Label patient_DOB;
        private System.Windows.Forms.Label patient_Address;
        private System.Windows.Forms.Label patient_gender;
        private System.Windows.Forms.Label patient_name;
        private System.Windows.Forms.Label Patient;
        private System.Windows.Forms.TextBox txtboxPname;
        private System.Windows.Forms.TextBox txtboxPaddress;
        private System.Windows.Forms.TextBox txtboxPDOB;
        private System.Windows.Forms.TextBox txtboxPID;
        private System.Windows.Forms.TextBox txtBoxPgender;
        private System.Windows.Forms.Button btnPAdd;
        private System.Windows.Forms.Button btnPUpdate;
        private System.Windows.Forms.Button btnPDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPdata;
        private System.Windows.Forms.Label patient_contact;
        private System.Windows.Forms.TextBox txtboxPcontact;
        private HospitalBDDataSet hospitalBDDataSet;
        private System.Windows.Forms.BindingSource pATIENTBindingSource;
        private HospitalBDDataSetTableAdapters.PATIENTTableAdapter pATIENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTGENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTCONTACTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

