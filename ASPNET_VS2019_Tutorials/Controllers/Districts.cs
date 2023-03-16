using ASPNET_VS2019_Tutorials.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_VS2019_Tutorials.Controllers
{
    //Lesson 2:Configura a Service
    public class Districts : Controller
    {

        private readonly IMyServiceDistricts _myServiceDistricts;

        public Districts(IMyServiceDistricts myServiceDistricts)
        {
            _myServiceDistricts = myServiceDistricts;
        }

        public IActionResult ListDistricts()
        {
            string OpeningLine = "Districts Available: ";
            string textToShow = "";
            
            foreach (string district in _myServiceDistricts.districts)
            {
                textToShow = textToShow + district + ";";
            }
            
            return Content(OpeningLine+textToShow);
        }
    }
}
