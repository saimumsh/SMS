using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic;
using SMS.core.Models;
using SMS.data.Repository;
using SMS.service;
using SMS.web.ViewModels;

namespace SMS.web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IClassService _class;
        private readonly IStudentService _student;
        private readonly IHostEnvironment _hostEnvironment;
        private readonly IMapper _mapper;
        
        public StudentController(IClassService classl, IHostEnvironment hostEnvironment,IStudentService studentService , IMapper mapper)
        {
            _class = classl;
            _hostEnvironment = hostEnvironment;
            _student = studentService;
            _mapper = mapper;

        }
        public async Task <IActionResult> Index()
        {

            var model = await _student.GetAllStudentAsync();
            return View(model);
        }
        public async Task<IActionResult> Create()
        {
            var model = await SelectClass();
           
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create( StudenView studenView)
        {
            if (ModelState.IsValid)
            {
                var model = new Student()
                {
                    Name = studenView.Name,
                    Email= studenView.Email,
                    Password= studenView.Password,
                    PhoneNumber= studenView.PhoneNumber,
                    Address= studenView.Address,
                    ClassLevelId=studenView.ClassId

                };
                await _student.Add(model);
                return RedirectToAction("Index");

            }

            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var student = await _student.GetById(id);
            //var model = SelectClass();
            var model = _mapper.Map<StudenView>(student);

            return View(model);
           
        }
        [HttpPost]
        public async Task <IActionResult> Edit(StudenView studenView)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<Student>(studenView); 
                await _student.Update(model);

            }
            return RedirectToAction("index");

        }
        public async Task<IActionResult> Delete(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var student = await _student.GetById(id);
           // var model = SelectClass();
            var model = _mapper.Map<StudenView>(student); 
            
           return View(model);
            
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> Delete(StudenView studenView)
        {
           if(ModelState.IsValid)
            {
                var model = _mapper.Map<Student>(studenView);
                await _student.Delete(model);
            }
            return RedirectToAction("Index");
          
        }
        public async Task< StudenView> SelectClass()
        {
            var model = new StudenView();
            //await Task.Run(() =>
            //{
            model.ClassList =  _class.GetAll().Result.Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.ID.ToString(),
            }).ToList();
            //});
            
            return model;
        }
    }
}
