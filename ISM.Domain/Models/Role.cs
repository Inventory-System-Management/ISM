namespace ISM.Domain.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Position { get; set; } = string.Empty;
        public User? User { get; set; }
    }
}
