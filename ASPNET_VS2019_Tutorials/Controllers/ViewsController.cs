using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_VS2019_Tutorials.Controllers
{
    public class ViewsController : Controller
    {

        //Lesson 4: Views
        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult Index1()
        {
            ViewData["Message"] = "Obs: this is Index1 Page";
            return View("Index");
        }

        public IActionResult Index2()
        {
            ViewData["Message"] = "Obs: this is Index2 Page";
            return View("Index");
        }

        public IActionResult Index3()
        {
            ViewData["Message"] = "Obs: this is Index3 Page";
            return View();

        }

        public IActionResult Index4()
        {
            return View();
        }
    }
}
