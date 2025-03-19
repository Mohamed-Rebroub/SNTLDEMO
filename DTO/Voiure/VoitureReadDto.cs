namespace AssuranceSNTL.DTO.Voiure;

public class VoitureReadDto
{
    public string Marque { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Immatriculation  { get; set; } = string.Empty;
    public int Annee { get; set; } 
    public int PuissanceFiscale { get; set; }
    public int ClientId { get; set; } 
   
}