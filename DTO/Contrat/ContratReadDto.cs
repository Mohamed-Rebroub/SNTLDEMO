using AssuranceSNTL.DTO.TypeAssurance;
using AssuranceSNTL.Models;

namespace AssuranceSNTL.DTO.Contrat
{
    public class ContratReadDto
    {
       
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public decimal Montant { get; set; }

        public int PackAssuranceId { get; set; }

        public int VoitureId { get; set; }

        public int ClientId { get; set; }

        public List<TypeAssuranceReadDto> TypeAssurances { get; set; } = new List<TypeAssuranceReadDto>();
    }
}
