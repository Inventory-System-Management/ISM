using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM.Application1.interfaces
{
    public  interface Ivalidation<T>where T : class
    {
        public bool Create(T objectname);
        public bool Delete(int Id);
        public bool Update(T objectname);
        public bool Getall();
        public bool Getby(int Id);

    }
}
