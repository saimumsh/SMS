using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.core.Models
{
    public class Teacher : BaseEntiry
    {
        public string Name { get; set; }
        public string Email {  get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int Salary { get; set; }
        public int ClassId {  get; set; }
        [ForeignKey(nameof(DesignationId))]
        public int DesignationId { get; set; } 
        [ForeignKey(nameof(ClassId))]
        public ClassLevel ClassLevel { get; set; }
        public Designation Designation { get; set; }

    }
}
