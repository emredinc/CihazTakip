using CihazTakip.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CihazTakip.Persistence.Mapper
{
    public sealed class ProductMapper : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.Property(e => e.Id).HasColumnType("int");
            builder.Property(e => e.Name).HasColumnType("varchar(500)");
            builder.Property(e => e.IsActive).IsRequired().HasColumnType("bit").HasDefaultValue(true);
        }
    }
}
