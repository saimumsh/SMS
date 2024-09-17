using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.core.Models
{
    public class Subject:BaseEntity
    {
        public string SubjectName {  get; set; }
        public string SubjectCode { get; set; }
        public ClassLevel ClassLevel { get; set; }
        public ResultSheet ResultSheet { get; set; }
      

    }
}
