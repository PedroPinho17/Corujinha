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
    internal class EmployeeCompetenceMap : IEntityTypeConfiguration<EmployeeCompetence>
    {
        public void Configure(EntityTypeBuilder<EmployeeCompetence> builder)
        {
            builder.ToTable("EmployeeCompetence");
            builder.HasKey(e => e.Id);
            builder.HasOne(e => e.EmployeeId).WithMany().HasForeignKey("EmployeeId").OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.CompetenceId).WithMany().HasForeignKey("CompetenceId").OnDelete(DeleteBehavior.Cascade);
        }
    }
}
