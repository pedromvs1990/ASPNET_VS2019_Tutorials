using System.Collections.Generic;

namespace ASPNET_VS2019_Tutorials.Services
{
    //Lesson2 : Configure a Service
    public interface IMyServiceDistricts
    {
        List<string> districts { get; set; }

        void AddDistrict(string newDistrict);
    }
}