﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp.Forms
{
    public partial class FormDrugsReport : Form
    {
        public FormDrugsReport()
        {
            InitializeComponent();
        }

        private void FormDrugsReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drugsReportDataSet1.DrugMedicaments' table. You can move, or remove it, as needed.
            this.drugMedicamentsTableAdapter.Fill(this.drugsReportDataSet1.DrugMedicaments);
            // TODO: This line of code loads data into the 'drugsReportDataSet.PurchasedAndSoldDrugs' table. You can move, or remove it, as needed.
            this.purchasedAndSoldDrugsTableAdapter.Fill(this.drugsReportDataSet.PurchasedAndSoldDrugs);
            
        }
    }
}
