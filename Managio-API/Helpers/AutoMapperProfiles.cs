using System.Linq;
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

            CreateMap<UserProject, ProjectsForDetailedUserDto>()
                .ForMember(dto => dto.IsFinished, opt => opt.MapFrom(x => x.Project.IsFinished));


            CreateMap<Project, ProjectsForListDto>();
            CreateMap<Project, ProjectForDetailedDto>();

            CreateMap<UserProject, UsersForDetailedProjectDto>();

            CreateMap<UserProject, UsersForDetailedProjectDto>()
                .ForMember(dto => dto.FirstName, opt => opt.MapFrom(x => x.User.FirstName))
                .ForMember(dto => dto.LastName, opt => opt.MapFrom(x => x.User.LastName));


        }
    }
}