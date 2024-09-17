﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.core.Models
{
    public class ResultSheet:BaseEntity
    {
        public int Marks { get; set; }
        public string ExamTerm { get; set; }
        public ICollection<Subject> Subjects { get; set; }
       
    }
}
