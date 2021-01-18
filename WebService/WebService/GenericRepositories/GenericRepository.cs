using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebService.model;

namespace WebService.GenericRepositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        QL_NHAHANGEntities2 _entity = null;
        public DbSet<T> table = null;

        public GenericRepository()
        {
            this._entity = new QL_NHAHANGEntities2();
            table = _entity.Set<T>();
        }

        public GenericRepository(QL_NHAHANGEntities2 _enitity)
        {
            this._entity = _entity;
            table = _enitity.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }


        public void Update(T obj)
        {
            table.Attach(obj);
            _entity.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }


        public void Save()
        {
            _entity.SaveChanges();
        }

    }
}