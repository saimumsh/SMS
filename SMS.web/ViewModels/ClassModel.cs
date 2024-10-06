using Microsoft.AspNetCore.Mvc.Rendering;
using SMS.core.Models;

namespace SMS.web.ViewModels
{
    public class ClassModel:BaseEntity
    {
        public string? ClassName { get; set; }
        public Guid TeacherId { get; set; }
        public IEnumerable<SelectListItem>? Teachers { get; set; }

    }
}
