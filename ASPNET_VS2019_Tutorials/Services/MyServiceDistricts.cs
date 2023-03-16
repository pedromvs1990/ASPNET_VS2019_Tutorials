using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_VS2019_Tutorials.Services
{
    //Lesson2 : Configure a Service
    public class MyServiceDistricts : IMyServiceDistricts
    {
        public List<string> districts { get; set; }

        public MyServiceDistricts()
        {
            districts = new List<string>();
            districts.Add("Porto");
            districts.Add("Lisboa");
            districts.Add("Coimbra");
            districts.Add("Braga");
        }

        public void AddDistrict(string newDistrict)
        {
            districts.Add(newDistrict);
        }
    }
}
