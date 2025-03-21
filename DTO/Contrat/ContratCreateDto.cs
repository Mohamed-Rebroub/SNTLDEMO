using AssuranceSNTL.Models;

namespace AssuranceSNTL.DTO.Contrat
{
    public class ContratCreateDto
    {
        public int ContratId { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public decimal Montant { get; set; }

        public int PackAssuranceId { get; set; }

        public int VoitureId { get; set; }

        public int ClientId { get; set; }

        public List<int> TypeAssuranceIds { get; set; }
    }
}
