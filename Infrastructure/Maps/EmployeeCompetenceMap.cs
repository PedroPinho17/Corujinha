using CorujinhaAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Maps
{
    internal class EmployeeCompetenceMap : IEntityTypeConfiguration<EmployeeCompetence>
    {
        public void Configure(EntityTypeBuilder<EmployeeCompetence> builder)
        {
            builder.ToTable(nameof(EmployeeCompetence));
            builder.HasKey(e => e.Id);
            builder.HasOne(e => e.Employee).WithMany().HasForeignKey(e => e.EmployeeId);
            builder.HasOne(e => e.Competence).WithMany().HasForeignKey(e => e.CompetenceId);
        }
    }
}
