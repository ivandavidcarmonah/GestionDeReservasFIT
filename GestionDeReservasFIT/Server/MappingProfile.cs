using AutoMapper;
using GestionDeReservasFIT.Shared;
using GestionDeReservasFIT.Shared.DTO;

namespace GestionDeReservasFIT.Server
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDetailDTO>();
            CreateMap<UserDetailDTO, User>();

        }
    }
}
