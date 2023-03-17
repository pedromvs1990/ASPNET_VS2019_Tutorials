using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_VS2019_Tutorials.Controllers
{

    //Lesson 3: Different Types of IAction Results
    public class ActionsResultsTypesController : Controller
    {
        public IActionResult ReturnView()
        {
            return View();
        }

        public IActionResult ReturnContent()
        {
            return Content("Hello");
        }

        public int ReturnInt()
        {
            return 123;
        }

        public string ReturnString()
        {
            return "123";
        }

        public IActionResult ReturnJson()
        {
            List<string> JsonExample = new List<string>() { "ABC", "DEF", "GHI" };
            return Json(JsonExample);

           
        }

        public IActionResult RedirecttoView()
        {
            return RedirectToAction("ReturnView");
        }
    }
}
