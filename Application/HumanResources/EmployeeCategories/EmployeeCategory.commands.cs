using AnotherDotnetToolkit.MediatR.Commands;
using CorujinhaAPI.Domain.entities;

namespace Application.HumanResources.EmployeeCategories
{
    public class EmployeeCategoryCreateCommand : CreateCommand<EmployeeCategory>, ICreateCommand<EmployeeCategory>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
    }

    public class EmployeeCategoryUpdateCommand : EmployeeCategoryCreateCommand, IUpdateCommand<EmployeeCategory>
    {
    }

    public class EmployeeCategoryDeleteCommand : EmployeeCategoryCreateCommand, IDeleteCommand<EmployeeCategory>
    {
    }
}
