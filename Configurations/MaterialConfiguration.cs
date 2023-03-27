using ASM1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM1.Configuration
{
    public class MaterialConfiguration : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder.HasKey(p => p.IdMaterial);
            builder.Property(p => p.Name).HasColumnType("nvarchar(100)");
            builder.Property(p => p.Code).HasColumnType("nvarchar(100)");
            builder.Property(p => p.AvailableQuantity).HasColumnType("int");
            builder.Property(p=>p.Status).HasColumnType("nvarchar(1000)");
            //builder.HasOne(p => p.Supplier).WithMany(p => p.Materials).HasForeignKey(p => p.IDSupplier).HasConstraintName("FK_SP");
        }
    }
}
