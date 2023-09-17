using ISM.Application.interfaces;
using ISM.Domain.Models;
using ISM.Domain.States;
using ISM.Infrastructure.ISMDbcontext;

namespace ISM.Infrastructure.Validation
{
    public class ValidationforRoles : Ivalidation<Role>
    {
        private ISMdbcontext _ISMdbcontext;
        public ValidationforRoles()=>_ISMdbcontext = new();
        

        public bool Create(Role objectname)
        {
            if (objectname != null && objectname.Id != 0 && (objectname.RoleE == RoleE.Seller || objectname.RoleE == RoleE.Customer || objectname.RoleE == RoleE.Manager || objectname.RoleE == RoleE.Director))
                return true;
                return false;
        }

        public bool Delete(int Id)
        {
            var deletedobject = _ISMdbcontext.Roles.Select(x=>x).Where(x=>x.Id == Id);
            if (deletedobject != null)
                return true;
      return false; 
        }

        public bool Getall()
        {
            List<Role> roles = _ISMdbcontext.Roles.Select(x=> x).ToList();  
            if (roles.Count > 0)
                return true;
         return false;
        }
        public bool Getby(int Id)
        {
          var getelement=_ISMdbcontext.Roles.Select(x=>x).Where(_ => _.Id == Id);
            if(getelement != null)
                return true;
                return false;
        }

        public bool Update(Role objectname)
        {var objectid=_ISMdbcontext.Roles.Select(x=>x).Where(x=>x.Id==objectname.Id);
            if (objectname != null && objectid.Count()!= 0 && (objectname.RoleE == RoleE.Seller || objectname.RoleE == RoleE.Customer || objectname.RoleE == RoleE.Manager || objectname.RoleE == RoleE.Director))
                return true;
                return false;
        }
    }
}
