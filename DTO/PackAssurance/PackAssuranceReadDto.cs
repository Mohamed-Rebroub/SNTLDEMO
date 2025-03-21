using System.Collections.Generic;
using AssuranceSNTL.Models;
using System.ComponentModel.DataAnnotations;
using AssuranceSNTL.DTO.TypeAssurance;

namespace AssuranceSNTL.DTO.PackAssurance
{
    public class PackAssuranceReadDto
    {
        public int ID { get; set; }

        public string Nom { get; set; }

        public string Description { get; set; }
        public List<TypeAssuranceReadDto> TypeAssurances { get; set; } = new List<TypeAssuranceReadDto>();
    }
}
