using System.Collections.Generic;
using AssuranceSNTL.Models;
using System.ComponentModel.DataAnnotations;

namespace AssuranceSNTL.DTO.PackAssurance
{
    public class PackAssuranceCreateDto
    {


        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Nom { get; set; }

        [Required, MaxLength(500)]
        public string Description { get; set; }

        public List<int> PackTypeAssurancesID { get; set; }
    }
}
