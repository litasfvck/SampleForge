using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleForge.Domain.Entities;

namespace SampleForge.Infrastructure.Configurations;

public class SampleConfiguration : IEntityTypeConfiguration<Sample>
{
    public void Configure(EntityTypeBuilder<Sample> builder)
    {
        builder.ToTable("samples").HasKey(s => s.Id);

        // Properties
        builder.Property(s => s.Name).HasColumnName("name");
        builder.Property(s => s.FilePath).HasColumnName("filePath");
        builder.Property(s => s.Type).HasColumnName("type")
            .HasConversion<string>();
        builder.Property(s => s.Duration).HasColumnName("duration");
        builder.Property(s => s.Bpm).HasColumnName("bpm");
        builder.Property(s => s.Key).HasColumnName("key");

        // Relations
        builder.HasOne(s => s.User)
            .WithMany(u => u.Samples)
            .HasForeignKey(s => s.UserId);
    }
}
