using AnotherDotnetToolkit.AspNetCoreExtensions;

namespace CorujinhaAPI.Domain.entities
{
    public class EmployeeCategory : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
