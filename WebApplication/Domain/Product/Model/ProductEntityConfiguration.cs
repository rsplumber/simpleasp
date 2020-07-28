 using Microsoft.EntityFrameworkCore;
 using Microsoft.EntityFrameworkCore.Metadata.Builders;
 using WebApplication.Domain.Product;

 namespace WebApplication.Domain.Product.Model
{
    public class ProductEntityConfiguration :IEntityTypeConfiguration<ProductEntity>
    {

        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {

            builder.ToTable("products");

            builder.HasKey(keyExpression: product => product.ProductId);

            builder.Property(cb => cb.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(cb => cb.Title)
                .IsRequired()
                .HasMaxLength(100);

        }
    }
}