using AssuranceSNTL.Models.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace AssuranceSNTL.Models
{
    public class TypeAssurance : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Nom { get; set; }

        [Required, MaxLength(500)]
        public string Description { get; set; }

        [Required, MaxLength(500)]
        public decimal Prix { get; set; }
        public ICollection<ContratTypeAssurance> ContratTypeAssurances { get; set; } = new List<ContratTypeAssurance>();
    }
}
