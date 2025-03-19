using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AssuranceSNTL.Models.Common;

namespace AssuranceSNTL.Models;

public class Client : BaseEntity
{
    [Key]
    public int CLientId { get; set; }
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
    
    //navigation
    public IEnumerable<Voiture> Voitures { get; set; } = [];
}