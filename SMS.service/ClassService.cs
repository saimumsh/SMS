using SMS.core.Models;
using SMS.data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.service
{
    public class ClassService:Service<ClassLevel>,IClassService
    {
        public ClassService(IClassRepository classLevel):base(classLevel) 
        {
            
        }
    }
}
