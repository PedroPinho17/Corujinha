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
    internal class TrainerCompetenceMap : IEntityTypeConfiguration<TrainerCompetence>
    {
        public void Configure(EntityTypeBuilder<TrainerCompetence> builder)
        {
            builder.ToTable("TrainerCompetence");
            builder.HasKey(e => e.Id);
            builder.HasOne(e => e.TrainerId).WithMany().HasForeignKey("TrainerId").OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.CompetenceId).WithMany().HasForeignKey("CompetenceId").OnDelete(DeleteBehavior.Cascade);
        }
    }
}
