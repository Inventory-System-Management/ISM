using ISM.Application.Interfaces.Roles;
using ISM.Domain.Models;
using ISM.Infrastructure.Repositories;
namespace ISM.Infrastructure.Services
{
    public class ServiceforRoles : IRoleService
    {
        private IRoleRepository _repository;
        public ServiceforRoles() => _repository = new RepositoryForRoles();

        public Role Create(Role Objectname)
        {
            _repository.Create(Objectname);
            return Objectname;
        }

        public int Delete(int id)
        {
            _repository.Delete(id);
            return id;
        }

        public IEnumerable<Role> GetAll()
        {
            return _repository.GetAll();
        }

        public Role Getbyid(int id)
        {
            return _repository.Getbyid(id);
        }
        public bool Update(Role objectname)
        {
            return _repository.Update(objectname);
        }
    }
}
