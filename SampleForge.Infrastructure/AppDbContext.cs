using Microsoft.EntityFrameworkCore;
using SampleForge.Domain.Models;

namespace SampleForge.Infrastructure;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Sample> Samples { get; set; }
    public DbSet<MIDI> MIDIs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // подключение конфигураций для таблиц
        // modelBuilder.ApplyConfiguration(new UserConfiguration());
        // modelBuilder.ApplyConfiguration(new SampleConfiguration());
        // modelBuilder.ApplyConfiguration(new MIDIConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
