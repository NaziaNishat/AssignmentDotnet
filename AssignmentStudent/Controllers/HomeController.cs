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

                        var model = repo.retrieve(id);
                       return View(model);
//            return View();
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

        public IActionResult Edit(int id)
        {
            repo.update(id);
            return View();
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
