using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_VS2019_Tutorials.Controllers
{
    public class RouteDataController : Controller
    {
        public IActionResult Index(int id)
        {
            string _id = RouteData.Values["id"].ToString();
            return Content(_id);
        }
    }
}
