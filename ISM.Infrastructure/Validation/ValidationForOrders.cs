using ISM.Application.interfaces;
using ISM.Domain.Models;
using ISM.Infrastructure.ISMDbcontext;

namespace ISM.Infrastructure.Validation
{
    public class ValidationForOrders : Ivalidation<Order>
    {
        private ISMdbcontext _dbcontext;
        public ValidationForOrders() => _dbcontext = new();

        public bool Create(Order objectname)
        {
            if (objectname == null)
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
            User user = _dbcontext.Users.Select(x => x).Where((x) => x.Id == Id).First();
            if (user != null) return true;
            return false;
        }
        public bool Update(Order objectname)
        {
            var Updateobject = _dbcontext.Users.Find(objectname.Id);
            if (Updateobject != null)
                return true;
            return false;
        }
    }
}
