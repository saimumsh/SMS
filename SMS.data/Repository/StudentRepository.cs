using Microsoft.EntityFrameworkCore;
using SMS.core.Models;
using SMS.data.Repository.Core;
using SMS.data.Repository.Interfaces;
using SMS.data.SMS_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.data.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext db) : base(db)
        {
            _context = db;
        }
        public async Task<IEnumerable<Student>> GetAllStudentAsync()
        {
            var stdents = await _context.Students.Include(x => x.ClassLevel).ToListAsync();
            return stdents;
        }
    }
}
