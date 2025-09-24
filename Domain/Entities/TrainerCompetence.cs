using AnotherDotnetToolkit.AspNetCore;
using AnotherDotnetToolkit.AspNetCoreExtensions;

namespace CorujinhaAPI.Domain.Entities
{
    public class TrainerCompetence : BaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public Guid TrainerId { get; set; }
        public Guid CompetenceId { get; set; }
        public Trainer? Trainer { get; set; }
        public Competence? Competence { get; set; }
    }
}
