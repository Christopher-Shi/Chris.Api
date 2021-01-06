using System;
using AutoMapper;
using Chris.Api.Entities;
using Chris.Api.Models;

namespace Chris.Api.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.Name,
                    option => option.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.GenderDisplay,
                    option => option.MapFrom(src => src.Gender.ToString()))
                .ForMember(dest => dest.Age,
                    option => option.MapFrom(src => DateTime.Now.Year - src.DateOfBirth.Year
                    ));

            CreateMap<EmployeeAddDto, Employee>();

            CreateMap<EmployeeUpdateDto, Employee>();

            CreateMap<Employee, EmployeeUpdateDto>();
        }
    }
}
