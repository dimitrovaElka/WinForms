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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPharmacy = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(16, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 185);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            this.comboBoxPharmacy.DataSource = this.nark2016DataSet;
            this.comboBoxPharmacy.FormattingEnabled = true;
            this.comboBoxPharmacy.Location = new System.Drawing.Point(449, 60);
            this.comboBoxPharmacy.Name = "comboBoxPharmacy";
            this.comboBoxPharmacy.Size = new System.Drawing.Size(347, 28);
            this.comboBoxPharmacy.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.Location = new System.Drawing.Point(30, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Прехвърляне на наличности";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(321, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отчети на аптеки";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(262, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Обобщен отчет";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(669, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "Изход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormApplication2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(902, 716);
            this.Controls.Add(this.button4);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}

