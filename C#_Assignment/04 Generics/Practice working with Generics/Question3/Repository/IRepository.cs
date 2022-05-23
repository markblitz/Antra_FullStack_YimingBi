using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3.Repository
{
    public interface IRepository<T> where T : class
    {
        public void Add(T item);

        public void Remove(T item);
        public void Save();
        public IEnumerable<T> GetAll();
        public T GetById(int id);
    }
}
