﻿using ISM.Application.interfaces;
using ISM.Application.Interfaces.Base;
using ISM.Application.Interfaces.Users;
using ISM.Domain.Models;
using ISM.Infrastructure.ISMDbcontext;
using ISM.Infrastructure.Validation;

namespace ISM.Infrastructure.Repositories
{
    public class RepositoryForUsers : IUserRepository
    {private ISMdbcontext _dbcontext;
        private IUserValidation _ivalidation;
        public RepositoryForUsers()
        {
            _dbcontext = new ISMdbcontext();
            _ivalidation = new ValidationForUsers();
        }
        public User? Create(User Objectname)
        {
            if (_ivalidation.Create(Objectname) == true)
            {
                _dbcontext.Users.Add(Objectname);
                _dbcontext.SaveChanges();
                return Objectname;
            }
                return null;
        }

        public int Delete(int id)
        {
            if (_ivalidation. Delete(id) == true)
            { 
                User? user= _dbcontext.Users.FirstOrDefault(i=>i.Id==id);
                _dbcontext.Users.Remove(user);
                _dbcontext.SaveChanges();
                return id;
            }
            return 0;
        }

        public IEnumerable<User>? GetAll()
        {
            if (_ivalidation.Getall() == true) return _dbcontext.Set<User>().ToList();
            return null;
        }

        public User? Getbyid(int id)
        {
            if(_ivalidation.Getby(id) == true) return _dbcontext.Users.FirstOrDefault(x => x.Id == id);
            return null;
        }

        public bool Update( User objectname)
        {
            if (_ivalidation.Update(objectname) == true)
            {
                _dbcontext.Update(objectname);
                _dbcontext.SaveChanges();
                return true;
            }
                return false;
        }
    }
}
