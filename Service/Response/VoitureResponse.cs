using AssuranceSNTL.Models;

namespace AssuranceSNTL.Service.Response;

public class VoitureResponse
{
    public string Message { get; set; } = string.Empty;
    public Voiture? Voiture;
}