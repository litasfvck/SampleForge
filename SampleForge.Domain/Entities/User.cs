namespace SampleForge.Domain.Models;

public class User
{
    public Guid Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public ICollection<Sample> Samples { get; set; } = [];
    public ICollection<MIDI> MIDIs { get; set; } = [];
}
