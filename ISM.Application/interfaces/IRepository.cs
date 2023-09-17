using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM.Application.interfaces
{
    public interface IRepository<T>where T : class
    {
        public T Create(T Objectname);
        public bool Update(T objectname);
        public int Delete(int id);
        public List<T> GetAll();    
        public T Getbyid(int id);
    }
}
