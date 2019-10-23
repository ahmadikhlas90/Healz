using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Repository.Interfaces
{
   public  interface IRepository<T> where T:class
    {
        List<T> GetAll();
        T GetById(int id);
        T Delete(int idToSearch);
        void Update(int idToSearch, T entity);
        void Add(T entity);
        void save();
        void Remove(int id);
    }
}
