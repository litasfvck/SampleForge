using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleForge.Domain.Entities;

namespace SampleForge.Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users").HasKey(u => u.Id);
        
        // Properties
        builder.Property(u => u.Email).HasColumnName("email");
        builder.Property(u => u.UserName).HasColumnName("username");

        // Relations
        builder.HasMany(u => u.Samples)
            .WithOne(s => s.User)
            .HasForeignKey(s => s.UserId);

        builder.HasMany(u => u.Packs)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId);
    }
}
