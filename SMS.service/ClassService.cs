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
    public class ClassService:Service<ClassLevel>,IClassService
    {
        private readonly IClassRepository _classRepository;
        public ClassService(IClassRepository classLevel):base(classLevel) 
        {
            _classRepository = classLevel;
            
        }

        public async Task<IEnumerable<ClassLevel>> GetClassLevelAllAsync()
        {
            return await _classRepository.GetClassLevelAllAsync();            
        }
    }
}
