using ISM.Application.Interfaces.Base;
using ISM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM.Infrastructure.Services
{
    public class ServiceforUsers : Iservice<User>
    {
        private IRepository<User> _repository;
        public ServiceforUsers()
        {
            
            _repository=new Repositories.RepositoryForUsers();
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
