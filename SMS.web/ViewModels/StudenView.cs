using Microsoft.AspNetCore.Mvc.Rendering;
using SMS.core.Models;
using System.ComponentModel.DataAnnotations;

namespace SMS.web.ViewModels
{
    public class StudenView:BaseEntity
    { 
        public string? Name { get; set; }
       
        public string? Email { get; set; }
       
        public string? Password { get; set; }
        
        public string? PhoneNumber { get; set; }
       
        public string? Address { get; set; }
        [Required]
        public Guid ClassId { get; set; }
        public ClassLevel? ClassLevel { get; set; }
    }
}
