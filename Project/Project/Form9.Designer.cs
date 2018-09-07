namespace Project
{
    partial class Form9
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
            System.Windows.Forms.Label aPPOINTMENT_NO_Label;
            System.Windows.Forms.Label pATIENT_IDLabel;
            System.Windows.Forms.Label eMPLOYEE_IDLabel;
            System.Windows.Forms.Label aPPOINTMENT_DATELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.hospitalBDDataSet = new Project.HospitalBDDataSet();
            this.aPPOINTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPPOINTMENTTableAdapter = new Project.HospitalBDDataSetTableAdapters.APPOINTMENTTableAdapter();
            this.tableAdapterManager = new Project.HospitalBDDataSetTableAdapters.TableAdapterManager();
            this.aPPOINTMENTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aPPOINTMENTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hospitalBDDataSet2 = new Project.HospitalBDDataSet2();
            this.aPPOINTMENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aPPOINTMENTTableAdapter1 = new Project.HospitalBDDataSet2TableAdapters.APPOINTMENTTableAdapter();
            this.tableAdapterManager1 = new Project.HospitalBDDataSet2TableAdapters.TableAdapterManager();
            this.aPPOINTMENTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPOINTMENT_NO_TextBox = new System.Windows.Forms.TextBox();
            this.pATIENT_IDTextBox = new System.Windows.Forms.TextBox();
            this.eMPLOYEE_IDTextBox = new System.Windows.Forms.TextBox();
            this.aPPOINTMENT_DATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            aPPOINTMENT_NO_Label = new System.Windows.Forms.Label();
            pATIENT_IDLabel = new System.Windows.Forms.Label();
            eMPLOYEE_IDLabel = new System.Windows.Forms.Label();
            aPPOINTMENT_DATELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingNavigator)).BeginInit();
            this.aPPOINTMENTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aPPOINTMENT_NO_Label
            // 
            aPPOINTMENT_NO_Label.AutoSize = true;
            aPPOINTMENT_NO_Label.Location = new System.Drawing.Point(30, 66);
            aPPOINTMENT_NO_Label.Name = "aPPOINTMENT_NO_Label";
            aPPOINTMENT_NO_Label.Size = new System.Drawing.Size(156, 20);
            aPPOINTMENT_NO_Label.TabIndex = 2;
            aPPOINTMENT_NO_Label.Text = "APPOINTMENT NO :";
            // 
            // pATIENT_IDLabel
            // 
            pATIENT_IDLabel.AutoSize = true;
            pATIENT_IDLabel.Location = new System.Drawing.Point(30, 98);
            pATIENT_IDLabel.Name = "pATIENT_IDLabel";
            pATIENT_IDLabel.Size = new System.Drawing.Size(100, 20);
            pATIENT_IDLabel.TabIndex = 4;
            pATIENT_IDLabel.Text = "PATIENT ID:";
            // 
            // eMPLOYEE_IDLabel
            // 
            eMPLOYEE_IDLabel.AutoSize = true;
            eMPLOYEE_IDLabel.Location = new System.Drawing.Point(30, 130);
            eMPLOYEE_IDLabel.Name = "eMPLOYEE_IDLabel";
            eMPLOYEE_IDLabel.Size = new System.Drawing.Size(122, 20);
            eMPLOYEE_IDLabel.TabIndex = 6;
            eMPLOYEE_IDLabel.Text = "EMPLOYEE ID:";
            // 
            // aPPOINTMENT_DATELabel
            // 
            aPPOINTMENT_DATELabel.AutoSize = true;
            aPPOINTMENT_DATELabel.Location = new System.Drawing.Point(30, 163);
            aPPOINTMENT_DATELabel.Name = "aPPOINTMENT_DATELabel";
            aPPOINTMENT_DATELabel.Size = new System.Drawing.Size(172, 20);
            aPPOINTMENT_DATELabel.TabIndex = 8;
            aPPOINTMENT_DATELabel.Text = "APPOINTMENT DATE:";
            // 
            // hospitalBDDataSet
            // 
            this.hospitalBDDataSet.DataSetName = "HospitalBDDataSet";
            this.hospitalBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPPOINTMENTBindingSource
            // 
            this.aPPOINTMENTBindingSource.DataMember = "APPOINTMENT";
            this.aPPOINTMENTBindingSource.DataSource = this.hospitalBDDataSet;
            // 
            // aPPOINTMENTTableAdapter
            // 
            this.aPPOINTMENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APPOINTMENTTableAdapter = this.aPPOINTMENTTableAdapter;
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
            this.tableAdapterManager.PATIENTTableAdapter = null;
            this.tableAdapterManager.SURGERYTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.HospitalBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VISITORTableAdapter = null;
            // 
            // aPPOINTMENTBindingNavigator
            // 
            this.aPPOINTMENTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aPPOINTMENTBindingNavigator.BindingSource = this.aPPOINTMENTBindingSource;
            this.aPPOINTMENTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aPPOINTMENTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aPPOINTMENTBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.aPPOINTMENTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aPPOINTMENTBindingNavigatorSaveItem});
            this.aPPOINTMENTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aPPOINTMENTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aPPOINTMENTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aPPOINTMENTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aPPOINTMENTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aPPOINTMENTBindingNavigator.Name = "aPPOINTMENTBindingNavigator";
            this.aPPOINTMENTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aPPOINTMENTBindingNavigator.Size = new System.Drawing.Size(722, 31);
            this.aPPOINTMENTBindingNavigator.TabIndex = 0;
            this.aPPOINTMENTBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // aPPOINTMENTBindingNavigatorSaveItem
            // 
            this.aPPOINTMENTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aPPOINTMENTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aPPOINTMENTBindingNavigatorSaveItem.Image")));
            this.aPPOINTMENTBindingNavigatorSaveItem.Name = "aPPOINTMENTBindingNavigatorSaveItem";
            this.aPPOINTMENTBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.aPPOINTMENTBindingNavigatorSaveItem.Text = "Save Data";
            this.aPPOINTMENTBindingNavigatorSaveItem.Click += new System.EventHandler(this.aPPOINTMENTBindingNavigatorSaveItem_Click);
            // 
            // hospitalBDDataSet2
            // 
            this.hospitalBDDataSet2.DataSetName = "HospitalBDDataSet2";
            this.hospitalBDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPPOINTMENTBindingSource1
            // 
            this.aPPOINTMENTBindingSource1.DataMember = "APPOINTMENT";
            this.aPPOINTMENTBindingSource1.DataSource = this.hospitalBDDataSet2;
            // 
            // aPPOINTMENTTableAdapter1
            // 
            this.aPPOINTMENTTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.APPOINTMENTTableAdapter = this.aPPOINTMENTTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BEDTableAdapter = null;
            this.tableAdapterManager1.BILLTableAdapter = null;
            this.tableAdapterManager1.BUYTableAdapter = null;
            this.tableAdapterManager1.CARRY_OUTTableAdapter = null;
            this.tableAdapterManager1.DEPARTMENTTableAdapter = null;
            this.tableAdapterManager1.DOCTORTableAdapter = null;
            this.tableAdapterManager1.EMPLOYEETableAdapter = null;
            this.tableAdapterManager1.HELP_INTableAdapter = null;
            this.tableAdapterManager1.MEDICINETableAdapter = null;
            this.tableAdapterManager1.NURSETableAdapter = null;
            this.tableAdapterManager1.PATIENTTableAdapter = null;
            this.tableAdapterManager1.SURGERYTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Project.HospitalBDDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VISITORTableAdapter = null;
            // 
            // aPPOINTMENTDataGridView
            // 
            this.aPPOINTMENTDataGridView.AutoGenerateColumns = false;
            this.aPPOINTMENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aPPOINTMENTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.aPPOINTMENTDataGridView.DataSource = this.aPPOINTMENTBindingSource1;
            this.aPPOINTMENTDataGridView.Location = new System.Drawing.Point(34, 224);
            this.aPPOINTMENTDataGridView.Name = "aPPOINTMENTDataGridView";
            this.aPPOINTMENTDataGridView.RowTemplate.Height = 28;
            this.aPPOINTMENTDataGridView.Size = new System.Drawing.Size(654, 220);
            this.aPPOINTMENTDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "APPOINTMENT_NO_";
            this.dataGridViewTextBoxColumn1.HeaderText = "APPOINTMENT_NO_";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PATIENT_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PATIENT_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EMPLOYEE_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "EMPLOYEE_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "APPOINTMENT_DATE";
            this.dataGridViewTextBoxColumn4.HeaderText = "APPOINTMENT_DATE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // aPPOINTMENT_NO_TextBox
            // 
            this.aPPOINTMENT_NO_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aPPOINTMENTBindingSource1, "APPOINTMENT_NO_", true));
            this.aPPOINTMENT_NO_TextBox.Location = new System.Drawing.Point(208, 63);
            this.aPPOINTMENT_NO_TextBox.Name = "aPPOINTMENT_NO_TextBox";
            this.aPPOINTMENT_NO_TextBox.Size = new System.Drawing.Size(200, 26);
            this.aPPOINTMENT_NO_TextBox.TabIndex = 3;
            // 
            // pATIENT_IDTextBox
            // 
            this.pATIENT_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aPPOINTMENTBindingSource1, "PATIENT_ID", true));
            this.pATIENT_IDTextBox.Location = new System.Drawing.Point(208, 95);
            this.pATIENT_IDTextBox.Name = "pATIENT_IDTextBox";
            this.pATIENT_IDTextBox.Size = new System.Drawing.Size(200, 26);
            this.pATIENT_IDTextBox.TabIndex = 5;
            // 
            // eMPLOYEE_IDTextBox
            // 
            this.eMPLOYEE_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aPPOINTMENTBindingSource1, "EMPLOYEE_ID", true));
            this.eMPLOYEE_IDTextBox.Location = new System.Drawing.Point(208, 127);
            this.eMPLOYEE_IDTextBox.Name = "eMPLOYEE_IDTextBox";
            this.eMPLOYEE_IDTextBox.Size = new System.Drawing.Size(200, 26);
            this.eMPLOYEE_IDTextBox.TabIndex = 7;
            // 
            // aPPOINTMENT_DATEDateTimePicker
            // 
            this.aPPOINTMENT_DATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aPPOINTMENTBindingSource1, "APPOINTMENT_DATE", true));
            this.aPPOINTMENT_DATEDateTimePicker.Location = new System.Drawing.Point(208, 159);
            this.aPPOINTMENT_DATEDateTimePicker.Name = "aPPOINTMENT_DATEDateTimePicker";
            this.aPPOINTMENT_DATEDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.aPPOINTMENT_DATEDateTimePicker.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(aPPOINTMENT_NO_Label);
            this.Controls.Add(this.aPPOINTMENT_NO_TextBox);
            this.Controls.Add(pATIENT_IDLabel);
            this.Controls.Add(this.pATIENT_IDTextBox);
            this.Controls.Add(eMPLOYEE_IDLabel);
            this.Controls.Add(this.eMPLOYEE_IDTextBox);
            this.Controls.Add(aPPOINTMENT_DATELabel);
            this.Controls.Add(this.aPPOINTMENT_DATEDateTimePicker);
            this.Controls.Add(this.aPPOINTMENTDataGridView);
            this.Controls.Add(this.aPPOINTMENTBindingNavigator);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingNavigator)).EndInit();
            this.aPPOINTMENTBindingNavigator.ResumeLayout(false);
            this.aPPOINTMENTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HospitalBDDataSet hospitalBDDataSet;
        private System.Windows.Forms.BindingSource aPPOINTMENTBindingSource;
        private HospitalBDDataSetTableAdapters.APPOINTMENTTableAdapter aPPOINTMENTTableAdapter;
        private HospitalBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aPPOINTMENTBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aPPOINTMENTBindingNavigatorSaveItem;
        private HospitalBDDataSet2 hospitalBDDataSet2;
        private System.Windows.Forms.BindingSource aPPOINTMENTBindingSource1;
        private HospitalBDDataSet2TableAdapters.APPOINTMENTTableAdapter aPPOINTMENTTableAdapter1;
        private HospitalBDDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView aPPOINTMENTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox aPPOINTMENT_NO_TextBox;
        private System.Windows.Forms.TextBox pATIENT_IDTextBox;
        private System.Windows.Forms.TextBox eMPLOYEE_IDTextBox;
        private System.Windows.Forms.DateTimePicker aPPOINTMENT_DATEDateTimePicker;
        private System.Windows.Forms.Button button1;
    }
}