using System;
using System.Collections.Generic;
using AssuranceSNTL.Models.Common;

namespace AssuranceSNTL.Models
{
    public class Contrat : BaseEntity
    {
        public int ContratId { get; set; }
        public DateTime DateDebut { get; set; } 
        public DateTime DateFin { get; set; } 
        public decimal Montant { get; set; } 

        public int PackAssuranceId { get; set; } 
        public PackAssurance PackAssurance { get; set; } 

        public int VoitureId { get; set; } 
        public Voiture Voiture { get; set; } 

        public int ClientId { get; set; } 
        public Client Client { get; set; }

        public ICollection<ContratTypeAssurance> ContratTypeAssurances { get; set; } = new List<ContratTypeAssurance>();
    }
}
