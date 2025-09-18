using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CorujinhaAPI.Domain.entities;

namespace Infrastructure.Maps
{
    internal class EmployeeCategoryMap : IEntityTypeConfiguration<EmployeeCategory>
    {
        public void Configure(EntityTypeBuilder<EmployeeCategory> builder)
        {
            builder.ToTable(nameof(EmployeeCategory));
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
        }
    }
}
