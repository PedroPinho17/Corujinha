using AnotherDotnetToolkit.AspNetCoreExtensions;

namespace Monolitic_CQRS_Template.Domain.entities
{
    public class EmployeeCategory : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
