using AnotherDotnetToolkit.MediatR.Commands;
using CorujinhaAPI.Domain.entities;

namespace Application.HumanResources.Employees
{
    public class EmployeeCreateCommand : CreateCommand<Employee>, ICreateCommand<Employee>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public Guid EmployeeCategoryId { get; set; }
    }

    public class EmployeeUpdateCommand : EmployeeCreateCommand, IUpdateCommand<Employee>
    {
        // Inherits properties from EmployeeCreateCommand
    }

    public class EmployeeDeleteCommand : EmployeeCreateCommand, IDeleteCommand<Employee>
    {
        // Inherits properties from EmployeeCreateCommand
    }
}
