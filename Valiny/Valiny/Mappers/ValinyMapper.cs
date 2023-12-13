using AutoMapper;
using Valiny.Models;
using Valiny.Models.DTOs;

namespace Valiny.Mappers
{
    public class ValinyMapper : Profile
    {
        public ValinyMapper() 
        {
            CreateMap<AppUser, UserDTO>().ReverseMap();

            CreateMap<UserLoginResponseDTO, UserDTO>(); // Assuming UserLoginResponseDTO contains user data and token
        }
    }
}
