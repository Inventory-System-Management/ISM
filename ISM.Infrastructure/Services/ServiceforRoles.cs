using ISM.Application.interfaces;
using ISM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM.Infrastructure.Services
{
    public class ServiceforRoles : Iservice<Role>
    {
        private IRepository<Role> _repository;
        public ServiceforRoles()
        {
            _repository=new Repositories.RepositoryForRoles();
        }
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
