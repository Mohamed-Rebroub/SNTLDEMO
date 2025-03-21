using AssuranceSNTL.DTO.TypeAssurance;
using AssuranceSNTL.Models;
using AutoMapper;

namespace AssuranceSNTL.Portfiles
{
    public class TypeAssuranceMapper:Profile
    {
        public TypeAssuranceMapper()
        {
            CreateMap<TypeAssurance, TypeAssuranceReadDto>();
            CreateMap<TypeAssuranceCreateDto, TypeAssurance>();
        }
    }
}
