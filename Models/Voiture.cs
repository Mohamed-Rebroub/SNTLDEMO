using System.ComponentModel.DataAnnotations;
using AssuranceSNTL.Models.Common;

namespace AssuranceSNTL.Models;

public class Voiture : BaseEntity
{
    [Key]
    [Required] public int VoitureId { get; set; }

    [Required] public string Marque { get; set; } = string.Empty;
    [Required] public string Model { get; set; } = string.Empty;
    [Required] public string Immatriculation  { get; set; } = string.Empty;
    public int Annee { get; set; } 
    public int PuissanceFiscale { get; set; } 
    public int ClientId { get; set; } 
    public Client Client { get; set; }


}