using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.Configurations
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Languages");
            builder.Property(x => x.Id).HasMaxLength(5).IsRequired().IsUnicode(false);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);

        }
    }
}