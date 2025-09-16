using Application.HumanResources.EmployeeCategories;
using Application.HumanResources.Employees;
using AutoMapper;
using Monolitic_CQRS_Template.Domain.entities;

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
