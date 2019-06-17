namespace PharmacyApp.Forms
{
    partial class FormDrugsReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDownAvailableAtEnd = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMinus = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownPlus = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownAvailableAtBegin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDrugs = new System.Windows.Forms.ComboBox();
            this.purchasedAndSoldDrugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugsReportDataSet = new PharmacyApp.DrugsReportDataSet();
            this.purchasedAndSoldDrugsTableAdapter = new PharmacyApp.DrugsReportDataSetTableAdapters.PurchasedAndSoldDrugsTableAdapter();
            this.labelPharmacyName = new System.Windows.Forms.Label();
            this.drugsReportDataSet1 = new PharmacyApp.DrugsReportDataSet();
            this.drugMedicamentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugMedicamentsTableAdapter = new PharmacyApp.DrugsReportDataSetTableAdapters.DrugMedicamentsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvailableAtEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvailableAtBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedAndSoldDrugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsReportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugMedicamentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.numericUpDownAvailableAtEnd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericUpDownMinus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numericUpDownPlus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDownAvailableAtBegin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxDrugs);
            this.panel1.Location = new System.Drawing.Point(-3, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 433);
            this.panel1.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(351, 350);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(119, 39);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "добави";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // numericUpDownAvailableAtEnd
            // 
            this.numericUpDownAvailableAtEnd.Location = new System.Drawing.Point(352, 269);
            this.numericUpDownAvailableAtEnd.Name = "numericUpDownAvailableAtEnd";
            this.numericUpDownAvailableAtEnd.Size = new System.Drawing.Size(119, 26);
            this.numericUpDownAvailableAtEnd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Наличност в края на периода:";
            // 
            // numericUpDownMinus
            // 
            this.numericUpDownMinus.Location = new System.Drawing.Point(352, 225);
            this.numericUpDownMinus.Name = "numericUpDownMinus";
            this.numericUpDownMinus.Size = new System.Drawing.Size(119, 26);
            this.numericUpDownMinus.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Продадени количества за периода:";
            // 
            // numericUpDownPlus
            // 
            this.numericUpDownPlus.Location = new System.Drawing.Point(352, 178);
            this.numericUpDownPlus.Name = "numericUpDownPlus";
            this.numericUpDownPlus.Size = new System.Drawing.Size(119, 26);
            this.numericUpDownPlus.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Получени количества за периода:";
            // 
            // numericUpDownAvailableAtBegin
            // 
            this.numericUpDownAvailableAtBegin.Location = new System.Drawing.Point(352, 132);
            this.numericUpDownAvailableAtBegin.Name = "numericUpDownAvailableAtBegin";
            this.numericUpDownAvailableAtBegin.Size = new System.Drawing.Size(119, 26);
            this.numericUpDownAvailableAtBegin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наличност в началото на периода:";
            // 
            // comboBoxDrugs
            // 
            this.comboBoxDrugs.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.drugMedicamentsBindingSource, "TradeName", true));
            this.comboBoxDrugs.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.drugMedicamentsBindingSource, "Id", true));
            this.comboBoxDrugs.FormattingEnabled = true;
            this.comboBoxDrugs.Location = new System.Drawing.Point(18, 51);
            this.comboBoxDrugs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDrugs.Name = "comboBoxDrugs";
            this.comboBoxDrugs.Size = new System.Drawing.Size(453, 28);
            this.comboBoxDrugs.TabIndex = 0;
            // 
            // purchasedAndSoldDrugsBindingSource
            // 
            this.purchasedAndSoldDrugsBindingSource.DataMember = "PurchasedAndSoldDrugs";
            this.purchasedAndSoldDrugsBindingSource.DataSource = this.drugsReportDataSet;
            // 
            // drugsReportDataSet
            // 
            this.drugsReportDataSet.DataSetName = "DrugsReportDataSet";
            this.drugsReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchasedAndSoldDrugsTableAdapter
            // 
            this.purchasedAndSoldDrugsTableAdapter.ClearBeforeFill = true;
            // 
            // labelPharmacyName
            // 
            this.labelPharmacyName.AutoSize = true;
            this.labelPharmacyName.Location = new System.Drawing.Point(42, 22);
            this.labelPharmacyName.Name = "labelPharmacyName";
            this.labelPharmacyName.Size = new System.Drawing.Size(62, 20);
            this.labelPharmacyName.TabIndex = 2;
            this.labelPharmacyName.Text = "аптека";
            // 
            // drugsReportDataSet1
            // 
            this.drugsReportDataSet1.DataSetName = "DrugsReportDataSet";
            this.drugsReportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drugMedicamentsBindingSource
            // 
            this.drugMedicamentsBindingSource.DataMember = "DrugMedicaments";
            this.drugMedicamentsBindingSource.DataSource = this.drugsReportDataSet1;
            // 
            // drugMedicamentsTableAdapter
            // 
            this.drugMedicamentsTableAdapter.ClearBeforeFill = true;
            // 
            // FormDrugsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 505);
            this.Controls.Add(this.labelPharmacyName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDrugsReport";
            this.Text = "FormDrugsReport";
            this.Load += new System.EventHandler(this.FormDrugsReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvailableAtEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvailableAtBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedAndSoldDrugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsReportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugMedicamentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DrugsReportDataSet drugsReportDataSet;
        private System.Windows.Forms.BindingSource purchasedAndSoldDrugsBindingSource;
        private DrugsReportDataSetTableAdapters.PurchasedAndSoldDrugsTableAdapter purchasedAndSoldDrugsTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxDrugs;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownAvailableAtEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownMinus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownPlus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownAvailableAtBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPharmacyName;
        private DrugsReportDataSet drugsReportDataSet1;
        private System.Windows.Forms.BindingSource drugMedicamentsBindingSource;
        private DrugsReportDataSetTableAdapters.DrugMedicamentsTableAdapter drugMedicamentsTableAdapter;
    }
}