using CihazTakip.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CihazTakip.Persistence.Mapper
{
    public sealed class BrandModelMapper : IEntityTypeConfiguration<BrandModel>
    {
        public void Configure(EntityTypeBuilder<BrandModel> builder)
        {
            builder.ToTable("BrandModel");
            builder.Property(e => e.Id).HasColumnType("int");
            builder.Property(e => e.Name).HasColumnType("varchar(500)");
            builder.Property(e => e.BrandId).IsRequired().HasColumnType("int");
            builder.Property(e => e.IsActive).IsRequired().HasColumnType("bit").HasDefaultValue(true);
            builder.HasOne(q => q.ProductBrand).WithMany(q => q.BrandModels).HasForeignKey(q => q.BrandId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
