using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class FormApplication2 : System.Windows.Forms.Form
    {
        public FormApplication2()
        {
            InitializeComponent();
        }

        private void buttonAddPharm_Click(Object sender, EventArgs e)
        {
            var myForm = new FormPharmacy();
            myForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyWinFormsDataSet1.Pharmacies' table. You can move, or remove it, as needed.
            this.pharmaciesTableAdapter.Fill(this.pharmacyWinFormsDataSet.Pharmacies);
            // TODO: This line of code loads data into the 'nark2016DataSet.listPharmacy' table. You can move, or remove it, as needed.
            // this.listPharmacyTableAdapter.Fill(this.nark2016DataSet.listPharmacy);

        }

        private void buttonTransferOfStocks_Click(object sender, EventArgs e)
        {

        }

        private void buttonPharmacyReport_Click(object sender, EventArgs e)
        {

        }

        private void buttonSummarizedReport_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
