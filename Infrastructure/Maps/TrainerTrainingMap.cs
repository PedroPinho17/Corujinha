using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorujinhaAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Maps
{
    internal class TrainerTrainingMap : IEntityTypeConfiguration<TrainerTraining>
    {
        public void Configure(EntityTypeBuilder<TrainerTraining> builder)
        {
            builder.ToTable("TrainerTraining");
            builder.HasKey(e => e.Id);
            builder.HasOne(e => e.TrainerId).WithMany().HasForeignKey("TrainerId").OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.TrainingId).WithMany().HasForeignKey("TrainingId").OnDelete(DeleteBehavior.Cascade);

        }
    }
}
