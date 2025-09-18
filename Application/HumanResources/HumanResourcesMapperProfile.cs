using Application.HumanResources.EmployeeCategories;
using Application.HumanResources.Employees;
using AutoMapper;
using CorujinhaAPI.Domain.entities;

namespace Application.HumanResources
{
    public class HumanResourcesMapperProfile : Profile
    {
        public HumanResourcesMapperProfile()
        {
            CreateMap<EmployeeCategoryCreateCommand, EmployeeCategory>().ReverseMap();
            CreateMap<EmployeeCreateCommand, Employee>().ReverseMap();
        }
    }
}
