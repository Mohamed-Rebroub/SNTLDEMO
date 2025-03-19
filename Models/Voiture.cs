using System.ComponentModel.DataAnnotations;
using AssuranceSNTL.Models.Common;

namespace AssuranceSNTL.Models;

public class Voiture : BaseEntity
{
    [Key]
    [Required]
    public int VoitureId { get; set; }
    [Required,MaxLength(100)] 
    public string Marque { get; set; } = string.Empty;
    [Required,MaxLength(100)] 
    public string Model { get; set; } = string.Empty;
    [Required,MaxLength(100)] 
    public string Immatriculation  { get; set; } = string.Empty;
    [Required]
    public int Annee { get; set; } 
    [Required]  
    public int PuissanceFiscale { get; set; }
    [Required]  
    public int ClientId { get; set; } 
    public Client Client { get; set; }
    
}