using AssuranceSNTL.Models.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace AssuranceSNTL.Models
{
    public class PackAssurance : BaseEntity
    {

        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Nom { get; set; }

        [Required, MaxLength(500)]
        public string Description { get; set; }
        public ICollection<Contrat> Contrats { get; set; } = new List<Contrat>();

        public ICollection<PackTypeAssurance> PackTypeAssurances { get; set; } = new List<PackTypeAssurance>();
    }
}
