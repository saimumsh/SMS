using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.core.Models
{
    public class Student : BaseEntiry
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public ClassLevel ClassLevel { get; set; }
        public int ClassLevelId { get; set; }
        public Attendence Attendence { get; set; }
        public ResultSheet ResultSheet { get; set; }

    }
}
