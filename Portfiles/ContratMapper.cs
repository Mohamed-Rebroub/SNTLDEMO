using AssuranceSNTL.DTO.Contrat;
using AssuranceSNTL.Models;
using AutoMapper;

namespace AssuranceSNTL.Portfiles
{
    public class ContratMapper:Profile
    {
        public ContratMapper()
        {
            CreateMap<Contrat, ContratReadDto>()
                .ForMember(dest => dest.TypeAssurances, opt => opt.MapFrom(src => src.ContratTypeAssurances.Select(cta => cta.TypeAssurance).ToList()));

            CreateMap<ContratCreateDto, Contrat>()
                .ForMember(dest => dest.ContratTypeAssurances, opt => opt.Ignore()) 
                .AfterMap((src, dest) =>
                {
                    foreach (var typeAssuranceId in src.TypeAssuranceIds)
                    {
                        dest.ContratTypeAssurances.Add(new ContratTypeAssurance
                        {
                            TypeAssuranceId = typeAssuranceId
                        });
                    }
                });
        }
    }
}
