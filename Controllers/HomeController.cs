using FirstLesson_BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstLesson_BackEnd.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            Student student1 = new Student("Kamala", "Jamalova", 21);
            Student student2 = new Student("Duygu", "Hasanzade", 17);
            Student student3 = new Student("Eli", "Nasrullayev", 24);
            Student student4 = new Student("Rafet", "Mammedov", 23);
            Student student5 = new Student("Xayal", "Aliyev", 25);

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);



            return View(students);
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
