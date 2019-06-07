namespace PharmacyApp
{
    partial class FormApplication2
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
            this.listPharmacyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nark2016DataSet = new PharmacyApp.nark2016DataSet();
            this.listPharmacyTableAdapter = new PharmacyApp.nark2016DataSetTableAdapters.listPharmacyTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownQuarter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSummarizedlReport = new System.Windows.Forms.Button();
            this.buttonPharmacyReport = new System.Windows.Forms.Button();
            this.buttonTransferOfStocks = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPharmacy = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listPharmacyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nark2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuarter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPharmacyBindingSource
            // 
            this.listPharmacyBindingSource.DataMember = "listPharmacy";
            this.listPharmacyBindingSource.DataSource = this.nark2016DataSet;
            // 
            // nark2016DataSet
            // 
            this.nark2016DataSet.DataSetName = "nark2016DataSet";
            this.nark2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listPharmacyTableAdapter
            // 
            this.listPharmacyTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тримесечен отчет по ЗКНВП ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownQuarter
            // 
            this.numericUpDownQuarter.Location = new System.Drawing.Point(170, 62);
            this.numericUpDownQuarter.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownQuarter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuarter.Name = "numericUpDownQuarter";
            this.numericUpDownQuarter.Size = new System.Drawing.Size(41, 26);
            this.numericUpDownQuarter.TabIndex = 1;
            this.numericUpDownQuarter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Избор на период";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSummarizedlReport);
            this.groupBox1.Controls.Add(this.buttonPharmacyReport);
            this.groupBox1.Controls.Add(this.buttonTransferOfStocks);
            this.groupBox1.Location = new System.Drawing.Point(16, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 185);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonSummarizedlReport
            // 
            this.buttonSummarizedlReport.Location = new System.Drawing.Point(252, 115);
            this.buttonSummarizedlReport.Name = "buttonSummarizedlReport";
            this.buttonSummarizedlReport.Size = new System.Drawing.Size(262, 39);
            this.buttonSummarizedlReport.TabIndex = 2;
            this.buttonSummarizedlReport.Text = "Обобщен отчет";
            this.buttonSummarizedlReport.UseVisualStyleBackColor = true;
            this.buttonSummarizedlReport.Click += new System.EventHandler(this.buttonSummarizedReport_Click);
            // 
            // buttonPharmacyReport
            // 
            this.buttonPharmacyReport.Location = new System.Drawing.Point(433, 43);
            this.buttonPharmacyReport.Name = "buttonPharmacyReport";
            this.buttonPharmacyReport.Size = new System.Drawing.Size(321, 39);
            this.buttonPharmacyReport.TabIndex = 1;
            this.buttonPharmacyReport.Text = "Отчети на аптеки";
            this.buttonPharmacyReport.UseVisualStyleBackColor = true;
            this.buttonPharmacyReport.Click += new System.EventHandler(this.buttonPharmacyReport_Click);
            // 
            // buttonTransferOfStocks
            // 
            this.buttonTransferOfStocks.AutoEllipsis = true;
            this.buttonTransferOfStocks.Location = new System.Drawing.Point(30, 43);
            this.buttonTransferOfStocks.Name = "buttonTransferOfStocks";
            this.buttonTransferOfStocks.Size = new System.Drawing.Size(321, 39);
            this.buttonTransferOfStocks.TabIndex = 0;
            this.buttonTransferOfStocks.Text = "Прехвърляне на наличности";
            this.buttonTransferOfStocks.UseVisualStyleBackColor = true;
            this.buttonTransferOfStocks.Click += new System.EventHandler(this.buttonTransferOfStocks_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Избор на аптека: ";
            // 
            // comboBoxPharmacy
            // 
            this.comboBoxPharmacy.FormattingEnabled = true;
            this.comboBoxPharmacy.Items.AddRange(new object[] {
            "Аптека 1",
            "Аптека 2",
            "Аптека 3",
            "Аптека 4"});
            this.comboBoxPharmacy.Location = new System.Drawing.Point(449, 60);
            this.comboBoxPharmacy.Name = "comboBoxPharmacy";
            this.comboBoxPharmacy.Size = new System.Drawing.Size(347, 28);
            this.comboBoxPharmacy.TabIndex = 5;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(669, 321);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(127, 34);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Изход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormApplication2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(825, 385);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.comboBoxPharmacy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownQuarter);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormApplication2";
            this.Text = "Приложение 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listPharmacyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nark2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuarter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private nark2016DataSet nark2016DataSet;
        private System.Windows.Forms.BindingSource listPharmacyBindingSource;
        private nark2016DataSetTableAdapters.listPharmacyTableAdapter listPharmacyTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownQuarter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPharmacy;
        private System.Windows.Forms.Button buttonSummarizedlReport;
        private System.Windows.Forms.Button buttonPharmacyReport;
        private System.Windows.Forms.Button buttonTransferOfStocks;
        private System.Windows.Forms.Button buttonExit;
    }
}

