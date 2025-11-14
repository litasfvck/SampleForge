namespace SampleForge.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;

    public ICollection<Sample> Samples { get; set; } = [];
    public ICollection<Pack> Packs { get; set; } = [];
}
