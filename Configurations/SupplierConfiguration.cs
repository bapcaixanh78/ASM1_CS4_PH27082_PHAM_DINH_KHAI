using ASM1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM1.Configuration
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(t => t.IdSupplier);
            builder.Property(p=>p.Name).HasColumnType("nvarchar(100)");
            builder.Property(p=>p.Address).IsRequired().HasColumnType("nvarchar(100)");
            builder.Property(p=>p.Status).HasColumnType("nvarchar(100)");
        }
    }
}
