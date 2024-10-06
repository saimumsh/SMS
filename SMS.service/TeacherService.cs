using SMS.core.Models;
using SMS.data.Repository.Interfaces;
using SMS.service.Core;
using SMS.service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.service
{
    public class TeacherService:Service<Teacher>,ITeacherService
    {
        private readonly ITeacherRepository _teachers;
        public TeacherService(ITeacherRepository teacher):base(teacher) 
        {
            _teachers = teacher;

        }

        public async Task<IEnumerable<Teacher>> GetAllTeacherAsync()
        {
            return await _teachers.GetAllTeacherAsync();
        }
    }
}
