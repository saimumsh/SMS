using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.data.Repository
{
    public interface IRepository<T > where T : class
    {
        Task Add(T entity);
        Task<T> GetById(int id);
        Task UpdateById(T entity);
        Task DeleteById(int id);
        Task Delete(T entity);
        Task<IEnumerable<T>> GetAll();

    }
}
