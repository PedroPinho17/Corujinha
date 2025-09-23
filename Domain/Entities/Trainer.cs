using AnotherDotnetToolkit.AspNetCore;
using AnotherDotnetToolkit.AspNetCoreExtensions;

namespace CorujinhaAPI.Domain.Entities
{
    /**
     * Represents a trainer or instructor for training sessions (formador)
     */
    public class Trainer : BaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
