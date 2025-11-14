using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleForge.Domain.Entities;

namespace SampleForge.Infrastructure.Configurations;

public class SampleTagConfiguration : IEntityTypeConfiguration<SampleTag>
{
    public void Configure(EntityTypeBuilder<SampleTag> builder)
    {
        builder.ToTable("sample_tags").HasKey(sk => new {sk.SampleId, sk.TagId});

        builder.HasOne(sk => sk.Sample)
            .WithMany(s => s.Tags)
            .HasForeignKey(s => s.TagId);


        builder.HasOne(sk => sk.Tag)
            .WithMany(t => t.Samples)
            .HasForeignKey(t => t.SampleId);
    }
}
