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
    public partial class FormDrugs : Form
    {
        public FormDrugs()
        {
            InitializeComponent();
        }

        private void FormDrugs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'genericDataSet.GenericMedicaments' table. You can move, or remove it, as needed.
            this.genericMedicamentsTableAdapter.Fill(this.genericDataSet.GenericMedicaments);
   
            // TODO: This line of code loads data into the 'drugsDataSet.DrugMedicaments' table. You can move, or remove it, as needed.
            this.drugMedicamentsTableAdapter.Fill(this.drugsDataSet.DrugMedicaments);

        }

        private void toolStripButtonUpdDrugs_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.drugMedicamentsBindingSource.EndEdit();
                this.drugMedicamentsTableAdapter.Update(this.drugsDataSet.DrugMedicaments);
                MessageBox.Show("Medicaments updated...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonExitDrugs_Click(object sender, EventArgs e)
        {
            // Application.Exit();
      
            this.Close();
        }
    }
}
