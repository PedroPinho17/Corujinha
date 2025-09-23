using AnotherDotnetToolkit.AspNetCoreExtensions;

namespace CorujinhaAPI.Domain.Entities
{
    public class TrainerTraining : IEntity
    {
        public Guid Id { get; set; }
        public Trainer TrainerId { get; set; }
        public Training TrainingId { get; set; }
    }
}
