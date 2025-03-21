using AssuranceSNTL.DTO.PackAssurance;
using AssuranceSNTL.Models;
using AutoMapper;

namespace AssuranceSNTL.Portfiles
{
    public class PackAssuranceMapper:Profile
    {
        public PackAssuranceMapper()
        {
            CreateMap<PackAssurance, PackAssuranceReadDto>()
                .ForMember(dest => dest.TypeAssurances, opt => opt.MapFrom(src => src.PackTypeAssurances.Select(pta => pta.TypeAssurance).ToList()));

            CreateMap<PackAssuranceCreateDto, PackAssurance>()
                .ForMember(dest => dest.PackTypeAssurances, opt => opt.Ignore()) 
                .AfterMap((src, dest) =>
                {
                    foreach (var typeAssuranceId in src.TypeAssuranceID)
                    {
                        dest.PackTypeAssurances.Add(new PackTypeAssurance
                        {
                            TypeAssuranceID = typeAssuranceId
                        });
                    }
                });
        }
    }
}
