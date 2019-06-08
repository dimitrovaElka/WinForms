namespace PharmacyApp
{
    partial class FormPharmacy
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyWinFormsDataSet = new PharmacyApp.PharmacyWinFormsDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pharmaciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmaciesTableAdapter = new PharmacyApp.PharmacyWinFormsDataSetTableAdapters.PharmaciesTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pharmacyLicenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugsLicenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyWinFormsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaciesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.pharmacyWinFormsDataSet;
            this.bindingSource1.Position = 0;
            // 
            // pharmacyWinFormsDataSet
            // 
            this.pharmacyWinFormsDataSet.DataSetName = "PharmacyWinFormsDataSet";
            this.pharmacyWinFormsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.pharmacyLicenseDataGridViewTextBoxColumn,
            this.drugsLicenseDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pharmaciesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(834, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // pharmaciesBindingSource
            // 
            this.pharmaciesBindingSource.DataMember = "Pharmacies";
            this.pharmaciesBindingSource.DataSource = this.bindingSource1;
            // 
            // pharmaciesTableAdapter
            // 
            this.pharmaciesTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // pharmacyLicenseDataGridViewTextBoxColumn
            // 
            this.pharmacyLicenseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pharmacyLicenseDataGridViewTextBoxColumn.DataPropertyName = "PharmacyLicense";
            this.pharmacyLicenseDataGridViewTextBoxColumn.HeaderText = "PharmacyLicense";
            this.pharmacyLicenseDataGridViewTextBoxColumn.Name = "pharmacyLicenseDataGridViewTextBoxColumn";
            this.pharmacyLicenseDataGridViewTextBoxColumn.Width = 159;
            // 
            // drugsLicenseDataGridViewTextBoxColumn
            // 
            this.drugsLicenseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.drugsLicenseDataGridViewTextBoxColumn.DataPropertyName = "DrugsLicense";
            this.drugsLicenseDataGridViewTextBoxColumn.HeaderText = "DrugsLicense";
            this.drugsLicenseDataGridViewTextBoxColumn.Name = "drugsLicenseDataGridViewTextBoxColumn";
            this.drugsLicenseDataGridViewTextBoxColumn.Width = 132;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 200;
            // 
            // FormPharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 488);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPharmacy";
            this.Text = "Аптеки";
            this.Load += new System.EventHandler(this.FormPharmacy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyWinFormsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaciesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private PharmacyWinFormsDataSet pharmacyWinFormsDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pharmaciesBindingSource;
        private PharmacyWinFormsDataSetTableAdapters.PharmaciesTableAdapter pharmaciesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pharmacyLicenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugsLicenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    }
}