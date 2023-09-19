using ISM.Application.Interfaces.Suppliers;
using ISM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM.Infrastructure.Services
{
    public class ServiceforSuppliers : ISupplierService
    {
        private ISupplierService _supplierService;
        public ServiceforSuppliers() => _supplierService = new ServiceforSuppliers();
        public Supplier Create(Supplier Objectname)
        {
            return _supplierService.Create(Objectname);
        }

        public int Delete(int id)
        {
            return _supplierService.Delete(id);
        }

        public IEnumerable<Supplier> GetAll()
        {
            return _supplierService.GetAll();
        }

        public Supplier Getbyid(int id)
        {
            return _supplierService.Getbyid(id);
        }

        public bool Update(Supplier objectname)
        {
            return _supplierService.Update(objectname);
        }
    }
}
