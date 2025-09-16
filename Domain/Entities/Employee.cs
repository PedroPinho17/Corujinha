
using AnotherDotnetToolkit.AspNetCoreExtensions;

namespace Monolitic_CQRS_Template.Domain.entities
{
    public class Employee : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public Guid EmployeeCategoryId { get; set; }
        public EmployeeCategory? EmployeeCategory { get; set; }
    }
}
