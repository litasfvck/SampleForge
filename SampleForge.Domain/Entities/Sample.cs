namespace SampleForge.Domain.Models;

public enum SampleType { OneShot, Loop, FX, Instrument }

public class Sample
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public SampleType Type { get; set; }
    public Guid UserId { get; set; }
    public User? User { get; set; }
}
