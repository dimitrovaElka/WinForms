namespace PharmacyApp.Forms
{
    partial class FormFarmacyReportDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFarmacyReportDetails));
            System.Windows.Forms.Label drugMendicamentIdLabel;
            System.Windows.Forms.Label availabilityAtTheBeginningLabel;
            System.Windows.Forms.Label purchasedQuantityLabel;
            System.Windows.Forms.Label soldQuantityLabel;
            System.Windows.Forms.Label availabilityAtTheEndLabel;
            this.drugsReportDataSet = new PharmacyApp.DrugsReportDataSet();
            this.purchasedAndSoldDrugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasedAndSoldDrugsTableAdapter = new PharmacyApp.DrugsReportDataSetTableAdapters.PurchasedAndSoldDrugsTableAdapter();
            this.tableAdapterManager = new PharmacyApp.DrugsReportDataSetTableAdapters.TableAdapterManager();
            this.purchasedAndSoldDrugsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.purchasedAndSoldDrugsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.drugMendicamentIdTextBox = new System.Windows.Forms.TextBox();
            this.availabilityAtTheBeginningTextBox = new System.Windows.Forms.TextBox();
            this.purchasedQuantityTextBox = new System.Windows.Forms.TextBox();
            this.soldQuantityTextBox = new System.Windows.Forms.TextBox();
            this.availabilityAtTheEndTextBox = new System.Windows.Forms.TextBox();
            this.pharmacyWinFormsDataSet1 = new PharmacyApp.DataSets.PharmacyWinFormsDataSet();
            drugMendicamentIdLabel = new System.Windows.Forms.Label();
            availabilityAtTheBeginningLabel = new System.Windows.Forms.Label();
            purchasedQuantityLabel = new System.Windows.Forms.Label();
            soldQuantityLabel = new System.Windows.Forms.Label();
            availabilityAtTheEndLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drugsReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedAndSoldDrugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedAndSoldDrugsBindingNavigator)).BeginInit();
            this.purchasedAndSoldDrugsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyWinFormsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // drugsReportDataSet
            // 
            this.drugsReportDataSet.DataSetName = "DrugsReportDataSet";
            this.drugsReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchasedAndSoldDrugsBindingSource
            // 
            this.purchasedAndSoldDrugsBindingSource.DataMember = "PurchasedAndSoldDrugs";
            this.purchasedAndSoldDrugsBindingSource.DataSource = this.drugsReportDataSet;
            // 
            // purchasedAndSoldDrugsTableAdapter
            // 
            this.purchasedAndSoldDrugsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PurchasedAndSoldDrugsTableAdapter = this.purchasedAndSoldDrugsTableAdapter;
            this.tableAdapterManager.UpdateOrder = PharmacyApp.DrugsReportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // purchasedAndSoldDrugsBindingNavigator
            // 
            this.purchasedAndSoldDrugsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.purchasedAndSoldDrugsBindingNavigator.BindingSource = this.purchasedAndSoldDrugsBindingSource;
            this.purchasedAndSoldDrugsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purchasedAndSoldDrugsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.purchasedAndSoldDrugsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.purchasedAndSoldDrugsBindingNavigatorSaveItem});
            this.purchasedAndSoldDrugsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.purchasedAndSoldDrugsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purchasedAndSoldDrugsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purchasedAndSoldDrugsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purchasedAndSoldDrugsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purchasedAndSoldDrugsBindingNavigator.Name = "purchasedAndSoldDrugsBindingNavigator";
            this.purchasedAndSoldDrugsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purchasedAndSoldDrugsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.purchasedAndSoldDrugsBindingNavigator.TabIndex = 0;
            this.purchasedAndSoldDrugsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // purchasedAndSoldDrugsBindingNavigatorSaveItem
            // 
            this.purchasedAndSoldDrugsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.purchasedAndSoldDrugsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purchasedAndSoldDrugsBindingNavigatorSaveItem.Image")));
            this.purchasedAndSoldDrugsBindingNavigatorSaveItem.Name = "purchasedAndSoldDrugsBindingNavigatorSaveItem";
            this.purchasedAndSoldDrugsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.purchasedAndSoldDrugsBindingNavigatorSaveItem.Text = "Save Data";
            this.purchasedAndSoldDrugsBindingNavigatorSaveItem.Click += new System.EventHandler(this.purchasedAndSoldDrugsBindingNavigatorSaveItem_Click);
            // 
            // drugMendicamentIdLabel
            // 
            drugMendicamentIdLabel.AutoSize = true;
            drugMendicamentIdLabel.Location = new System.Drawing.Point(46, 62);
            drugMendicamentIdLabel.Name = "drugMendicamentIdLabel";
            drugMendicamentIdLabel.Size = new System.Drawing.Size(112, 13);
            drugMendicamentIdLabel.TabIndex = 1;
            drugMendicamentIdLabel.Text = "Drug Mendicament Id:";
            // 
            // drugMendicamentIdTextBox
            // 
            this.drugMendicamentIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchasedAndSoldDrugsBindingSource, "DrugMendicamentId", true));
            this.drugMendicamentIdTextBox.Location = new System.Drawing.Point(164, 59);
            this.drugMendicamentIdTextBox.Name = "drugMendicamentIdTextBox";
            this.drugMendicamentIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.drugMendicamentIdTextBox.TabIndex = 2;
            // 
            // availabilityAtTheBeginningLabel
            // 
            availabilityAtTheBeginningLabel.AutoSize = true;
            availabilityAtTheBeginningLabel.Location = new System.Drawing.Point(14, 116);
            availabilityAtTheBeginningLabel.Name = "availabilityAtTheBeginningLabel";
            availabilityAtTheBeginningLabel.Size = new System.Drawing.Size(144, 13);
            availabilityAtTheBeginningLabel.TabIndex = 3;
            availabilityAtTheBeginningLabel.Text = "Availability At The Beginning:";
            // 
            // availabilityAtTheBeginningTextBox
            // 
            this.availabilityAtTheBeginningTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchasedAndSoldDrugsBindingSource, "AvailabilityAtTheBeginning", true));
            this.availabilityAtTheBeginningTextBox.Location = new System.Drawing.Point(164, 113);
            this.availabilityAtTheBeginningTextBox.Name = "availabilityAtTheBeginningTextBox";
            this.availabilityAtTheBeginningTextBox.Size = new System.Drawing.Size(100, 20);
            this.availabilityAtTheBeginningTextBox.TabIndex = 4;
            // 
            // purchasedQuantityLabel
            // 
            purchasedQuantityLabel.AutoSize = true;
            purchasedQuantityLabel.Location = new System.Drawing.Point(55, 167);
            purchasedQuantityLabel.Name = "purchasedQuantityLabel";
            purchasedQuantityLabel.Size = new System.Drawing.Size(103, 13);
            purchasedQuantityLabel.TabIndex = 5;
            purchasedQuantityLabel.Text = "Purchased Quantity:";
            // 
            // purchasedQuantityTextBox
            // 
            this.purchasedQuantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchasedAndSoldDrugsBindingSource, "PurchasedQuantity", true));
            this.purchasedQuantityTextBox.Location = new System.Drawing.Point(164, 164);
            this.purchasedQuantityTextBox.Name = "purchasedQuantityTextBox";
            this.purchasedQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.purchasedQuantityTextBox.TabIndex = 6;
            // 
            // soldQuantityLabel
            // 
            soldQuantityLabel.AutoSize = true;
            soldQuantityLabel.Location = new System.Drawing.Point(85, 229);
            soldQuantityLabel.Name = "soldQuantityLabel";
            soldQuantityLabel.Size = new System.Drawing.Size(73, 13);
            soldQuantityLabel.TabIndex = 7;
            soldQuantityLabel.Text = "Sold Quantity:";
            // 
            // soldQuantityTextBox
            // 
            this.soldQuantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchasedAndSoldDrugsBindingSource, "SoldQuantity", true));
            this.soldQuantityTextBox.Location = new System.Drawing.Point(164, 226);
            this.soldQuantityTextBox.Name = "soldQuantityTextBox";
            this.soldQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.soldQuantityTextBox.TabIndex = 8;
            // 
            // availabilityAtTheEndLabel
            // 
            availabilityAtTheEndLabel.AutoSize = true;
            availabilityAtTheEndLabel.Location = new System.Drawing.Point(42, 281);
            availabilityAtTheEndLabel.Name = "availabilityAtTheEndLabel";
            availabilityAtTheEndLabel.Size = new System.Drawing.Size(116, 13);
            availabilityAtTheEndLabel.TabIndex = 9;
            availabilityAtTheEndLabel.Text = "Availability At The End:";
            // 
            // availabilityAtTheEndTextBox
            // 
            this.availabilityAtTheEndTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchasedAndSoldDrugsBindingSource, "AvailabilityAtTheEnd", true));
            this.availabilityAtTheEndTextBox.Location = new System.Drawing.Point(164, 278);
            this.availabilityAtTheEndTextBox.Name = "availabilityAtTheEndTextBox";
            this.availabilityAtTheEndTextBox.Size = new System.Drawing.Size(100, 20);
            this.availabilityAtTheEndTextBox.TabIndex = 10;
            // 
            // pharmacyWinFormsDataSet1
            // 
            this.pharmacyWinFormsDataSet1.DataSetName = "PharmacyWinFormsDataSet";
            this.pharmacyWinFormsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormFarmacyReportDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(availabilityAtTheEndLabel);
            this.Controls.Add(this.availabilityAtTheEndTextBox);
            this.Controls.Add(soldQuantityLabel);
            this.Controls.Add(this.soldQuantityTextBox);
            this.Controls.Add(purchasedQuantityLabel);
            this.Controls.Add(this.purchasedQuantityTextBox);
            this.Controls.Add(availabilityAtTheBeginningLabel);
            this.Controls.Add(this.availabilityAtTheBeginningTextBox);
            this.Controls.Add(drugMendicamentIdLabel);
            this.Controls.Add(this.drugMendicamentIdTextBox);
            this.Controls.Add(this.purchasedAndSoldDrugsBindingNavigator);
            this.Name = "FormFarmacyReportDetails";
            this.Text = "FormFarmacyReportDetails";
            this.Load += new System.EventHandler(this.FormFarmacyReportDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drugsReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedAndSoldDrugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedAndSoldDrugsBindingNavigator)).EndInit();
            this.purchasedAndSoldDrugsBindingNavigator.ResumeLayout(false);
            this.purchasedAndSoldDrugsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyWinFormsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DrugsReportDataSet drugsReportDataSet;
        private System.Windows.Forms.BindingSource purchasedAndSoldDrugsBindingSource;
        private DrugsReportDataSetTableAdapters.PurchasedAndSoldDrugsTableAdapter purchasedAndSoldDrugsTableAdapter;
        private DrugsReportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator purchasedAndSoldDrugsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton purchasedAndSoldDrugsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox drugMendicamentIdTextBox;
        private System.Windows.Forms.TextBox availabilityAtTheBeginningTextBox;
        private System.Windows.Forms.TextBox purchasedQuantityTextBox;
        private System.Windows.Forms.TextBox soldQuantityTextBox;
        private System.Windows.Forms.TextBox availabilityAtTheEndTextBox;
        private DataSets.PharmacyWinFormsDataSet pharmacyWinFormsDataSet1;
    }
}