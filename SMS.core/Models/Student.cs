using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.core.Models
{
    public class Student : BaseEntity
    {
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Display(Name = "Password")]
        public string? Password { get; set; }

        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }
        [Display(Name = "Address")]
        public string? Address { get; set; }
        public ICollection<ClassLevel> ClassLevel { get; set; }
        public Attendence? Attendence { get; set; }
        public ResultSheet? ResultSheet { get; set; }
        [NotMapped]
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}
