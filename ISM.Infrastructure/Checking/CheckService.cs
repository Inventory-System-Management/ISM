using ISM.Application.Interfaces;
using ISM.Domain.Models;
using ISM.Infrastructure.Services;

namespace ISM.Infrastructure.Checking
{
    public class CheckService : IChecks
    {
        private readonly ServiceforUsers _users;
        private readonly ServiceForOrders _orders;
        private readonly ServiceforRoles _roles;
        public CheckService()
        {
            _users = new();
            _orders = new();
            _roles = new();
        }

        public User Password(string Email, string password)
        {
            //_users.Create(new() { Email=Email,FirstName="Zokir",LastName="Tuylibekov",Password="01231995",RoleId=_roles.GetAll().FirstOrDefault(i=>i.Position=="Director").Id});
            var users = _users;
            var ourUser = users.GetAll().FirstOrDefault(x => x.Email == Email && x.Password == password);
            if (ourUser != null)
                return ourUser;
            return null;
        }
    }
}
