using Microsoft.EntityFrameworkCore;
using SMS.core.Models;
using SMS.data.Repository.Interfaces;
using SMS.data.SMS_Data;
using SMS.service.Core;
using SMS.service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.service
{
    public class StudentService : Service<Student>, IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository repository) : base(repository)
        {
            _studentRepository = repository;
        }

        public async Task<IEnumerable<Student>> GetAllStudentAsync()
        {
            return await _studentRepository.GetAllStudentAsync();
        }
    }
}
