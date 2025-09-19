using AnotherDotnetToolkit.MediatR.Queries;
using CorujinhaAPI.Domain.entities;

namespace Application.HumanResources.EmployeeCategories
{
    public class GetAllEmployeeCategoriesQuery : GetAllQuery<EmployeeCategory>, IGetAllQuery<IReadOnlyList<EmployeeCategory>?>
    {
    }

    public class GetEmployeeCategoryByIdQuery : GetByIdQuery<Employee>,  IGetByIdQuery<EmployeeCategory?>
    {
    }
}
