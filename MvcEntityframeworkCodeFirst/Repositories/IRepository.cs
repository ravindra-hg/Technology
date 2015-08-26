using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcEntityframeworkAndProfiling.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T t);
        void Remove(T t);
        void SaveChanges();
    }
}