using ISM.Application.interfaces;
using ISM.Application.Interfaces.Users;
using ISM.Domain.Models;
using ISM.Infrastructure.ISMDbcontext;

namespace ISM.Infrastructure.Validation
{
    public class ValidationForUsers : IUserValidation
    {
        private ISMdbcontext _dbcontext;
        public ValidationForUsers() => _dbcontext = new();

        public bool Create(User objectname)
        {
            if (objectname == null || string.IsNullOrEmpty(objectname.Email) || !objectname.Email.Contains("@gmail.com"))
                return false;
            return true;
        }
        public bool Delete(int Id)
        {
            var deletedobject = _dbcontext.Users.Select(x => x).Where(x => x.Id == Id);
            if (deletedobject.Count() > 0)
                return true;
            return false;
        }
        public bool Getall()
        {
            List<User> list = _dbcontext.Users.ToList();
            if (list.Count > 0) return true;
            return false;
        }
        public bool Getby(int Id)
        {
            User user = _dbcontext.Users.FirstOrDefault(i=>i.Id==Id);
            if (user != null) return true;
            return false;
        }

        public bool Update(User objectname)
        {
            var Updateobject = _dbcontext.Users.Find(objectname.Id);
            if (Updateobject != null)
                return true;
            return false;
        }
    }
}
