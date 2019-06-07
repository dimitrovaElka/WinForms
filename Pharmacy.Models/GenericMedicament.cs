using System;
using System.Collections.Generic;

namespace Pharmacy.Models
{
    public class GenericMedicament
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<DrugMedicament> Drugs { get; set; }
    }
}
