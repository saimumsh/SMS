using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SMS.service;
using SMS.web.ViewModels;

namespace SMS.web.Controllers
{
    public class TeacherController : Controller
    {
        private readonly IClassService _class;
        private readonly ITeacherService _teacher;
        private readonly IDesigntionService _designationService;
        private readonly IHostEnvironment _hostEnvironment;
        private readonly IMapper _mapper;

        public TeacherController(IClassService classl, IHostEnvironment hostEnvironment, ITeacherService teacherService, IDesigntionService designtionService,IMapper mapper)
        {
            _class = classl;
            _hostEnvironment = hostEnvironment;
            _teacher = teacherService;
            _designationService = designtionService;
            _mapper = mapper;

        }
       
        public async Task<IActionResult> Index()
        {
            var model = await SelectClass();

            return View(model);
        }
        public async Task<TeacherView> SelectClass()
        {
            var model = new TeacherView();
            //await Task.Run(() =>
            //{
            model.ClassList = _class.GetAll().Result.Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.ID.ToString(),
            }).ToList();
            model.DesignationList = _designationService.GetAll().Result.Select(c => new SelectListItem
            {
                Text = c.Title,
                Value = c.ID.ToString(),
            }).ToList();
            //});

            return model;
        }
    }
}
