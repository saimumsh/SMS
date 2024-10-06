using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SMS.core.Models
{
    public class Exam:BaseEntity
    {    
        public DateTime ExamDate { get; set; }
        public string ExamType { get; set; }

        // Foreign Keys
        public Guid SubjectID { get; set; }
        public Subject Subject { get; set; }

        public Guid ClassID { get; set; }
        public ClassLevel Class { get; set; }
        public ICollection<ResultSheet> Results { get; set; }
    }

}
