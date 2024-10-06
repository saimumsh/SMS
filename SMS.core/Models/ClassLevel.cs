using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.core.Models
{
    public class ClassLevel:BaseEntity
    {
        public string Name { get; set; }
        public Guid TeacherId { get; set; }
        public Teacher? Teacher { get; set;}
        ICollection<Student>? Students { get; set; }
        ICollection<Subject>? Subjects { get; set; }        
    }
}
