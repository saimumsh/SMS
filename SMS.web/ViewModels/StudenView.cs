using Microsoft.AspNetCore.Mvc.Rendering;
using SMS.core.Models;
using System.ComponentModel.DataAnnotations;

namespace SMS.web.ViewModels
{
    public class StudenView
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
        [Required(ErrorMessage = "Adress is Required !")]
        [Display(Name = "Adress")]
        public string Address { get; set; }
        [Required]
        public int  ClassId { get; set; }
        public List<SelectListItem> ?ClassList { get; set; }
    }
}
