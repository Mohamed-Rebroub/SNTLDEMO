using System;
using System.ComponentModel.DataAnnotations;

namespace AssuranceSNTL.DTO.Client;

public class ClientCreateDto
{
    [Required,MaxLength(100)]
    public string Nom { get; set; } = string.Empty;
    [Required,MaxLength(100)]
    public string Prenom { get; set; } = string.Empty;
    [Required,MaxLength(100)] 
    public string CIN { get; set; } = string.Empty;
    [Required,MaxLength(100)]
    public string Addresse { get; set; } = string.Empty;
    [Required,MaxLength(100)]
    public string Telephone { get; set; } = string.Empty;
    [Required,MaxLength(100)]
    public DateTime DateNaissance { get; set; }
}