using AnotherDotnetToolkit.AspNetCore;
using AnotherDotnetToolkit.AspNetCoreExtensions;

namespace CorujinhaAPI.Domain.Entities
{
    /**
     * Represents a training session or course (formação)
     */
    public class Training : BaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan Duration { get; set; }
        public string Location { get; set; }
    }
}
