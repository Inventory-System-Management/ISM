using ISM.Domain.States;
namespace ISM.Domain.Models
{
    public class Role
    {
        public int Id { get; set; }
        public RoleE RoleE { get; set; }

        public User? User { get; set; }
    }
}
