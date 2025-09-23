using AnotherDotnetToolkit.AspNetCore;
using AnotherDotnetToolkit.AspNetCoreExtensions;

namespace CorujinhaAPI.Domain.Entities
{
    public class TrainerCompetence : BaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public Trainer TrainerId { get; set; }
        public Competence CompetenceId { get; set; }
    }
}
