using AssuranceSNTL.DTO.Voiure;
using AssuranceSNTL.Models;
using AutoMapper;

namespace AssuranceSNTL.Portfiles;

public class VoitureMapper : Profile
{
    public VoitureMapper()
    {
        CreateMap<Voiture, VoitureReadDto>();
        CreateMap<VoitureCreateDto,Voiture>();
    }
}