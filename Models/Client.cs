using System;
using System.ComponentModel.DataAnnotations;
using AssuranceSNTL.Models.Common;

namespace AssuranceSNTL.Models;

public class Client : BaseEntity
{
    [Key]
    public int CLientId { get; set; }
    [Required] public string Nom { get; set; } = string.Empty;
    [Required] public string Prenom { get; set; } = string.Empty;
    [Required] public string CIN { get; set; } = string.Empty;
    [Required] public string Addresse { get; set; } = string.Empty;
    [Required] public string Telephone { get; set; } = string.Empty;
    [Required] public DateTime DateNaissance { get; set; }

}