using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.data.Repository.Core
{
    public interface IRepository<T> where T : class
    {
        Task Add(T entity);
        Task<T> GetById(Guid id);
        Task UpdateById(T entity);
        Task DeleteById(Guid id);
        Task Delete(T entity);
        Task<IEnumerable<T>> GetAll();

    }
}
