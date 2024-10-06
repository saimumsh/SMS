using SMS.core.Models;
using SMS.data.Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.data.Repository.Interfaces
{
    public interface IClassRepository : IRepository<ClassLevel>
    {
        Task<IEnumerable<ClassLevel>> GetClassLevelAllAsync();
    }
}
