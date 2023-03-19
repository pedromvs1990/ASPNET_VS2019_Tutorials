using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_VS2019_Tutorials.Controllers
{
    public class ViewBagController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Salutation = "Hello World!";
            return View();
        }

        public IActionResult Index2(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}
