using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.core.Models
{
    public class ClassLevel:BaseEntiry
    {
        public string Name { get; set; }
        List<Teacher> Teachers { get; set; }
        List<Student> Students { get; set; }
        List<Subject> Subjects { get; set; }
        public ResultSheet ResultSheet { get; set; }
    }
}
