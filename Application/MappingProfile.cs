using AutoMapper;
using Domain.Entities;
using Domain.Enums;

namespace Application;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Account, Dto.Account>();
        CreateMap<Service, Dto.Service>();
        CreateMap<License, Dto.License>();
        CreateMap<States, Enums.States>();
    }
}