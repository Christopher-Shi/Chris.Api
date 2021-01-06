using AutoMapper;
using Chris.Api.Entities;
using Chris.Api.Models;

namespace Chris.Api.Profiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyDto>()
                .ForMember(
                    dest => dest.CompanyName,
                    option => option.MapFrom(src => src.Name));

            CreateMap<CompanyAddDto, Company>();
        }
    }
}
