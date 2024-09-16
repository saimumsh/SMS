using AutoMapper;
using SMS.core.Models;

namespace SMS.web.ViewModels
{
    public class DomMapper:Profile
    {
        public DomMapper()
        {
            CreateMap<StudenView, Student>();
            CreateMap<Student, StudenView>();
        }


    }
}
