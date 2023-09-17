using ISM.Application1.interfaces;
using ISM.Domain.Models;
using ISM.Infrastructure.ISMDbcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM.Infrastructure.Validation
{
    public class ValidationForUsers : Ivalidation<User>
    { private ISMdbcontext _dbcontext;
        public ValidationForUsers()
        {
            _dbcontext = new ISMdbcontext();
        }
        public bool Create(User objectname)
        {
            if (objectname == null || string.IsNullOrEmpty(objectname.Email) || !objectname.Email.Contains("@gmail.com"))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool Delete(int Id)
        {
            var deletedobject=_dbcontext.Users.Select(x=>x).Where(x=>x.Id==Id);
            if(deletedobject.Count() > 0)
            {
                return true;
            }
            return false;

            
        }

        public bool Getall()
        {
            List<User> list = _dbcontext.Users.ToList();
            if(list.Count > 0)
            {
                return true;
            }
            else { return false; }
        }

        public bool Getby(int Id)
        {
            User user = _dbcontext.Users.Select(x=>x).Where((x)=>x.Id==Id).First();
            if (user!=null)
            {
                return true;
            }
            else { return false; }
        }

        public bool Update(User objectname)
        {
            var Updateobject = _dbcontext.Users.Find(objectname.Id);
            if (Updateobject != null)
            {
                return true;
            }
            return false;   
          

        }
    }
}
