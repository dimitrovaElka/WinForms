using PharmacyApp.DataSets;

namespace PharmacyApp
{
    partial class FormDrugs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDrugs));
            this.bindingNavigatorDrugs = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.drugMedicamentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugsDataSet = new PharmacyApp.DataSets.DrugsDataSet();
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
            this.toolStripButtonUpdDrugs = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewDrugs = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genericIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.genericMedicamentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genericDataSet = new PharmacyApp.DataSets.GenericDataSet();
            this.measureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packingContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugMedicamentsTableAdapter = new PharmacyApp.DataSets.DrugsDataSetTableAdapters.DrugMedicamentsTableAdapter();
            this.genericMedicamentsTableAdapter = new PharmacyApp.DataSets.GenericDataSetTableAdapters.GenericMedicamentsTableAdapter();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDrugs)).BeginInit();
            this.bindingNavigatorDrugs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugMedicamentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genericMedicamentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genericDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigatorDrugs
            // 
            this.bindingNavigatorDrugs.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorDrugs.BindingSource = this.drugMedicamentsBindingSource;
            this.bindingNavigatorDrugs.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorDrugs.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorDrugs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButtonUpdDrugs,
            this.toolStripButtonExit});
            this.bindingNavigatorDrugs.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorDrugs.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorDrugs.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorDrugs.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorDrugs.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorDrugs.Name = "bindingNavigatorDrugs";
            this.bindingNavigatorDrugs.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorDrugs.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigatorDrugs.TabIndex = 0;
            this.bindingNavigatorDrugs.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // drugMedicamentsBindingSource
            // 
            this.drugMedicamentsBindingSource.DataMember = "DrugMedicaments";
            this.drugMedicamentsBindingSource.DataSource = this.drugsDataSet;
            // 
            // drugsDataSet
            // 
            this.drugsDataSet.DataSetName = "DrugsDataSet";
            this.drugsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonUpdDrugs
            // 
            this.toolStripButtonUpdDrugs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdDrugs.Image = global::PharmacyApp.Properties.Resources.update;
            this.toolStripButtonUpdDrugs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdDrugs.Name = "toolStripButtonUpdDrugs";
            this.toolStripButtonUpdDrugs.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUpdDrugs.Text = "Update";
            this.toolStripButtonUpdDrugs.Click += new System.EventHandler(this.toolStripButtonUpdDrugs_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewDrugs);
            this.panel1.Location = new System.Drawing.Point(1, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 410);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewDrugs
            // 
            this.dataGridViewDrugs.AutoGenerateColumns = false;
            this.dataGridViewDrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tradeNameDataGridViewTextBoxColumn,
            this.genericIdDataGridViewTextBoxColumn,
            this.measureDataGridViewTextBoxColumn,
            this.packingContentDataGridViewTextBoxColumn});
            this.dataGridViewDrugs.DataSource = this.drugMedicamentsBindingSource;
            this.dataGridViewDrugs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDrugs.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDrugs.Name = "dataGridViewDrugs";
            this.dataGridViewDrugs.Size = new System.Drawing.Size(798, 410);
            this.dataGridViewDrugs.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tradeNameDataGridViewTextBoxColumn
            // 
            this.tradeNameDataGridViewTextBoxColumn.DataPropertyName = "TradeName";
            this.tradeNameDataGridViewTextBoxColumn.HeaderText = "TradeName";
            this.tradeNameDataGridViewTextBoxColumn.Name = "tradeNameDataGridViewTextBoxColumn";
            // 
            // genericIdDataGridViewTextBoxColumn
            // 
            this.genericIdDataGridViewTextBoxColumn.DataPropertyName = "GenericId";
            this.genericIdDataGridViewTextBoxColumn.DataSource = this.genericMedicamentsBindingSource;
            this.genericIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.genericIdDataGridViewTextBoxColumn.HeaderText = "GenericId";
            this.genericIdDataGridViewTextBoxColumn.Name = "genericIdDataGridViewTextBoxColumn";
            this.genericIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.genericIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.genericIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // genericMedicamentsBindingSource
            // 
            this.genericMedicamentsBindingSource.DataMember = "GenericMedicaments";
            this.genericMedicamentsBindingSource.DataSource = this.genericDataSet;
            // 
            // genericDataSet
            // 
            this.genericDataSet.DataSetName = "GenericDataSet";
            this.genericDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // measureDataGridViewTextBoxColumn
            // 
            this.measureDataGridViewTextBoxColumn.DataPropertyName = "Measure";
            this.measureDataGridViewTextBoxColumn.HeaderText = "Measure";
            this.measureDataGridViewTextBoxColumn.Name = "measureDataGridViewTextBoxColumn";
            // 
            // packingContentDataGridViewTextBoxColumn
            // 
            this.packingContentDataGridViewTextBoxColumn.DataPropertyName = "PackingContent";
            this.packingContentDataGridViewTextBoxColumn.HeaderText = "PackingContent";
            this.packingContentDataGridViewTextBoxColumn.Name = "packingContentDataGridViewTextBoxColumn";
            // 
            // drugMedicamentsTableAdapter
            // 
            this.drugMedicamentsTableAdapter.ClearBeforeFill = true;
            // 
            // genericMedicamentsTableAdapter
            // 
            this.genericMedicamentsTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExit.Text = "Exit";
            this.toolStripButtonExit.Click += new System.EventHandler(this.buttonExitDrugs_Click);
            // 
            // FormDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bindingNavigatorDrugs);
            this.Name = "FormDrugs";
            this.Text = "FormDrugs";
            this.Load += new System.EventHandler(this.FormDrugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDrugs)).EndInit();
            this.bindingNavigatorDrugs.ResumeLayout(false);
            this.bindingNavigatorDrugs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugMedicamentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genericMedicamentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genericDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigatorDrugs;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDrugs;
        private DrugsDataSet drugsDataSet;
        private System.Windows.Forms.BindingSource drugMedicamentsBindingSource;
        private DataSets.DrugsDataSetTableAdapters.DrugMedicamentsTableAdapter drugMedicamentsTableAdapter;
        private GenericDataSet genericDataSet;
        private System.Windows.Forms.BindingSource genericMedicamentsBindingSource;
        private DataSets.GenericDataSetTableAdapters.GenericMedicamentsTableAdapter genericMedicamentsTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdDrugs;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn genericIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packingContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
    }
}