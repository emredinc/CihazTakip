using CihazTakip.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CihazTakip.Persistence.Mapper
{
    public sealed class ProductBrandMapper : IEntityTypeConfiguration<ProductBrand>
    {
        public void Configure(EntityTypeBuilder<ProductBrand> builder)
        {
            builder.ToTable("ProductBrand");
            builder.Property(e => e.Id).HasColumnType("int");
            builder.Property(e => e.Name).HasColumnType("varchar(500)");
            builder.Property(e => e.ProductId).IsRequired().HasColumnType("int");
            builder.Property(e => e.IsActive).IsRequired().HasColumnType("bit").HasDefaultValue(true);
            builder.HasOne(q => q.Product).WithMany(q => q.ProductBrands).HasForeignKey(q => q.ProductId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
