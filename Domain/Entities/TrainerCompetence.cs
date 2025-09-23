using AnotherDotnetToolkit.AspNetCoreExtensions;

namespace CorujinhaAPI.Domain.Entities
{
    public class TrainerCompetence : IEntity
    {
        public Guid Id { get; set; }
        public Trainer TrainerId { get; set; }
        public Competence CompetenceId { get; set; }
    }
}
