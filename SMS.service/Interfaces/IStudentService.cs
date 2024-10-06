using SMS.core.Models;
using SMS.service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.service.Interfaces
{
    public interface IStudentService : IService<Student>
    {
        Task<IEnumerable<Student>> GetAllStudentAsync();
    }
}
