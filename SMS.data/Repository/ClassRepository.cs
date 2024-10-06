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
    public class ClassRepository : Repository<ClassLevel>, IClassRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ClassRepository(ApplicationDbContext db) : base(db)
        {
            _dbContext = db;
        }

        public async Task<IEnumerable<ClassLevel>> GetClassLevelAllAsync()
        {
            var Classes = await _dbContext.ClassLevels.Include(x=>x.Teacher).ToListAsync();
            return Classes;
        }
    }
}
