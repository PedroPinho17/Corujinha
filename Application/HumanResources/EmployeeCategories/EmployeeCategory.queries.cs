using AnotherDotnetToolkit.MediatR.Queries;
using Monolitic_CQRS_Template.Domain.entities;

namespace Application.HumanResources.EmployeeCategories
{
    public class GetAllEmployeeCategoriesQuery : GetAllQuery<EmployeeCategory>, IGetAllQuery<IReadOnlyList<EmployeeCategory>?>
    {
    }

    public class GetEmployeeCategoryByIdQuery : IGetByIdQuery<EmployeeCategory?>
    {
        public Guid EntityId { get; set; }
    }
}
