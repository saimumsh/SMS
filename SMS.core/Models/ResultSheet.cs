using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.core.Models
{
    public class ResultSheet:BaseEntiry
    {
        public int Marks { get; set; }
        public string ExamTerm { get; set; }
        //public Subject Subject { get; set; }
        //public int SubjectID { get; set; }
        public Student Student { get; set; }
        public int StudentID { get; set; }
        public ClassLevel ClassLevel { get; set; }
        public int ClassLevelID { get; set;}
    }
}
