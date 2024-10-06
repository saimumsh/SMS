using AutoMapper;
using SMS.core.Models;

namespace SMS.web.ViewModels
{
    public class DomMapper:Profile
    {
        public DomMapper()
        {
            CreateMap<StudenModel, Student>();
            CreateMap<Student, StudenModel>();
            CreateMap<Teacher, TeacherModel>();
            CreateMap<TeacherModel, Teacher>();
            CreateMap<ClassModel, ClassLevel>();
            CreateMap<ClassLevel,ClassModel>();
        }


    }
}
