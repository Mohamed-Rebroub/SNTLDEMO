using AssuranceSNTL.DTO.PackAssurance;
using AssuranceSNTL.Models;
using AutoMapper;

namespace AssuranceSNTL.Portfiles
{
    public class PackAssuranceMapper:Profile
    {
        public PackAssuranceMapper()
        {
            CreateMap<PackAssurance, PackAssuranceReadDto>();
            CreateMap<PackAssuranceCreateDto, PackAssurance>();
        }
    }
}
