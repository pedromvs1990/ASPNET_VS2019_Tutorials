using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_VS2019_Tutorials.Controllers
{

    //Lesson 3: Actions with Parameters


    public class Parameters : Controller
    {
        public IActionResult Index(int id)
        {
            return Content(id.ToString());
        }
        //QueryString: https://localhost:44395/parameters/index?id=123
        //MVC Route notation: https://localhost:44395/parameters/index/123


        public IActionResult Index2(int id, string name, int age)
        {
            string _id = id.ToString();
            string _name = name;
            string _age = age.ToString();

            return Content(_id +"\n"+_name+"\n"+_age);
        }
        //QueryString: https://localhost:44395/parameters/index2?id=1&name=Pedro&age=32
        //MVC Route notation:https://localhost:44395/parameters/index2/1?name=Pedro&age=32


        //receive data by the action parameters (recommended)
        public IActionResult ClientRegister(int id, string name, string address, int age)
        {
            return View();
        }

       
        public IActionResult ShowClient(int id, string name, string address, int age)
        {
            int _id = id;
            string _name = name;
            string _address = address;
            int _age = age;
            return Content("Customer Id: " + _id + "\n" + "Customer Name: " + _name + "\n" + "Customer Address: " + _address + "\n" + "Customer Age: " + _age);
        }


        //receive data by Request.Form (POST)
        public IActionResult ClientRegisterPost(int id, string name, string address, int age)
        {
            return View();
        }

        public IActionResult ShowClientPost(int id, string name, string address, int age)
        {
            string _id = Request.Form["id"].ToString();
            string _name = Request.Form["name"];
            string _address = Request.Form["address"];
            string _age= Request.Form["age"];

            return Content("Customer Id: " + id + "\n" + "Customer Name: " + name + "\n" + "Customer Address: " + address + "\n" + "Customer Age: " + age);
        }

        //receive data by Request.Query (GET)

        public IActionResult ClientRegisterGet(int id, string name, string address, int age)
        {
            return View();
        }

        public IActionResult ShowClientGet(int id, string name, string address, int age)
        {
            string _id = Request.Query["id"].ToString();
            string _name = Request.Query["name"];
            string _address = Request.Query["address"];
            string _age = Request.Query["age"];

            return Content("Customer Id: " + id + "\n" + "Customer Name: " + name + "\n" + "Customer Address: " + address + "\n" + "Customer Age: " + age);
        }

    }
}
