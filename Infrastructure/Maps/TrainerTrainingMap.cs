using CorujinhaAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Maps
{
    internal class TrainerTrainingMap : IEntityTypeConfiguration<TrainerTraining>
    {
        public void Configure(EntityTypeBuilder<TrainerTraining> builder)
        {
            builder.ToTable(nameof(TrainerTraining));
            builder.HasKey(e => e.Id);
            builder.HasOne(e => e.Trainer).WithMany().HasForeignKey(e => e.TrainerId);
            builder.HasOne(e => e.Training).WithMany().HasForeignKey(e => e.TrainingId);

        }
    }
}
