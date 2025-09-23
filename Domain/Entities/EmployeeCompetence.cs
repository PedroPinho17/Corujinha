using AnotherDotnetToolkit.AspNetCoreExtensions;

namespace CorujinhaAPI.Domain.Entities
{
    public class EmployeeCompetence : IEntity
    {
        public Guid Id { get; set; }
        public Employee EmployeeId { get; set; }
        
        public Competence CompetenceId { get; set; }
    }
}
