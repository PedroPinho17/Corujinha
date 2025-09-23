using AnotherDotnetToolkit.AspNetCore;
using AnotherDotnetToolkit.AspNetCoreExtensions;

namespace CorujinhaAPI.Domain.Entities
{
    public class EmployeeCompetence : BaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public Employee EmployeeId { get; set; }
        public Competence CompetenceId { get; set; }
    }
}
