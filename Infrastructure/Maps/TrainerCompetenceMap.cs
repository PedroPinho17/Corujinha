using CorujinhaAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Maps
{
    internal class TrainerCompetenceMap : IEntityTypeConfiguration<TrainerCompetence>
    {
        public void Configure(EntityTypeBuilder<TrainerCompetence> builder)
        {
            builder.ToTable(nameof(TrainerCompetence));
            builder.HasKey(e => e.Id);
            builder.HasOne(e => e.Trainer).WithMany().HasForeignKey(e => e.TrainerId);
            builder.HasOne(e => e.Competence).WithMany().HasForeignKey(e => e.CompetenceId);
        }
    }
}
