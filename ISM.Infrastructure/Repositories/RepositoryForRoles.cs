using ISM.Application.interfaces;
using ISM.Domain.Models;
using ISM.Infrastructure.ISMDbcontext;
namespace ISM.Infrastructure.Repositories
{
    public class RepositoryForRoles : IRepository<Role>
    {private ISMdbcontext _dbcontext;
        private Validation.ValidationforRoles _validation;
        public RepositoryForRoles()
        {
            _dbcontext = new ISMdbcontext();
            _validation = new Validation.ValidationforRoles();
        }
        public Role Create(Role Objectname)
        {
            if (_validation.Create(Objectname) == true)
            {
              _dbcontext.Roles.Add(Objectname);
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
           if(_validation.Delete(id) == true)
            {
                _dbcontext.Roles.Remove(_dbcontext.Roles.Find(id));
                _dbcontext.SaveChanges() ;
                return id;
            }
           else 
            { return 0; }
        }

        public List<Role> GetAll()
        {
            if (_validation.Getall() == true)
            {
                return _dbcontext.Roles.ToList();

            }
            else
            {
                return null;
            }
        }

        public Role Getbyid(int id)
        {
            if (_validation.Getby(id) == true)
            {
                return _dbcontext.Roles.Find(id);

            }
            {
                return null;
            }

        }

        public bool Update(Role objectname)
        {
           if(_validation.Update(objectname) == true)
            {   _dbcontext.Roles.Update(objectname);
                _dbcontext.SaveChanges ();
                return true;
            }
           else
            {
                return false;
            }
        }
    }
}
