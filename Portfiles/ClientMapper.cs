using AssuranceSNTL.DTO.Client;
using AssuranceSNTL.Models;
using AutoMapper;

namespace AssuranceSNTL.Portfiles
{
    public class ClientMapper : Profile
    {
        public ClientMapper()
        {
            CreateMap<Client, ClientReadDto>();
            CreateMap<ClientCreateDto, Client>();
        }
    }
}