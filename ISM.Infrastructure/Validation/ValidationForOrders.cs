using ISM.Application.Interfaces.Orders;
using ISM.Domain.Models;
using ISM.Infrastructure.ISMDbcontext;
namespace ISM.Infrastructure.Validation
{
    public class ValidationForOrders :IOrderValidation
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
            var deletedobject = _dbcontext.Orders.Select(x => x).Where(x => x.Id == Id);
            if (deletedobject.Count() > 0)
                return true;
            return false;
        }
        public bool Getall()
        {
            List<Order> list = _dbcontext.Orders.ToList();
            if (list.Count > 0) return true;
            return false;
        }
        public bool Getby(int Id)
        {
            Order order = _dbcontext.Orders.Select(x => x).Where((x) => x.Id == Id).First();
            if (order != null) return true;
            return false;
        }
        public bool Update(Order objectname)
        {
            var Updateobject = _dbcontext.Orders.Find(objectname.Id);
            if (Updateobject != null)
                return true;
            return false;
        }
    }
}
