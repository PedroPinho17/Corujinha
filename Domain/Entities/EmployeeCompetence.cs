using AnotherDotnetToolkit.AspNetCore;
using AnotherDotnetToolkit.AspNetCoreExtensions;

namespace CorujinhaAPI.Domain.Entities
{
    public class EmployeeCompetence : BaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid CompetenceId { get; set; }
        public Employee? Employee { get; set; }
        public Competence? Competence { get; set; }
    }
}
