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
    public partial class FormPharmacy : Form
    {
        public FormPharmacy()
        {
            InitializeComponent();
        }

        private void FormPharmacy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyWinFormsDataSet.Pharmacies' table. You can move, or remove it, as needed.
            this.pharmaciesTableAdapter.Fill(this.pharmacyWinFormsDataSet.Pharmacies);

        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pharmaciesBindingSource.EndEdit();
                this.pharmaciesTableAdapter.Update(this.pharmacyWinFormsDataSet.Pharmacies);
                MessageBox.Show("Pharmacy updated...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
