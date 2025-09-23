using AnotherDotnetToolkit.AspNetCore;
using AnotherDotnetToolkit.AspNetCoreExtensions;

namespace CorujinhaAPI.Domain.Entities
{
    /**
     * Represents an employee in the system (empregado)
     */
    public class Employee : BaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
