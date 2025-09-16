using AnotherDotnetToolkit.MediatR.Queries;
using Monolitic_CQRS_Template.Domain.entities;

namespace Application.HumanResources.Employees
{
    public class GetAllEmployeesQuery : IGetAllQuery<IReadOnlyList<Employee>?>
    {
    }

    public class GetEmployeeByIdQuery : IGetByIdQuery<Employee?>
    {
        public Guid EntityId { get; set; }
    }
}
