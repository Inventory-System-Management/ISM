using ISM.Application.interfaces;
using ISM.Application.Interfaces.Roles;
using ISM.Domain.Models;
using ISM.Infrastructure.ISMDbcontext;

namespace ISM.Infrastructure.Validation
{
    public class ValidationforRoles : IRoleValidation
    {
        private ISMdbcontext _ISMdbcontext;
        public ValidationforRoles()=>_ISMdbcontext = new();
        

        public bool Create(Role objectname)
        {
            if (objectname != null && objectname.Id != 0 && 
                (objectname.Position.Contains("Manager", StringComparison.OrdinalIgnoreCase)||
                objectname.Position.Contains("Seller",StringComparison.OrdinalIgnoreCase)|| 
                objectname.Position.Contains("Director", StringComparison.OrdinalIgnoreCase)||
                objectname.Position.Contains("Customer", StringComparison.OrdinalIgnoreCase))
                ) return true;
            return false;
        }

        public bool Delete(int Id)
        {
            var deletedobject = _ISMdbcontext.Roles.FirstOrDefault(i => i.Id == Id);
            if (deletedobject != null)
                return true;
              return false; 
        }

        public bool Getall()
        {
            List<Role> roles = _ISMdbcontext.Roles.ToList();  
            if (roles.Count > 0)
                return true;
         return false;
        }
        public bool Getby(int Id)
        {
          var getelement=_ISMdbcontext.Roles.FirstOrDefault(i=>i.Id==Id);
            if(getelement != null)
                return true;
                return false;
        }
        public bool Update(Role objectname)
        {
            Role? objectid =_ISMdbcontext.Roles.FirstOrDefault(i => i.Id == objectname.Id);
            if (objectname != null && objectname.Id != 0 &&
                  (objectname.Position.Contains("Manager", StringComparison.OrdinalIgnoreCase) ||
                  objectname.Position.Contains("Seller", StringComparison.OrdinalIgnoreCase) ||
                  objectname.Position.Contains("Director", StringComparison.OrdinalIgnoreCase) ||
                  objectname.Position.Contains("Customer", StringComparison.OrdinalIgnoreCase))
                  ) return true;
                return false;
        }
    }
}
