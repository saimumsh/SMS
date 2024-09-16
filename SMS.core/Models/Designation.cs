using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.core.Models
{
    public class Designation:BaseEntiry
    {
        public string Title { get; set; }
        public string Description { get; set; }
        List<Teacher> Teachers { get; set; }

    }
}
