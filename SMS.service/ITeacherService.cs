using SMS.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.service
{
    public interface ITeacherService:IService<Teacher>
    {
        Task<IEnumerable<Teacher>> GetAllTeacherAsync();
    }
}
