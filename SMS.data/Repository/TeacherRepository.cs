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
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        private readonly ApplicationDbContext _db;
        public TeacherRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Teacher>> GetAllTeacherAsync()
        {
            var teachers = await _db.Teachers.Include(x=>x.Classes).Include(x=>x.Subjects).ToListAsync();
            return teachers;
        }
    }
}
