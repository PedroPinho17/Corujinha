using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CorujinhaAPI.Domain.entities;

namespace Infrastructure.Maps
{
    internal class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable(nameof(Employee));
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            builder.HasOne(e => e.EmployeeCategory).WithMany().HasForeignKey(e => e.EmployeeCategoryId);
        }
    }
}
