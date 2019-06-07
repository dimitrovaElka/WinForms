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
    public partial class FormApplication2 : Form
    {
        public FormApplication2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nark2016DataSet.listPharmacy' table. You can move, or remove it, as needed.
            this.listPharmacyTableAdapter.Fill(this.nark2016DataSet.listPharmacy);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
