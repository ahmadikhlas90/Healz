using Healz.DatabaseConnection;
using Healz.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Healz.Repository.Implimentation
{
    public class Repository<T> :IRepository<T> where T:class
    {
        private readonly AppDbContext Context;
        public Repository(AppDbContext context) => Context = context;

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public T Delete(int idToSearch)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public void Remove(int id)
        {

            //var type= Context.Set<T>().ToList();
            var type= Context.Set<T>().Find(id);
            Context.Remove(type);
        }

     
        public void Update(int idToSearch, T entity)
        {
            var v = Context.Set<T>().Find(idToSearch);
            if (v != null)
            {
                Context.Set<T>().Attach(entity);
            }
        }

        public void save()
        {
            Context.SaveChanges();
        }

    }
}
