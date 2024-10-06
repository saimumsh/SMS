using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.core.Models
{
    public class ResultSheet:BaseEntity
    { 
        public decimal MarksObtained { get; set; }
        public string Grade { get; set; }

        // Foreign Keys
        public Guid ExamID { get; set; }
        public Exam Exam { get; set; }

        public Guid StudentID { get; set; }
        public Student Student { get; set; }
    }

}
