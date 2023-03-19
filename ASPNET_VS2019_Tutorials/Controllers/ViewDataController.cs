using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_VS2019_Tutorials.Controllers
{
    //Lesson 3: ViewData
    public class ViewDataController : Controller
    {
        public IActionResult Index()
        {

            ViewData["CurrentTime"] = DateTime.Now;
            return View();
        }
    }
}
