namespace ISM.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }=string .Empty;    
        public string LastName { get; set; } = string.Empty;
        public string Password { get; set; }=string .Empty;   
        public string Email { get; set; }=string .Empty;   
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public IList<Order> Order { get; set; }
    }
}
