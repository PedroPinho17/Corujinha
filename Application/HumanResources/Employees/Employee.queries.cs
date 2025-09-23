using AnotherDotnetToolkit.MediatR.Queries;
using CorujinhaAPI.Domain.Entities;

namespace Application.HumanResources.Employees
{
    public class GetAllEmployeesQuery : GetAllQuery<Employee>,IGetAllQuery<IReadOnlyList<Employee>?>
    {
        public GetAllEmployeesQuery()
        {
            IncludeParameters = ["EmployeeCategory"];
        }
    }

    public class GetEmployeeByIdQuery : GetByIdQuery<Employee>, IGetByIdQuery<Employee?>
    {
        public GetEmployeeByIdQuery()
        {
            IncludeParameters = ["EmployeeCategory"];
        }
    }
}
