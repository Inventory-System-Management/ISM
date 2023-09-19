using ISM.Application.Interfaces.Orders;
using ISM.Domain.Models;
using ISM.Infrastructure.Repositories;

namespace ISM.Infrastructure.Services
{
    internal class ServiceForOrders:IOrderService
    {
        private IOrderRepository _repository;
        public ServiceForOrders() => _repository = new RepositoriyForOrders();
        public Order Create(Order Objectname)
        {
            return _repository.Create(Objectname);
        }

        public int Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _repository.GetAll();
        }
        public Order Getbyid(int id)
        {
            return _repository.Getbyid(id);
        }

        public bool Update(Order objectname)
        {
            return _repository.Update(objectname);
        }
    }
}
