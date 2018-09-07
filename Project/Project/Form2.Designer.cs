namespace Project
{
    partial class Form2
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
            System.Windows.Forms.Label pATIENT_IDLabel;
            System.Windows.Forms.Label pATIENT_DOBLabel;
            System.Windows.Forms.Label pATIENT_GENDERLabel;
            System.Windows.Forms.Label pATIENT_NAMELabel;
            System.Windows.Forms.Label pATIENT_ADDRESSLabel;
            System.Windows.Forms.Label pATIENT_CONTACTLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hospitalBDDataSet = new Project.HospitalBDDataSet();
            this.hospitalBDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pATIENTTableAdapter = new Project.HospitalBDDataSetTableAdapters.PATIENTTableAdapter();
            this.sURGERYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sURGERYTableAdapter = new Project.HospitalBDDataSetTableAdapters.SURGERYTableAdapter();
            this.tableAdapterManager = new Project.HospitalBDDataSetTableAdapters.TableAdapterManager();
            this.pATIENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pATIENT_IDTextBox = new System.Windows.Forms.TextBox();
            this.pATIENT_DOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pATIENT_GENDERTextBox = new System.Windows.Forms.TextBox();
            this.pATIENT_NAMETextBox = new System.Windows.Forms.TextBox();
            this.pATIENT_ADDRESSTextBox = new System.Windows.Forms.TextBox();
            this.pATIENT_CONTACTTextBox = new System.Windows.Forms.TextBox();
            this.pATIENTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            pATIENT_IDLabel = new System.Windows.Forms.Label();
            pATIENT_DOBLabel = new System.Windows.Forms.Label();
            pATIENT_GENDERLabel = new System.Windows.Forms.Label();
            pATIENT_NAMELabel = new System.Windows.Forms.Label();
            pATIENT_ADDRESSLabel = new System.Windows.Forms.Label();
            pATIENT_CONTACTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sURGERYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pATIENT_IDLabel
            // 
            pATIENT_IDLabel.AutoSize = true;
            pATIENT_IDLabel.Location = new System.Drawing.Point(22, 121);
            pATIENT_IDLabel.Name = "pATIENT_IDLabel";
            pATIENT_IDLabel.Size = new System.Drawing.Size(100, 20);
            pATIENT_IDLabel.TabIndex = 4;
            pATIENT_IDLabel.Text = "PATIENT ID:";
            // 
            // pATIENT_DOBLabel
            // 
            pATIENT_DOBLabel.AutoSize = true;
            pATIENT_DOBLabel.Location = new System.Drawing.Point(22, 157);
            pATIENT_DOBLabel.Name = "pATIENT_DOBLabel";
            pATIENT_DOBLabel.Size = new System.Drawing.Size(118, 20);
            pATIENT_DOBLabel.TabIndex = 6;
            pATIENT_DOBLabel.Text = "PATIENT DOB:";
            // 
            // pATIENT_GENDERLabel
            // 
            pATIENT_GENDERLabel.AutoSize = true;
            pATIENT_GENDERLabel.Location = new System.Drawing.Point(22, 188);
            pATIENT_GENDERLabel.Name = "pATIENT_GENDERLabel";
            pATIENT_GENDERLabel.Size = new System.Drawing.Size(153, 20);
            pATIENT_GENDERLabel.TabIndex = 8;
            pATIENT_GENDERLabel.Text = "PATIENT GENDER:";
            // 
            // pATIENT_NAMELabel
            // 
            pATIENT_NAMELabel.AutoSize = true;
            pATIENT_NAMELabel.Location = new System.Drawing.Point(22, 220);
            pATIENT_NAMELabel.Name = "pATIENT_NAMELabel";
            pATIENT_NAMELabel.Size = new System.Drawing.Size(129, 20);
            pATIENT_NAMELabel.TabIndex = 10;
            pATIENT_NAMELabel.Text = "PATIENT NAME:";
            // 
            // pATIENT_ADDRESSLabel
            // 
            pATIENT_ADDRESSLabel.AutoSize = true;
            pATIENT_ADDRESSLabel.Location = new System.Drawing.Point(22, 252);
            pATIENT_ADDRESSLabel.Name = "pATIENT_ADDRESSLabel";
            pATIENT_ADDRESSLabel.Size = new System.Drawing.Size(163, 20);
            pATIENT_ADDRESSLabel.TabIndex = 12;
            pATIENT_ADDRESSLabel.Text = "PATIENT ADDRESS:";
            // 
            // pATIENT_CONTACTLabel
            // 
            pATIENT_CONTACTLabel.AutoSize = true;
            pATIENT_CONTACTLabel.Location = new System.Drawing.Point(22, 284);
            pATIENT_CONTACTLabel.Name = "pATIENT_CONTACTLabel";
            pATIENT_CONTACTLabel.Size = new System.Drawing.Size(157, 20);
            pATIENT_CONTACTLabel.TabIndex = 14;
            pATIENT_CONTACTLabel.Text = "PATIENT CONTACT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Form";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // hospitalBDDataSet
            // 
            this.hospitalBDDataSet.DataSetName = "HospitalBDDataSet";
            this.hospitalBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalBDDataSetBindingSource
            // 
            this.hospitalBDDataSetBindingSource.DataSource = this.hospitalBDDataSet;
            this.hospitalBDDataSetBindingSource.Position = 0;
            // 
            // pATIENTBindingSource
            // 
            this.pATIENTBindingSource.DataMember = "PATIENT";
            this.pATIENTBindingSource.DataSource = this.hospitalBDDataSetBindingSource;
            // 
            // pATIENTTableAdapter
            // 
            this.pATIENTTableAdapter.ClearBeforeFill = true;
            // 
            // sURGERYBindingSource
            // 
            this.sURGERYBindingSource.DataMember = "SURGERY";
            this.sURGERYBindingSource.DataSource = this.hospitalBDDataSet;
            // 
            // sURGERYTableAdapter
            // 
            this.sURGERYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APPOINTMENTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BEDTableAdapter = null;
            this.tableAdapterManager.BILLTableAdapter = null;
            this.tableAdapterManager.BUYTableAdapter = null;
            this.tableAdapterManager.CARRY_OUTTableAdapter = null;
            this.tableAdapterManager.DEPARTMENTTableAdapter = null;
            this.tableAdapterManager.DOCTORTableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.HELP_INTableAdapter = null;
            this.tableAdapterManager.MEDICINETableAdapter = null;
            this.tableAdapterManager.NURSETableAdapter = null;
            this.tableAdapterManager.PATIENTTableAdapter = this.pATIENTTableAdapter;
            this.tableAdapterManager.SURGERYTableAdapter = this.sURGERYTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project.HospitalBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VISITORTableAdapter = null;
            // 
            // pATIENTBindingSource1
            // 
            this.pATIENTBindingSource1.DataMember = "PATIENT";
            this.pATIENTBindingSource1.DataSource = this.hospitalBDDataSet;
            // 
            // pATIENT_IDTextBox
            // 
            this.pATIENT_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource1, "PATIENT_ID", true));
            this.pATIENT_IDTextBox.Location = new System.Drawing.Point(191, 121);
            this.pATIENT_IDTextBox.Name = "pATIENT_IDTextBox";
            this.pATIENT_IDTextBox.Size = new System.Drawing.Size(200, 26);
            this.pATIENT_IDTextBox.TabIndex = 5;
            // 
            // pATIENT_DOBDateTimePicker
            // 
            this.pATIENT_DOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pATIENTBindingSource1, "PATIENT_DOB", true));
            this.pATIENT_DOBDateTimePicker.Location = new System.Drawing.Point(191, 153);
            this.pATIENT_DOBDateTimePicker.Name = "pATIENT_DOBDateTimePicker";
            this.pATIENT_DOBDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.pATIENT_DOBDateTimePicker.TabIndex = 7;
            // 
            // pATIENT_GENDERTextBox
            // 
            this.pATIENT_GENDERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource1, "PATIENT_GENDER", true));
            this.pATIENT_GENDERTextBox.Location = new System.Drawing.Point(191, 185);
            this.pATIENT_GENDERTextBox.Name = "pATIENT_GENDERTextBox";
            this.pATIENT_GENDERTextBox.Size = new System.Drawing.Size(200, 26);
            this.pATIENT_GENDERTextBox.TabIndex = 9;
            // 
            // pATIENT_NAMETextBox
            // 
            this.pATIENT_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource1, "PATIENT_NAME", true));
            this.pATIENT_NAMETextBox.Location = new System.Drawing.Point(191, 217);
            this.pATIENT_NAMETextBox.Name = "pATIENT_NAMETextBox";
            this.pATIENT_NAMETextBox.Size = new System.Drawing.Size(200, 26);
            this.pATIENT_NAMETextBox.TabIndex = 11;
            // 
            // pATIENT_ADDRESSTextBox
            // 
            this.pATIENT_ADDRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource1, "PATIENT_ADDRESS", true));
            this.pATIENT_ADDRESSTextBox.Location = new System.Drawing.Point(191, 249);
            this.pATIENT_ADDRESSTextBox.Name = "pATIENT_ADDRESSTextBox";
            this.pATIENT_ADDRESSTextBox.Size = new System.Drawing.Size(200, 26);
            this.pATIENT_ADDRESSTextBox.TabIndex = 13;
            // 
            // pATIENT_CONTACTTextBox
            // 
            this.pATIENT_CONTACTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource1, "PATIENT_CONTACT", true));
            this.pATIENT_CONTACTTextBox.Location = new System.Drawing.Point(191, 281);
            this.pATIENT_CONTACTTextBox.Name = "pATIENT_CONTACTTextBox";
            this.pATIENT_CONTACTTextBox.Size = new System.Drawing.Size(200, 26);
            this.pATIENT_CONTACTTextBox.TabIndex = 15;
            // 
            // pATIENTDataGridView
            // 
            this.pATIENTDataGridView.AutoGenerateColumns = false;
            this.pATIENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pATIENTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pATIENTDataGridView.DataSource = this.pATIENTBindingSource1;
            this.pATIENTDataGridView.Location = new System.Drawing.Point(434, 121);
            this.pATIENTDataGridView.Name = "pATIENTDataGridView";
            this.pATIENTDataGridView.RowTemplate.Height = 28;
            this.pATIENTDataGridView.Size = new System.Drawing.Size(718, 374);
            this.pATIENTDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PATIENT_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PATIENT_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PATIENT_DOB";
            this.dataGridViewTextBoxColumn2.HeaderText = "PATIENT_DOB";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PATIENT_GENDER";
            this.dataGridViewTextBoxColumn3.HeaderText = "PATIENT_GENDER";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PATIENT_NAME";
            this.dataGridViewTextBoxColumn4.HeaderText = "PATIENT_NAME";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PATIENT_ADDRESS";
            this.dataGridViewTextBoxColumn5.HeaderText = "PATIENT_ADDRESS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PATIENT_CONTACT";
            this.dataGridViewTextBoxColumn6.HeaderText = "PATIENT_CONTACT";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pATIENTDataGridView);
            this.Controls.Add(pATIENT_IDLabel);
            this.Controls.Add(this.pATIENT_IDTextBox);
            this.Controls.Add(pATIENT_DOBLabel);
            this.Controls.Add(this.pATIENT_DOBDateTimePicker);
            this.Controls.Add(pATIENT_GENDERLabel);
            this.Controls.Add(this.pATIENT_GENDERTextBox);
            this.Controls.Add(pATIENT_NAMELabel);
            this.Controls.Add(this.pATIENT_NAMETextBox);
            this.Controls.Add(pATIENT_ADDRESSLabel);
            this.Controls.Add(this.pATIENT_ADDRESSTextBox);
            this.Controls.Add(pATIENT_CONTACTLabel);
            this.Controls.Add(this.pATIENT_CONTACTTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sURGERYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource hospitalBDDataSetBindingSource;
        private HospitalBDDataSet hospitalBDDataSet;
        private System.Windows.Forms.BindingSource pATIENTBindingSource;
        private HospitalBDDataSetTableAdapters.PATIENTTableAdapter pATIENTTableAdapter;
        private System.Windows.Forms.BindingSource sURGERYBindingSource;
        private HospitalBDDataSetTableAdapters.SURGERYTableAdapter sURGERYTableAdapter;
        private HospitalBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource pATIENTBindingSource1;
        private System.Windows.Forms.TextBox pATIENT_IDTextBox;
        private System.Windows.Forms.DateTimePicker pATIENT_DOBDateTimePicker;
        private System.Windows.Forms.TextBox pATIENT_GENDERTextBox;
        private System.Windows.Forms.TextBox pATIENT_NAMETextBox;
        private System.Windows.Forms.TextBox pATIENT_ADDRESSTextBox;
        private System.Windows.Forms.TextBox pATIENT_CONTACTTextBox;
        private System.Windows.Forms.DataGridView pATIENTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
    }
}