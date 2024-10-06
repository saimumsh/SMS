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
    public class DesignationService : Service<Designation>, IDesigntionService
    {
        private readonly IDesignationRepository _designationRepository;
        public DesignationService(IDesignationRepository designation) : base(designation)
        {
            _designationRepository = designation;
        }
    }
}
