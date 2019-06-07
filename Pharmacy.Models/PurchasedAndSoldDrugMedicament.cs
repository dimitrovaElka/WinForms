using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy.Models
{
    public class PurchasedAndSoldDrugMedicament
    {
        public int Id { get; set; }

        public Drugstore Pharmacy { get; set; }

        public int PharmacyId { get; set; }

        public DrugMedicament Drug { get; set; }

        public int DrugMendicamentId { get; set; }

        public int ReportingPeriod { get; set; }

        public int AvailabilityAtTheBeginning { get; set; }

        public int PurchasedQuantity { get; set; }

        public int SoldQuantity { get; set; }

        public int AvailabilityAtTheEnd { get; set; }
    }
}
