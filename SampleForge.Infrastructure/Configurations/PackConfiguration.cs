using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleForge.Domain.Entities;

namespace SampleForge.Infrastructure.Configurations;

public class PackConfiguration : IEntityTypeConfiguration<Pack>
{
    public void Configure(EntityTypeBuilder<Pack> builder)
    {
        builder.ToTable("packs").HasKey(p => p.Id);

        // Properties
        builder.Property(p => p.Name).HasColumnName("name");
        builder.Property(p => p.Description).HasColumnName("description");
        builder.Property(p => p.CoverImagePath).HasColumnName("coverImagePath");

        // Relations
        builder.HasOne(p => p.User)
            .WithMany(u => u.Packs)
            .HasForeignKey(p => p.UserId);
    }
}
