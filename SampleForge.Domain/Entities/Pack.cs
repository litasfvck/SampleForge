namespace SampleForge.Domain.Entities
{
    public class Pack
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? CoverImagePath { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }

        public ICollection<PackSample> Samples { get; set; } = [];
    }
}
