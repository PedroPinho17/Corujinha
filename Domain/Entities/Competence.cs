using AnotherDotnetToolkit.AspNetCore;
using AnotherDotnetToolkit.AspNetCoreExtensions;

namespace CorujinhaAPI.Domain.Entities
{
    public class Competence : BaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; } 
    }
}
