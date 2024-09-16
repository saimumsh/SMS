using SMS.core.Models;
using SMS.data.SMS_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.data.Repository
{
    public class AttendenceRepository : Repository<Attendence>, IAttendenceRepository
    {
        public AttendenceRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
