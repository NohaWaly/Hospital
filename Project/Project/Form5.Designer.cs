namespace Project
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.hospitalBDDataSet2 = new Project.HospitalBDDataSet2();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEETableAdapter = new Project.HospitalBDDataSet2TableAdapters.EMPLOYEETableAdapter();
            this.tableAdapterManager = new Project.HospitalBDDataSet2TableAdapters.TableAdapterManager();
            this.eMPLOYEEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eMPLOYEEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eMPLOYEEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEE_IDTextBox = new System.Windows.Forms.TextBox();
            this.dEP_CODETextBox = new System.Windows.Forms.TextBox();
            this.pHONE_NO_TextBox = new System.Windows.Forms.TextBox();
            this.eMPLOYEE_NAMETextBox = new System.Windows.Forms.TextBox();
            this.eMPLOYEE_DOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eMPLOYEE_ADDRESSTextBox = new System.Windows.Forms.TextBox();
            this.eMPLOYEE_GENDERTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nURSETableAdapter = new Project.HospitalBDDataSet2TableAdapters.NURSETableAdapter();
            eMPLOYEE_IDLabel = new System.Windows.Forms.Label();
            dEP_CODELabel = new System.Windows.Forms.Label();
            pHONE_NO_Label = new System.Windows.Forms.Label();
            eMPLOYEE_NAMELabel = new System.Windows.Forms.Label();
            eMPLOYEE_DOBLabel = new System.Windows.Forms.Label();
            eMPLOYEE_ADDRESSLabel = new System.Windows.Forms.Label();
            eMPLOYEE_GENDERLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingNavigator)).BeginInit();
            this.eMPLOYEEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eMPLOYEE_IDLabel
            // 
            eMPLOYEE_IDLabel.AutoSize = true;
            eMPLOYEE_IDLabel.Location = new System.Drawing.Point(21, 46);
            eMPLOYEE_IDLabel.Name = "eMPLOYEE_IDLabel";
            eMPLOYEE_IDLabel.Size = new System.Drawing.Size(122, 20);
            eMPLOYEE_IDLabel.TabIndex = 2;
            eMPLOYEE_IDLabel.Text = "EMPLOYEE ID:";
            // 
            // dEP_CODELabel
            // 
            dEP_CODELabel.AutoSize = true;
            dEP_CODELabel.Location = new System.Drawing.Point(21, 78);
            dEP_CODELabel.Name = "dEP_CODELabel";
            dEP_CODELabel.Size = new System.Drawing.Size(96, 20);
            dEP_CODELabel.TabIndex = 4;
            dEP_CODELabel.Text = "DEP CODE:";
            // 
            // pHONE_NO_Label
            // 
            pHONE_NO_Label.AutoSize = true;
            pHONE_NO_Label.Location = new System.Drawing.Point(21, 110);
            pHONE_NO_Label.Name = "pHONE_NO_Label";
            pHONE_NO_Label.Size = new System.Drawing.Size(100, 20);
            pHONE_NO_Label.TabIndex = 6;
            pHONE_NO_Label.Text = "PHONE NO :";
            // 
            // eMPLOYEE_NAMELabel
            // 
            eMPLOYEE_NAMELabel.AutoSize = true;
            eMPLOYEE_NAMELabel.Location = new System.Drawing.Point(21, 142);
            eMPLOYEE_NAMELabel.Name = "eMPLOYEE_NAMELabel";
            eMPLOYEE_NAMELabel.Size = new System.Drawing.Size(151, 20);
            eMPLOYEE_NAMELabel.TabIndex = 8;
            eMPLOYEE_NAMELabel.Text = "EMPLOYEE NAME:";
            // 
            // eMPLOYEE_DOBLabel
            // 
            eMPLOYEE_DOBLabel.AutoSize = true;
            eMPLOYEE_DOBLabel.Location = new System.Drawing.Point(21, 175);
            eMPLOYEE_DOBLabel.Name = "eMPLOYEE_DOBLabel";
            eMPLOYEE_DOBLabel.Size = new System.Drawing.Size(140, 20);
            eMPLOYEE_DOBLabel.TabIndex = 10;
            eMPLOYEE_DOBLabel.Text = "EMPLOYEE DOB:";
            // 
            // eMPLOYEE_ADDRESSLabel
            // 
            eMPLOYEE_ADDRESSLabel.AutoSize = true;
            eMPLOYEE_ADDRESSLabel.Location = new System.Drawing.Point(21, 206);
            eMPLOYEE_ADDRESSLabel.Name = "eMPLOYEE_ADDRESSLabel";
            eMPLOYEE_ADDRESSLabel.Size = new System.Drawing.Size(185, 20);
            eMPLOYEE_ADDRESSLabel.TabIndex = 12;
            eMPLOYEE_ADDRESSLabel.Text = "EMPLOYEE ADDRESS:";
            // 
            // eMPLOYEE_GENDERLabel
            // 
            eMPLOYEE_GENDERLabel.AutoSize = true;
            eMPLOYEE_GENDERLabel.Location = new System.Drawing.Point(21, 238);
            eMPLOYEE_GENDERLabel.Name = "eMPLOYEE_GENDERLabel";
            eMPLOYEE_GENDERLabel.Size = new System.Drawing.Size(175, 20);
            eMPLOYEE_GENDERLabel.TabIndex = 14;
            eMPLOYEE_GENDERLabel.Text = "EMPLOYEE GENDER:";
            // 
            // hospitalBDDataSet2
            // 
            this.hospitalBDDataSet2.DataSetName = "HospitalBDDataSet2";
            this.hospitalBDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.hospitalBDDataSet2;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.EMPLOYEETableAdapter = this.eMPLOYEETableAdapter;
            this.tableAdapterManager.HELP_INTableAdapter = null;
            this.tableAdapterManager.MEDICINETableAdapter = null;
            this.tableAdapterManager.NURSETableAdapter = null;
            this.tableAdapterManager.PATIENTTableAdapter = null;
            this.tableAdapterManager.SURGERYTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.HospitalBDDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VISITORTableAdapter = null;
            // 
            // eMPLOYEEBindingNavigator
            // 
            this.eMPLOYEEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eMPLOYEEBindingNavigator.BindingSource = this.eMPLOYEEBindingSource;
            this.eMPLOYEEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eMPLOYEEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eMPLOYEEBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.eMPLOYEEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eMPLOYEEBindingNavigatorSaveItem});
            this.eMPLOYEEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eMPLOYEEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eMPLOYEEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eMPLOYEEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eMPLOYEEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eMPLOYEEBindingNavigator.Name = "eMPLOYEEBindingNavigator";
            this.eMPLOYEEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eMPLOYEEBindingNavigator.Size = new System.Drawing.Size(951, 31);
            this.eMPLOYEEBindingNavigator.TabIndex = 0;
            this.eMPLOYEEBindingNavigator.Text = "bindingNavigator1";
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
            // eMPLOYEEBindingNavigatorSaveItem
            // 
            this.eMPLOYEEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eMPLOYEEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eMPLOYEEBindingNavigatorSaveItem.Image")));
            this.eMPLOYEEBindingNavigatorSaveItem.Name = "eMPLOYEEBindingNavigatorSaveItem";
            this.eMPLOYEEBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.eMPLOYEEBindingNavigatorSaveItem.Text = "Save Data";
            this.eMPLOYEEBindingNavigatorSaveItem.Click += new System.EventHandler(this.eMPLOYEEBindingNavigatorSaveItem_Click);
            // 
            // eMPLOYEEDataGridView
            // 
            this.eMPLOYEEDataGridView.AutoGenerateColumns = false;
            this.eMPLOYEEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eMPLOYEEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.eMPLOYEEDataGridView.DataSource = this.nURSEBindingSource;
            this.eMPLOYEEDataGridView.Location = new System.Drawing.Point(25, 277);
            this.eMPLOYEEDataGridView.Name = "eMPLOYEEDataGridView";
            this.eMPLOYEEDataGridView.RowTemplate.Height = 28;
            this.eMPLOYEEDataGridView.Size = new System.Drawing.Size(891, 230);
            this.eMPLOYEEDataGridView.TabIndex = 1;
            this.eMPLOYEEDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eMPLOYEEDataGridView_CellContentClick);
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
            // eMPLOYEE_IDTextBox
            // 
            this.eMPLOYEE_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "EMPLOYEE_ID", true));
            this.eMPLOYEE_IDTextBox.Location = new System.Drawing.Point(212, 43);
            this.eMPLOYEE_IDTextBox.Name = "eMPLOYEE_IDTextBox";
            this.eMPLOYEE_IDTextBox.Size = new System.Drawing.Size(200, 26);
            this.eMPLOYEE_IDTextBox.TabIndex = 3;
            // 
            // dEP_CODETextBox
            // 
            this.dEP_CODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "DEP_CODE", true));
            this.dEP_CODETextBox.Location = new System.Drawing.Point(212, 75);
            this.dEP_CODETextBox.Name = "dEP_CODETextBox";
            this.dEP_CODETextBox.Size = new System.Drawing.Size(200, 26);
            this.dEP_CODETextBox.TabIndex = 5;
            // 
            // pHONE_NO_TextBox
            // 
            this.pHONE_NO_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "PHONE_NO_", true));
            this.pHONE_NO_TextBox.Location = new System.Drawing.Point(212, 107);
            this.pHONE_NO_TextBox.Name = "pHONE_NO_TextBox";
            this.pHONE_NO_TextBox.Size = new System.Drawing.Size(200, 26);
            this.pHONE_NO_TextBox.TabIndex = 7;
            // 
            // eMPLOYEE_NAMETextBox
            // 
            this.eMPLOYEE_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "EMPLOYEE_NAME", true));
            this.eMPLOYEE_NAMETextBox.Location = new System.Drawing.Point(212, 139);
            this.eMPLOYEE_NAMETextBox.Name = "eMPLOYEE_NAMETextBox";
            this.eMPLOYEE_NAMETextBox.Size = new System.Drawing.Size(200, 26);
            this.eMPLOYEE_NAMETextBox.TabIndex = 9;
            // 
            // eMPLOYEE_DOBDateTimePicker
            // 
            this.eMPLOYEE_DOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eMPLOYEEBindingSource, "EMPLOYEE_DOB", true));
            this.eMPLOYEE_DOBDateTimePicker.Location = new System.Drawing.Point(212, 171);
            this.eMPLOYEE_DOBDateTimePicker.Name = "eMPLOYEE_DOBDateTimePicker";
            this.eMPLOYEE_DOBDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.eMPLOYEE_DOBDateTimePicker.TabIndex = 11;
            // 
            // eMPLOYEE_ADDRESSTextBox
            // 
            this.eMPLOYEE_ADDRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "EMPLOYEE_ADDRESS", true));
            this.eMPLOYEE_ADDRESSTextBox.Location = new System.Drawing.Point(212, 203);
            this.eMPLOYEE_ADDRESSTextBox.Name = "eMPLOYEE_ADDRESSTextBox";
            this.eMPLOYEE_ADDRESSTextBox.Size = new System.Drawing.Size(200, 26);
            this.eMPLOYEE_ADDRESSTextBox.TabIndex = 13;
            // 
            // eMPLOYEE_GENDERTextBox
            // 
            this.eMPLOYEE_GENDERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "EMPLOYEE_GENDER", true));
            this.eMPLOYEE_GENDERTextBox.Location = new System.Drawing.Point(212, 235);
            this.eMPLOYEE_GENDERTextBox.Name = "eMPLOYEE_GENDERTextBox";
            this.eMPLOYEE_GENDERTextBox.Size = new System.Drawing.Size(200, 26);
            this.eMPLOYEE_GENDERTextBox.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 53);
            this.button1.TabIndex = 16;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nURSEBindingSource
            // 
            this.nURSEBindingSource.DataMember = "NURSE";
            this.nURSEBindingSource.DataSource = this.hospitalBDDataSet2;
            // 
            // nURSETableAdapter
            // 
            this.nURSETableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 578);
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
            this.Controls.Add(this.eMPLOYEEDataGridView);
            this.Controls.Add(this.eMPLOYEEBindingNavigator);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingNavigator)).EndInit();
            this.eMPLOYEEBindingNavigator.ResumeLayout(false);
            this.eMPLOYEEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HospitalBDDataSet2 hospitalBDDataSet2;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private HospitalBDDataSet2TableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private HospitalBDDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eMPLOYEEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eMPLOYEEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView eMPLOYEEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox eMPLOYEE_IDTextBox;
        private System.Windows.Forms.TextBox dEP_CODETextBox;
        private System.Windows.Forms.TextBox pHONE_NO_TextBox;
        private System.Windows.Forms.TextBox eMPLOYEE_NAMETextBox;
        private System.Windows.Forms.DateTimePicker eMPLOYEE_DOBDateTimePicker;
        private System.Windows.Forms.TextBox eMPLOYEE_ADDRESSTextBox;
        private System.Windows.Forms.TextBox eMPLOYEE_GENDERTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource nURSEBindingSource;
        private HospitalBDDataSet2TableAdapters.NURSETableAdapter nURSETableAdapter;
    }
}