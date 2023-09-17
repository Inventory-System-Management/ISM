using ISM.Application1.interfaces;
using ISM.Domain.Models;
using ISM.Infrastructure.ISMDbcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace ISM.Infrastructure.Repositories
{
    public class RepositoryForUsers : IRepository<User>
    {private ISMdbcontext _dbcontext;
        private Ivalidation<User> _ivalidation;
        public RepositoryForUsers()
        {
            _dbcontext = new ISMdbcontext();
            _ivalidation = new Validation.ValidationForUsers();
        }
        public User Create(User Objectname)
        {
            if ( _ivalidation.Create(Objectname) == true)
            {
                _dbcontext.Add(Objectname);
                _dbcontext.SaveChanges();
                return Objectname;
            }
            else
            {
                return null;
            }
        }

        public int Delete(int id)
        {
            if (_ivalidation. Delete(id) == true)
            {
                _dbcontext.Remove(id);
                _dbcontext.SaveChanges();
                return id;
            }
            else
            { return 0; }
        }

        public List<User> GetAll()
        {
            if (_ivalidation.Getall() == true)
            {
                return _dbcontext.Set<User>().ToList();

            }
            {
                return null;
            }
        }

        public User Getbyid(int id)
        {
            if(_ivalidation.Getby(id) == true)
            {
                return _dbcontext.Set<User>().FirstOrDefault(x => x.Id == id);

            }
            {
                return null;
            }
        }

        public bool Update( User objectname)
        {
            if (_ivalidation.Update(objectname) == true)
            {
                _dbcontext.Update(objectname);
                _dbcontext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
