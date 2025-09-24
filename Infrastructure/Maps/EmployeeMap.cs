using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CorujinhaAPI.Domain.Entities;

namespace Infrastructure.Maps
{
    internal class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable(nameof(Employee));
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(100);
            builder.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(15);
            builder.Property(e => e.BirthDate).IsRequired();
        }
    }
}
