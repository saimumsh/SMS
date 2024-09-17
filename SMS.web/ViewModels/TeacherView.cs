using Microsoft.AspNetCore.Mvc.Rendering;
using SMS.core.Models;
using System.ComponentModel.DataAnnotations;

namespace SMS.web.ViewModels
{
    public class TeacherView: BaseEntity
    {
        public string? Name { get; set; }
       
        public string? Email { get; set; }
       
        public string? Password { get; set; }
       
        public string? PhoneNumber { get; set; }
       
        public int Salary { get; set; }
        public IList<Teacher>? Teachers { get; set; }
        public int ClassId { get; set; }
        public int DesignationId { get; set; }
        public List<SelectListItem>? DesignationList { get; set; }
        public List<SelectListItem>? ClassList { get; set; }
    }
}
