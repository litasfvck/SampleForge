namespace SampleForge.Domain.Models;

public class MIDI
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Guid UserId { get; set; }
    public User? User { get; set; }
}
