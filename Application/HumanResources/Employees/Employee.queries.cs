using AnotherDotnetToolkit.MediatR.Queries;
using Monolitic_CQRS_Template.Domain.entities;

namespace Application.HumanResources.Employees
{
    public class GetAllEmployeesQuery : GetAllQuery<Employee>,IGetAllQuery<IReadOnlyList<Employee>?>
    {
        public GetAllEmployeesQuery()
        {
            IncludeParameters = ["EmployeeCategory"];
        }
    }

    public class GetEmployeeByIdQuery : IGetByIdQuery<Employee?>
    {
        public Guid EntityId { get; set; }
    }
}
