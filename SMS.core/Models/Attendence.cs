using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.core.Models
{
    public class Attendence:BaseEntiry
    {
        public DateTime DateTime { get; set; }
        public bool Ispresent { get; set; }

        public Student Student { get; set; }
        public int  StudentID { get; set; }

    }
}
