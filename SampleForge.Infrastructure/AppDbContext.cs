using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SampleForge.Infrastructure.Configurations;
using System.Reflection;

namespace SampleForge.Infrastructure;

public class AppDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public AppDbContext() {}

    public AppDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    // вынесли из Program.cs подключение к ConnectionString
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("Database"));
    }

    // Подключение конфигураций сущностей
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // пример подключения всех конфигураций вручную
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new SampleConfiguration());
        modelBuilder.ApplyConfiguration(new PackConfiguration());
        modelBuilder.ApplyConfiguration(new TagConfiguration());
        modelBuilder.ApplyConfiguration(new SampleTagConfiguration());
        modelBuilder.ApplyConfiguration(new PackSampleConfiguration());

        // подключение конфигураций через Assembly
        // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
