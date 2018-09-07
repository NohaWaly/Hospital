namespace Project
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.label1 = new System.Windows.Forms.Label();
            this.hospitalBDDataSet = new Project.HospitalBDDataSet();
            this.sURGERYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sURGERYTableAdapter = new Project.HospitalBDDataSetTableAdapters.SURGERYTableAdapter();
            this.tableAdapterManager = new Project.HospitalBDDataSetTableAdapters.TableAdapterManager();
            this.sURGERYBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sURGERYBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.bedTableAdapter1 = new Project.HospitalBDDataSet1TableAdapters.BEDTableAdapter();
            this.dataTable1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalBDDataSet2 = new Project.HospitalBDDataSet2();
            this.button2 = new System.Windows.Forms.Button();
            this.sURGERYBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sURGERYTableAdapter1 = new Project.HospitalBDDataSet2TableAdapters.SURGERYTableAdapter();
            this.tableAdapterManager1 = new Project.HospitalBDDataSet2TableAdapters.TableAdapterManager();
            this.nURSETableAdapter = new Project.HospitalBDDataSet2TableAdapters.NURSETableAdapter();
            this.nURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new Project.HospitalBDDataSet2TableAdapters.DataTable1TableAdapter();
            this.sURGERYNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sURGERYDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sURGERYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sURGERYBindingNavigator)).BeginInit();
            this.sURGERYBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sURGERYBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(332, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available surgeries";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // hospitalBDDataSet
            // 
            this.hospitalBDDataSet.DataSetName = "HospitalBDDataSet";
            this.hospitalBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.PATIENTTableAdapter = null;
            this.tableAdapterManager.SURGERYTableAdapter = this.sURGERYTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project.HospitalBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VISITORTableAdapter = null;
            // 
            // sURGERYBindingNavigator
            // 
            this.sURGERYBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sURGERYBindingNavigator.BindingSource = this.sURGERYBindingSource;
            this.sURGERYBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sURGERYBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sURGERYBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sURGERYBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sURGERYBindingNavigatorSaveItem});
            this.sURGERYBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sURGERYBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sURGERYBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sURGERYBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sURGERYBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sURGERYBindingNavigator.Name = "sURGERYBindingNavigator";
            this.sURGERYBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sURGERYBindingNavigator.Size = new System.Drawing.Size(894, 31);
            this.sURGERYBindingNavigator.TabIndex = 1;
            this.sURGERYBindingNavigator.Text = "bindingNavigator1";
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
            // sURGERYBindingNavigatorSaveItem
            // 
            this.sURGERYBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sURGERYBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sURGERYBindingNavigatorSaveItem.Image")));
            this.sURGERYBindingNavigatorSaveItem.Name = "sURGERYBindingNavigatorSaveItem";
            this.sURGERYBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.sURGERYBindingNavigatorSaveItem.Text = "Save Data";
            this.sURGERYBindingNavigatorSaveItem.Click += new System.EventHandler(this.sURGERYBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bedTableAdapter1
            // 
            this.bedTableAdapter1.ClearBeforeFill = true;
            // 
            // dataTable1DataGridView
            // 
            this.dataTable1DataGridView.AutoGenerateColumns = false;
            this.dataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sURGERYNODataGridViewTextBoxColumn,
            this.eMPLOYEENAMEDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.sURGERYDATEDataGridViewTextBoxColumn,
            this.pATIENTIDDataGridViewTextBoxColumn});
            this.dataTable1DataGridView.DataSource = this.dataTable1BindingSource;
            this.dataTable1DataGridView.Location = new System.Drawing.Point(12, 163);
            this.dataTable1DataGridView.Name = "dataTable1DataGridView";
            this.dataTable1DataGridView.RowTemplate.Height = 28;
            this.dataTable1DataGridView.Size = new System.Drawing.Size(859, 299);
            this.dataTable1DataGridView.TabIndex = 3;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.hospitalBDDataSet2;
            // 
            // hospitalBDDataSet2
            // 
            this.hospitalBDDataSet2.DataSetName = "HospitalBDDataSet2";
            this.hospitalBDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sURGERYBindingSource1
            // 
            this.sURGERYBindingSource1.DataMember = "SURGERY";
            this.sURGERYBindingSource1.DataSource = this.hospitalBDDataSet2;
            // 
            // sURGERYTableAdapter1
            // 
            this.sURGERYTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.APPOINTMENTTableAdapter = null;
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
            this.tableAdapterManager1.NURSETableAdapter = this.nURSETableAdapter;
            this.tableAdapterManager1.PATIENTTableAdapter = null;
            this.tableAdapterManager1.SURGERYTableAdapter = this.sURGERYTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Project.HospitalBDDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VISITORTableAdapter = null;
            // 
            // nURSETableAdapter
            // 
            this.nURSETableAdapter.ClearBeforeFill = true;
            // 
            // nURSEBindingSource
            // 
            this.nURSEBindingSource.DataMember = "NURSE";
            this.nURSEBindingSource.DataSource = this.hospitalBDDataSet2;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // sURGERYNODataGridViewTextBoxColumn
            // 
            this.sURGERYNODataGridViewTextBoxColumn.DataPropertyName = "SURGERY_NO_";
            this.sURGERYNODataGridViewTextBoxColumn.HeaderText = "SURGERY_NO_";
            this.sURGERYNODataGridViewTextBoxColumn.Name = "sURGERYNODataGridViewTextBoxColumn";
            // 
            // eMPLOYEENAMEDataGridViewTextBoxColumn
            // 
            this.eMPLOYEENAMEDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_NAME";
            this.eMPLOYEENAMEDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE_NAME";
            this.eMPLOYEENAMEDataGridViewTextBoxColumn.Name = "eMPLOYEENAMEDataGridViewTextBoxColumn";
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            // 
            // sURGERYDATEDataGridViewTextBoxColumn
            // 
            this.sURGERYDATEDataGridViewTextBoxColumn.DataPropertyName = "SURGERY_DATE";
            this.sURGERYDATEDataGridViewTextBoxColumn.HeaderText = "SURGERY_DATE";
            this.sURGERYDATEDataGridViewTextBoxColumn.Name = "sURGERYDATEDataGridViewTextBoxColumn";
            // 
            // pATIENTIDDataGridViewTextBoxColumn
            // 
            this.pATIENTIDDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_ID";
            this.pATIENTIDDataGridViewTextBoxColumn.HeaderText = "PATIENT_ID";
            this.pATIENTIDDataGridViewTextBoxColumn.Name = "pATIENTIDDataGridViewTextBoxColumn";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 605);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataTable1DataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sURGERYBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sURGERYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sURGERYBindingNavigator)).EndInit();
            this.sURGERYBindingNavigator.ResumeLayout(false);
            this.sURGERYBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBDDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sURGERYBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nURSEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private HospitalBDDataSet hospitalBDDataSet;
        private System.Windows.Forms.BindingSource sURGERYBindingSource;
        private HospitalBDDataSetTableAdapters.SURGERYTableAdapter sURGERYTableAdapter;
        private HospitalBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sURGERYBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sURGERYBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private HospitalBDDataSet2 hospitalBDDataSet2;
        private System.Windows.Forms.BindingSource sURGERYBindingSource1;
        private HospitalBDDataSet2TableAdapters.SURGERYTableAdapter sURGERYTableAdapter1;
        private HospitalBDDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private HospitalBDDataSet2TableAdapters.NURSETableAdapter nURSETableAdapter;
        private System.Windows.Forms.BindingSource nURSEBindingSource;
        private HospitalBDDataSet1TableAdapters.BEDTableAdapter bedTableAdapter1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.DataGridView dataTable1DataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTID1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sURGERYNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sURGERYDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTIDDataGridViewTextBoxColumn;
        private HospitalBDDataSet2TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    }
}