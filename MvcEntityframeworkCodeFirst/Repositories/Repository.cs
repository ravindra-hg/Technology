using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MvcEntityframeworkAndProfiling.DbContexts;

namespace MvcEntityframeworkAndProfiling.Repositories
{
    public class Repository<T> : IRepository<T> where T: class
    {
        MusicDatabaseContext context = new MusicDatabaseContext();

        protected DbSet<T> DbSet
        {
            get;
            set;
        }

        public Repository()
        {
            DbSet = context.Set<T>();
        }

        public List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(T t)
        {
            DbSet.Add(t);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
        
        public void Remove(T t)
        {
            DbSet.Remove(t);
        }
    }
}