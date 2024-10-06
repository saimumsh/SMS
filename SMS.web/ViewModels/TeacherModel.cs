using Microsoft.AspNetCore.Mvc.Rendering;
using SMS.core.Models;
using System.ComponentModel.DataAnnotations;

namespace SMS.web.ViewModels
{
    public class TeacherModel: BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }       
        public string? Email { get; set; }       
        public string? Password { get; set; }      
        public string? PhoneNumber { get; set; }       
        public int Salary { get; set; }                  
        public IEnumerable<SelectListItem>? DesignationList { get; set; }
        public IEnumerable<SelectListItem>? ClassList { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}
