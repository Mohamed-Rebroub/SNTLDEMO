using AssuranceSNTL.Models.Common;

namespace AssuranceSNTL.Models
{
    public class ContratTypeAssurance : BaseEntity
    {
        public int ContratId { get; set; } 
        public Contrat Contrat { get; set; } 

        public int TypeAssuranceId { get; set; } 
        public TypeAssurance TypeAssurance { get; set; } 
    }
}
