using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SMS.core.Models;
using SMS.service.Interfaces;
using SMS.web.ViewModels;

namespace SMS.web.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassService _ClassService;
        private readonly ITeacherService _TeacherService;
        private IMapper _Mapper;
        public ClassController( IClassService classService, ITeacherService teacherService,IMapper mapper)
        {
            _ClassService = classService;
            _TeacherService = teacherService;
            _Mapper = mapper;

        }
        public async Task<IActionResult> Index()
        {
            var model = await _ClassService.GetAll();
            return View(model);
        }
        public async Task<IActionResult> Add()
        {
            var model = new ClassModel();
            var Teachers = await _TeacherService.GetAll();
            model.Teachers = new SelectList(Teachers, "Id", "FullName");
            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> Add(ClassModel classModel)
        {
            if(ModelState.IsValid)
            {
                var model = _Mapper.Map<ClassLevel>(classModel);
                await _ClassService.Add(model);
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
            var classlevel = _ClassService.GetById(id);
            var model = _Mapper.Map<ClassModel>(classlevel);           
            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(ClassModel classModel)
        {
            if (ModelState.IsValid)
            {
                var model = _Mapper.Map<ClassLevel>(classModel);
                await _ClassService.Update(model);

            }
            return RedirectToAction("index");

        }
        [HttpPost]
        public async Task<IActionResult> Delete(ClassModel classModel)
        {
            if (ModelState.IsValid)
            {
                var model = _Mapper.Map<ClassLevel>(classModel);
                await _ClassService.Delete(model);
            }
            return RedirectToAction("Index");

        }
    }
}
