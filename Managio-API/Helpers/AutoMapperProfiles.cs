using AutoMapper;
using Managio_API.DTOs;
using Managio_API.Models;

namespace Managio_API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>();
            CreateMap<User, UserForDetailedListDto>();

            CreateMap<UserProject, ProjectsForDetailedUserDto>();
        }
    }
}