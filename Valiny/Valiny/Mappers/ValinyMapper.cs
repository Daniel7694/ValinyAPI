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
            CreateMap<UserRegisterDTO, AppUser>(); // For registration
            // No direct mapping needed for UserLoginDTO to AppUser, as it's typically used just for authentication

            CreateMap<UserLoginResponseDTO, UserDTO>(); // Assuming UserLoginResponseDTO contains user data and token
        }
    }
}
