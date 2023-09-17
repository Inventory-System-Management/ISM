namespace ISM.Domain.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ContactInfo { get; set; }
        public string? Address { get; set; } = string.Empty;
    }
}
