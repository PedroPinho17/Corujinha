using Application.HumanResources.Employees;
using AutoMapper;
using CorujinhaAPI.Domain.Entities;

namespace Application.HumanResources
{
    public class HumanResourcesMapperProfile : Profile
    {
        public HumanResourcesMapperProfile()
        {
            CreateMap<EmployeeCreateCommand, Employee>().ReverseMap();
        }
    }
}
