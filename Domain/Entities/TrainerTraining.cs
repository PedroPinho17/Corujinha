using AnotherDotnetToolkit.AspNetCore;
using AnotherDotnetToolkit.AspNetCoreExtensions;

namespace CorujinhaAPI.Domain.Entities
{
    public class TrainerTraining : BaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public Guid TrainerId { get; set; }
        public Guid TrainingId { get; set; }
        public Trainer? Trainer { get; set; }
        public Training? Training { get; set; }
    }
}
