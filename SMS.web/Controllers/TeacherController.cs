using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SMS.core.Models;
using SMS.service;
using SMS.service.Interfaces;
using SMS.web.ViewModels;

namespace SMS.web.Controllers
{
    public class TeacherController : Controller
    {
        private readonly IClassService _class;
        private readonly ITeacherService _teacher;
        //private readonly IDesigntionService _designationService;
        private readonly IHostEnvironment _hostEnvironment;
        private readonly IMapper _mapper;

        public TeacherController(IClassService classl, IHostEnvironment hostEnvironment, ITeacherService teacherService,IMapper mapper)
        {
            _class = classl;
            _hostEnvironment = hostEnvironment;
            _teacher = teacherService;
            //_designationService = designtionService;
            _mapper = mapper;

        }      
        public async Task<IActionResult> Index()
        {
            var model = await _teacher.GetAllTeacherAsync();          
            return View(model);
        }
        public async Task<IActionResult> Add()
        {
            var model = new TeacherModel();
            var Classes = await _class.GetAll();
            //var Designations = await _designationService.GetAll();
            model.ClassList = new SelectList(Classes, "Id", "Name");
            //model.DesignationList = new SelectList(Designations, "Id", "Title");
            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> Add(TeacherModel teacherModel)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<Teacher>(teacherModel);
                await _teacher.Add(model);
                return RedirectToAction("Index");

            }
            return View();
        }
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var teacher = _teacher.GetById(id);
            var model = _mapper.Map<Teacher>(teacher);
            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(TeacherModel teacherModel)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<Teacher>(teacherModel);
                await _teacher.Update(model);

            }
            return RedirectToAction("index");

        }
        [HttpPost]
        public async Task<IActionResult> Delete(TeacherModel teacherModel)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<Teacher>(teacherModel);
                await _teacher.Delete(model);
            }
            return RedirectToAction("Index");

        }
    }
}
