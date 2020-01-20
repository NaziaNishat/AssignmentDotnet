using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssignmentStudent.Models;

namespace AssignmentStudent.Controllers
{
    public class HomeController : Controller
    {

        IRepo repo;
        int ID;

        public HomeController(IRepo repoImp)
        {
            repo = repoImp;
        }

        public IActionResult Index()
        {
            //return Ok("Ok");
            var model = repo.getAll();
            return View(model);
        }

        public IActionResult GetDetails(int id)
        {
            //System.Console.WriteLine("hlwwwwwwwwwwwwwww");
            //System.Diagnostics.Debug.WriteLine("aaaaaaaa");


            Student model = repo.retrieve(id);
            ViewBag.Student = model;
            //var model = repo.retrieve(id);
            // return View(model);
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public RedirectToActionResult Create(Student student)
        {
            //System.Console.WriteLine("hlwwwwwwwwwwwwwww");
            //repo.create(student);
            //Console.WriteLine("Createeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
            Student newStudent = repo.create(student);
            return RedirectToAction("", new { id = newStudent.id });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            Student student = repo.update(id);
 //           repo.update(id);
            return View(student);
        }

        [HttpPost]
        public RedirectToActionResult Edit(int id,Student student)
        {
            /*
            if (student.id != 0)
                repo.delete(student.id - 1);
            else
                repo.delete(0);
                */

            Student updatedStudent = repo.retrieve(id);
            updatedStudent.name = student.name;
            updatedStudent.department = student.department;
            //Student newStudent = repo.create(new Student { id = student.id, name = student.name, department = student.department });
            
            return RedirectToAction("");
        }

        public IActionResult Delete(int id)
        {
            repo.delete(id);
            return RedirectToAction("");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
