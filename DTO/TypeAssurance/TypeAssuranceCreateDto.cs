using System.Collections.Generic;
using AssuranceSNTL.Models;
using System.ComponentModel.DataAnnotations;

namespace AssuranceSNTL.DTO.TypeAssurance
{
    public class TypeAssuranceCreateDto
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Nom { get; set; }

        [Required, MaxLength(500)]
        public string Description { get; set; }

        [Required, MaxLength(500)]
        public decimal Prix { get; set; }

        public List<int> PackTypeAssurancesId { get; set; }
    }
}
