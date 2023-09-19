using ISM.Application.Interfaces.Users;
using ISM.Domain.Models;
using ISM.Infrastructure.Repositories;


namespace ISM.Infrastructure.Services
{
    public class ServiceforUsers : IUserService
    {
        private IUserRepository _repository;
        public ServiceforUsers()
        {
            
            _repository=new RepositoryForUsers();
        }
        public User Create(User Objectname)
        {
          return  _repository.Create(Objectname); 
        }

        public int Delete(int id)
        {
           return _repository.Delete(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }

        public User Getbyid(int id)
        {
           return _repository.Getbyid(id);
        }

        public bool Update(User objectname)
        {
           return _repository.Update(objectname);
        }
    }
}
