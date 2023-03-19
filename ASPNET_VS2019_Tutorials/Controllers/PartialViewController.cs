using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_VS2019_Tutorials.Controllers
{
    public class PartialViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
