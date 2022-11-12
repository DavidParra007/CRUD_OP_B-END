using Entities._Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interface
{
    public interface ICRUD<T> where T : EntityBase
    {
        public IEnumerable<T> All();
        public T Get(int id);
        
        public void Add(T item);
        public void Update(T item);
        public void Delete(int id);
        public T getLast();
    }
}
