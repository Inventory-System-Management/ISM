using ISM.Domain.Models;

namespace ISM.Application.Interfaces
{
    public interface IChecks
    {
        public User Password(string login, string password);
    }
}
