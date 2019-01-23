namespace StudentSystem.Controllers
{
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;

    using StudentSystem.Data;
    using StudentSystem.Models;

    public class StudentController : Controller

    {
        private readonly StudentSystemDbContext context;

        public StudentController(StudentSystemDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var students = this.context.Students.ToList();
            return this.View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            context.Add(model);
            context.SaveChanges();
            return RedirectToAction("index");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = context.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            context.Students.Update(model);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = context.Students.Find(id);
            context.Students.Remove(student);
            context.SaveChanges();
            return RedirectToAction("index");
        }

        //[HttpGet]
        //public IActionResult Details()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
