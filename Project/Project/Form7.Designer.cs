namespace Project
{
    partial class Form7
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
            System.Windows.Forms.Label eMPLOYEE_IDLabel;
            System.Windows.Forms.Label dEP_CODELabel;
            System.Windows.Forms.Label pHONE_NO_Label;
            System.Windows.Forms.Label eMPLOYEE_NAMELabel;
            System.Windows.Forms.Label eMPLOYEE_DOBLabel;
            System.Windows.Forms.Label eMPLOYEE_ADDRESSLabel;
            System.Windows.Forms.Label eMPLOYEE_GENDERLabel;
            System.Windows.Forms.Label rANKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.hospitalBDDataSet2 = new Project.HospitalBDDataSet2();
            this.dOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOCTORTableAdapter = new Project.HospitalBDDataSet2TableAdapters.DOCTORTableAdapter();
            this.tableAdapterManager = new Project.HospitalBDDataSet2TableAdapters.TableAdapterManager();
            this.dOCTORBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dOCTORBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dOCTORDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEE_IDTextBox = new System.Windows.Forms.TextBox();
            this.dEP_CODETextBox = new System.Windows.Forms.TextBox();
            this.pHONE_NO_TextBox = new System.Windows.Forms.TextBox();
            this.eMPLOYEE_NAMETextBox = new System.Windows.Forms.TextBox();
            this.eMPLOYEE_DOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eMPLOYEE_ADDRESSTextBox = new System.Windows.Forms.TextBox();
            this.eMPLOYEE_GENDERTextBox = new System.Windows.Forms.TextBox();
            this.rANKTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            eMPLOYEE_IDLabel = new System.Windows.Forms.Label();
            dEP_CODELabel = new System.Windows.Forms.Label();
            pHONE_NO_Label = new System.Windows.Forms.Label();
            eMPLOYEE_NAMELabel = new System.Windows.Forms.Label();
            eMPLOYEE_DOBLabel = new System.Windows.Forms.Label();
            eMPLOYEE_ADDRESSLabel = new System.Windows.Forms.Label();
            eMPLOYEE_GENDERLabel = new System.Windows.Forms.Label();
            rANKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingNavigator)).BeginInit();
            this.dOCTORBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // eMPLOYEE_IDLabel
            // 
            eMPLOYEE_IDLabel.AutoSize = true;
            eMPLOYEE_IDLabel.Location = new System.Drawing.Point(12, 46);
            eMPLOYEE_IDLabel.Name = "eMPLOYEE_IDLabel";
            eMPLOYEE_IDLabel.Size = new System.Drawing.Size(122, 20);
            eMPLOYEE_IDLabel.TabIndex = 2;
            eMPLOYEE_IDLabel.Text = "EMPLOYEE ID:";
            // 
            // dEP_CODELabel
            // 
            dEP_CODELabel.AutoSize = true;
            dEP_CODELabel.Location = new System.Drawing.Point(12, 78);
            dEP_CODELabel.Name = "dEP_CODELabel";
            dEP_CODELabel.Size = new System.Drawing.Size(96, 20);
            dEP_CODELabel.TabIndex = 4;
            dEP_CODELabel.Text = "DEP CODE:";
            // 
            // pHONE_NO_Label
            // 
            pHONE_NO_Label.AutoSize = true;
            pHONE_NO_Label.Location = new System.Drawing.Point(12, 110);
            pHONE_NO_Label.Name = "pHONE_NO_Label";
            pHONE_NO_Label.Size = new System.Drawing.Size(100, 20);
            pHONE_NO_Label.TabIndex = 6;
            pHONE_NO_Label.Text = "PHONE NO :";
            // 
            // eMPLOYEE_NAMELabel
            // 
            eMPLOYEE_NAMELabel.AutoSize = true;
            eMPLOYEE_NAMELabel.Location = new System.Drawing.Point(12, 142);
            eMPLOYEE_NAMELabel.Name = "eMPLOYEE_NAMELabel";
            eMPLOYEE_NAMELabel.Size = new System.Drawing.Size(151, 20);
            eMPLOYEE_NAMELabel.TabIndex = 8;
            eMPLOYEE_NAMELabel.Text = "EMPLOYEE NAME:";
            // 
            // eMPLOYEE_DOBLabel
            // 
            eMPLOYEE_DOBLabel.AutoSize = true;
            eMPLOYEE_DOBLabel.Location = new System.Drawing.Point(12, 175);
            eMPLOYEE_DOBLabel.Name = "eMPLOYEE_DOBLabel";
            eMPLOYEE_DOBLabel.Size = new System.Drawing.Size(140, 20);
            eMPLOYEE_DOBLabel.TabIndex = 10;
            eMPLOYEE_DOBLabel.Text = "EMPLOYEE DOB:";
            // 
            // eMPLOYEE_ADDRESSLabel
            // 
            eMPLOYEE_ADDRESSLabel.AutoSize = true;
            eMPLOYEE_ADDRESSLabel.Location = new System.Drawing.Point(12, 206);
            eMPLOYEE_ADDRESSLabel.Name = "eMPLOYEE_ADDRESSLabel";
            eMPLOYEE_ADDRESSLabel.Size = new System.Drawing.Size(185, 20);
            eMPLOYEE_ADDRESSLabel.TabIndex = 12;
            eMPLOYEE_ADDRESSLabel.Text = "EMPLOYEE ADDRESS:";
            // 
            // eMPLOYEE_GENDERLabel
            // 
            eMPLOYEE_GENDERLabel.AutoSize = true;
            eMPLOYEE_GENDERLabel.Location = new System.Drawing.Point(12, 238);
            eMPLOYEE_GENDERLabel.Name = "eMPLOYEE_GENDERLabel";
            eMPLOYEE_GENDERLabel.Size = new System.Drawing.Size(175, 20);
            eMPLOYEE_GENDERLabel.TabIndex = 14;
            eMPLOYEE_GENDERLabel.Text = "EMPLOYEE GENDER:";
            // 
            // rANKLabel
            // 
            rANKLabel.AutoSize = true;
            rANKLabel.Location = new System.Drawing.Point(12, 270);
            rANKLabel.Name = "rANKLabel";
            rANKLabel.Size = new System.Drawing.Size(57, 20);
            rANKLabel.TabIndex = 16;
            rANKLabel.Text = "RANK:";
            // 
            // hospitalBDDataSet2
            // 
            this.hospitalBDDataSet2.DataSetName = "HospitalBDDataSet2";
            this.hospitalBDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOCTORBindingSource
            // 
            this.dOCTORBindingSource.DataMember = "DOCTOR";
            this.dOCTORBindingSource.DataSource = this.hospitalBDDataSet2;
            // 
            // dOCTORTableAdapter
            // 
            this.dOCTORTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.DOCTORTableAdapter = this.dOCTORTableAdapter;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.HELP_INTableAdapter = null;
            this.tableAdapterManager.MEDICINETableAdapter = null;
            this.tableAdapterManager.NURSETableAdapter = null;
            this.tableAdapterManager.PATIENTTableAdapter = null;
            this.tableAdapterManager.SURGERYTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.HospitalBDDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VISITORTableAdapter = null;
            // 
            // dOCTORBindingNavigator
            // 
            this.dOCTORBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dOCTORBindingNavigator.BindingSource = this.dOCTORBindingSource;
            this.dOCTORBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dOCTORBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dOCTORBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.dOCTORBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dOCTORBindingNavigatorSaveItem});
            this.dOCTORBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dOCTORBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dOCTORBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dOCTORBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dOCTORBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dOCTORBindingNavigator.Name = "dOCTORBindingNavigator";
            this.dOCTORBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dOCTORBindingNavigator.Size = new System.Drawing.Size(883, 31);
            this.dOCTORBindingNavigator.TabIndex = 0;
            this.dOCTORBindingNavigator.Text = "bindingNavigator1";
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
            // dOCTORBindingNavigatorSaveItem
            // 
            this.dOCTORBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dOCTORBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dOCTORBindingNavigatorSaveItem.Image")));
            this.dOCTORBindingNavigatorSaveItem.Name = "dOCTORBindingNavigatorSaveItem";
            this.dOCTORBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.dOCTORBindingNavigatorSaveItem.Text = "Save Data";
            this.dOCTORBindingNavigatorSaveItem.Click += new System.EventHandler(this.dOCTORBindingNavigatorSaveItem_Click);
            // 
            // dOCTORDataGridView
            // 
            this.dOCTORDataGridView.AutoGenerateColumns = false;
            this.dOCTORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dOCTORDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dOCTORDataGridView.DataSource = this.dOCTORBindingSource;
            this.dOCTORDataGridView.Location = new System.Drawing.Point(16, 299);
            this.dOCTORDataGridView.Name = "dOCTORDataGridView";
            this.dOCTORDataGridView.RowTemplate.Height = 28;
            this.dOCTORDataGridView.Size = new System.Drawing.Size(859, 237);
            this.dOCTORDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EMPLOYEE_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EMPLOYEE_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DEP_CODE";
            this.dataGridViewTextBoxColumn2.HeaderText = "DEP_CODE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PHONE_NO_";
            this.dataGridViewTextBoxColumn3.HeaderText = "PHONE_NO_";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EMPLOYEE_NAME";
            this.dataGridViewTextBoxColumn4.HeaderText = "EMPLOYEE_NAME";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EMPLOYEE_DOB";
            this.dataGridViewTextBoxColumn5.HeaderText = "EMPLOYEE_DOB";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EMPLOYEE_ADDRESS";
            this.dataGridViewTextBoxColumn6.HeaderText = "EMPLOYEE_ADDRESS";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EMPLOYEE_GENDER";
            this.dataGridViewTextBoxColumn7.HeaderText = "EMPLOYEE_GENDER";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RANK";
            this.dataGridViewTextBoxColumn8.HeaderText = "RANK";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // eMPLOYEE_IDTextBox
            // 
            this.eMPLOYEE_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORBindingSource, "EMPLOYEE_ID", true));
            this.eMPLOYEE_IDTextBox.Location = new System.Drawing.Point(203, 43);
            this.eMPLOYEE_IDTextBox.Name = "eMPLOYEE_IDTextBox";
            this.eMPLOYEE_IDTextBox.Size = new System.Drawing.Size(200, 26);
            this.eMPLOYEE_IDTextBox.TabIndex = 3;
            // 
            // dEP_CODETextBox
            // 
            this.dEP_CODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORBindingSource, "DEP_CODE", true));
            this.dEP_CODETextBox.Location = new System.Drawing.Point(203, 75);
            this.dEP_CODETextBox.Name = "dEP_CODETextBox";
            this.dEP_CODETextBox.Size = new System.Drawing.Size(200, 26);
            this.dEP_CODETextBox.TabIndex = 5;
            // 
            // pHONE_NO_TextBox
            // 
            this.pHONE_NO_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORBindingSource, "PHONE_NO_", true));
            this.pHONE_NO_TextBox.Location = new System.Drawing.Point(203, 107);
            this.pHONE_NO_TextBox.Name = "pHONE_NO_TextBox";
            this.pHONE_NO_TextBox.Size = new System.Drawing.Size(200, 26);
            this.pHONE_NO_TextBox.TabIndex = 7;
            // 
            // eMPLOYEE_NAMETextBox
            // 
            this.eMPLOYEE_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORBindingSource, "EMPLOYEE_NAME", true));
            this.eMPLOYEE_NAMETextBox.Location = new System.Drawing.Point(203, 139);
            this.eMPLOYEE_NAMETextBox.Name = "eMPLOYEE_NAMETextBox";
            this.eMPLOYEE_NAMETextBox.Size = new System.Drawing.Size(200, 26);
            this.eMPLOYEE_NAMETextBox.TabIndex = 9;
            // 
            // eMPLOYEE_DOBDateTimePicker
            // 
            this.eMPLOYEE_DOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dOCTORBindingSource, "EMPLOYEE_DOB", true));
            this.eMPLOYEE_DOBDateTimePicker.Location = new System.Drawing.Point(203, 171);
            this.eMPLOYEE_DOBDateTimePicker.Name = "eMPLOYEE_DOBDateTimePicker";
            this.eMPLOYEE_DOBDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.eMPLOYEE_DOBDateTimePicker.TabIndex = 11;
            // 
            // eMPLOYEE_ADDRESSTextBox
            // 
            this.eMPLOYEE_ADDRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORBindingSource, "EMPLOYEE_ADDRESS", true));
            this.eMPLOYEE_ADDRESSTextBox.Location = new System.Drawing.Point(203, 203);
            this.eMPLOYEE_ADDRESSTextBox.Name = "eMPLOYEE_ADDRESSTextBox";
            this.eMPLOYEE_ADDRESSTextBox.Size = new System.Drawing.Size(200, 26);
            this.eMPLOYEE_ADDRESSTextBox.TabIndex = 13;
            // 
            // eMPLOYEE_GENDERTextBox
            // 
            this.eMPLOYEE_GENDERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORBindingSource, "EMPLOYEE_GENDER", true));
            this.eMPLOYEE_GENDERTextBox.Location = new System.Drawing.Point(203, 235);
            this.eMPLOYEE_GENDERTextBox.Name = "eMPLOYEE_GENDERTextBox";
            this.eMPLOYEE_GENDERTextBox.Size = new System.Drawing.Size(200, 26);
            this.eMPLOYEE_GENDERTextBox.TabIndex = 15;
            // 
            // rANKTextBox
            // 
            this.rANKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORBindingSource, "RANK", true));
            this.rANKTextBox.Location = new System.Drawing.Point(203, 267);
            this.rANKTextBox.Name = "rANKTextBox";
            this.rANKTextBox.Size = new System.Drawing.Size(200, 26);
            this.rANKTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 45);
            this.button1.TabIndex = 18;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(eMPLOYEE_IDLabel);
            this.Controls.Add(this.eMPLOYEE_IDTextBox);
            this.Controls.Add(dEP_CODELabel);
            this.Controls.Add(this.dEP_CODETextBox);
            this.Controls.Add(pHONE_NO_Label);
            this.Controls.Add(this.pHONE_NO_TextBox);
            this.Controls.Add(eMPLOYEE_NAMELabel);
            this.Controls.Add(this.eMPLOYEE_NAMETextBox);
            this.Controls.Add(eMPLOYEE_DOBLabel);
            this.Controls.Add(this.eMPLOYEE_DOBDateTimePicker);
            this.Controls.Add(eMPLOYEE_ADDRESSLabel);
            this.Controls.Add(this.eMPLOYEE_ADDRESSTextBox);
            this.Controls.Add(eMPLOYEE_GENDERLabel);
            this.Controls.Add(this.eMPLOYEE_GENDERTextBox);
            this.Controls.Add(rANKLabel);
            this.Controls.Add(this.rANKTextBox);
            this.Controls.Add(this.dOCTORDataGridView);
            this.Controls.Add(this.dOCTORBindingNavigator);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingNavigator)).EndInit();
            this.dOCTORBindingNavigator.ResumeLayout(false);
            this.dOCTORBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HospitalBDDataSet2 hospitalBDDataSet2;
        private System.Windows.Forms.BindingSource dOCTORBindingSource;
        private HospitalBDDataSet2TableAdapters.DOCTORTableAdapter dOCTORTableAdapter;
        private HospitalBDDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dOCTORBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dOCTORBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dOCTORDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox eMPLOYEE_IDTextBox;
        private System.Windows.Forms.TextBox dEP_CODETextBox;
        private System.Windows.Forms.TextBox pHONE_NO_TextBox;
        private System.Windows.Forms.TextBox eMPLOYEE_NAMETextBox;
        private System.Windows.Forms.DateTimePicker eMPLOYEE_DOBDateTimePicker;
        private System.Windows.Forms.TextBox eMPLOYEE_ADDRESSTextBox;
        private System.Windows.Forms.TextBox eMPLOYEE_GENDERTextBox;
        private System.Windows.Forms.TextBox rANKTextBox;
        private System.Windows.Forms.Button button1;
    }
}