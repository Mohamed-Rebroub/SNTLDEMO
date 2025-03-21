using AssuranceSNTL.Models;
using System.ComponentModel.DataAnnotations;

namespace AssuranceSNTL.DTO.TypeAssurance
{
    public class TypeAssuranceReadDto
    {
      
        public int ID { get; set; }

       
        public string Nom { get; set; }

        public string Description { get; set; }

        public decimal Prix { get; set; }

    }
}
