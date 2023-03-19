using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_VS2019_Tutorials.Controllers
{

    //Lesson 4: Standard HTML href ; HTML and TAG Helpers
    public class HelpersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StandardHTML()
        {
            return View();
        }

        public IActionResult StandardHTML_Param()
        {
            return View();
        }
        public IActionResult HTMLHelper()
        {
            return View();
        }
        public IActionResult HTMLHelper_Param()
        {
            return View();
        }

        public IActionResult TagHelper()
        {
            return View();
        }

        public IActionResult TagHelper_Param()
        {
            return View();
        }

    }
}
