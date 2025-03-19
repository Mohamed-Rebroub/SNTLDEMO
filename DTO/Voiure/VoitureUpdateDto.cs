using System.ComponentModel.DataAnnotations;

namespace AssuranceSNTL.DTO.Voiure;

public class VoitureUpdateDto
{
    [Required, MaxLength(100)] public string Marque { get; set; } = string.Empty;
    [Required, MaxLength(100)] public string Model { get; set; } = string.Empty;
    [Required, MaxLength(100)] public string Immatriculation { get; set; } = string.Empty;
    [Required] public int Annee { get; set; }
    [Required] public int PuissanceFiscale { get; set; }
    [Required] public int ClientId { get; set; }
}