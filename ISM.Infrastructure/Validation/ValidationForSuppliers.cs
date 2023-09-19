using ISM.Application.Interfaces.Suppliers;
using ISM.Domain.Models;
using ISM.Infrastructure.ISMDbcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM.Infrastructure.Validation
{
    public class ValidationForSuppliers : ISupplierValidation
    { private ISMdbcontext _dbcontext;
        public ValidationForSuppliers()=>_dbcontext = new ISMdbcontext();
        public bool Create(Supplier objectname)
        {
            if (objectname != null && objectname.Id != 0 && objectname.ContactInfo.Contains("+998") && objectname.ContactInfo.Length == 13&&objectname.Name!=null)
                return true;
            return false;
        }
        public bool Delete(int Id)
        {
            var deletedobject = _dbcontext.Suppliers.FirstOrDefault(x => x.Id == Id);   
            if (deletedobject != null)
                return true;
            return false;
        }

        public bool Getall()
        {
            List<Supplier> roles = _dbcontext.Suppliers.ToList();
            if (roles.Count > 0)
                return true;
            return false;
        }

        public bool Getby(int Id)
        {
            Supplier Supplier = _dbcontext.Suppliers.FirstOrDefault(x => x.Id == Id);
            if (Supplier != null)
                return true;
            return false;
        }

        public bool Update(Supplier objectname)
        {
            var Updateobject = _dbcontext.Suppliers.Update(objectname);
            if (Updateobject != null)
                return true;
            return false;
        }
    }
}
