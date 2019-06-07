using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy.Models
{
    public class Drugstore
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PharmacyLicense { get; set; }

        public string DrugsLicense { get; set; }

        public string City { get; set; }

        public ICollection<PurchasedAndSoldDrugMedicament> Reports { get; set; }
    }
}
