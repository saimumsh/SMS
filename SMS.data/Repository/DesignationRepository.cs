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
    public class DesignationRepository : Repository<Designation>, IDesignationRepository
    {
        private readonly ApplicationDbContext _context;
        public DesignationRepository(ApplicationDbContext db) : base(db)
        {
            _context = db;
        }
    }
}
