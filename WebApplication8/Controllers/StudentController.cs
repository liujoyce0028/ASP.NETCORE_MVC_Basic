using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Details()
        {
            ViewBag.Title = "Student Details Page";
            ViewBag.Header = "Student Details";

            Student student = new Student()
            {
                StudentId = 101,
                Name = "Dillip",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };

            Address address = new Address()
            {
                AddressId = 1,
                City = "Mumbai",
                State = "Maharashtra",
                Country = "India",
                Pin = "400097"

            };
            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address,
                Title = "Student Details Page",
                Header = "Student Details",

            };

            return View(studentDetailsViewModel);
        }
    }
}