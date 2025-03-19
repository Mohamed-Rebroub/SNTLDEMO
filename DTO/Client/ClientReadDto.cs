using System;

namespace AssuranceSNTL.DTO.Client;

public class ClientReadDto
{
    public string Nom { get; set; } = string.Empty;
    public string Prenom { get; set; } = string.Empty;
    public string CIN { get; set; } = string.Empty;
    public string Addresse { get; set; } = string.Empty;
    public string Telephone { get; set; } = string.Empty;
    public DateTime DateNaissance { get; set; }   
}