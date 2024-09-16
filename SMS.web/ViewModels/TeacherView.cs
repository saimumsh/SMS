using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace SMS.web.ViewModels
{
    public class TeacherView
    {
        [Required(ErrorMessage = "Name is Required !")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is Required !")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is Required !")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Phone Number is Required !")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Salary is Required !")]
        [Display(Name = "Salary")]
        public int Salary { get; set; }
        [Required]
        public int ClassId { get; set; }
        public int DesignationId { get; set; }
        public List<SelectListItem>? DesignationList { get; set; }
        public List<SelectListItem>? ClassList { get; set; }
    }
}
