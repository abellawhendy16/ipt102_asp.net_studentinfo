using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var StudentInfoArray = new[]
            {
                new StudentInfoModel { Name = "Whendy Abella", StudentId = "21-1406", StudentAge = "21", Address= "Batasan Hills, Quezon City", StudentCourse = "Information Technology"},
                new StudentInfoModel { Name = "Greg Abella", StudentId = "21-1577", StudentAge = "29", Address = "Batasan Hills, Quezon City", StudentCourse = "Entrepreneurship"},
                new StudentInfoModel { Name = "Maddie Abella", StudentId = "21-1704", StudentAge = "28", Address = "Batasan Hills, Quezon City", StudentCourse = "Accountancy"},
                new StudentInfoModel { Name = "Ren Abella", StudentId = "21-1104", StudentAge = "20", Address = "Batasan Hills, Quezon City", StudentCourse = "Electronics Engineering"},
                new StudentInfoModel { Name = "Whendel Abella", StudentId = "21-1107", StudentAge = "20", Address = "Batasan Hills, Quezon City", StudentCourse = "Entrepreneurship"},
                new StudentInfoModel { Name = "Whox Abella", StudentId = "21-1510", StudentAge = "20", Address = "Batasan Hills, Quezon City", StudentCourse = "Electronics Engineering"},
                new StudentInfoModel { Name = "Rachelle Lumauig", StudentId = "21-1514", StudentAge = "24", Address = "Novaliches, Quezon City", StudentCourse = "EC Education"},
                new StudentInfoModel { Name = "Alliyah Enovidad", StudentId = "21-1517", StudentAge = "20", Address = "Novaliches, Quezon City", StudentCourse = "EC Education"},
                new StudentInfoModel { Name = "Nichole Calingasan", StudentId = "21-1741", StudentAge = "20", Address = "Bago Bantay, Quezon City", StudentCourse = "Accountancy"},
                new StudentInfoModel { Name = "Irene Balbacal", StudentId = "21-1744", StudentAge = "26", Address = "Bago Bantay, Quezon City", StudentCourse = "Entrepreneurship"},
                new StudentInfoModel { Name = "Flor Orante", StudentId = "21-1475", StudentAge = "27", Address = "Bago Bantay, Quezon City", StudentCourse = "Electronics Engineering"},
                new StudentInfoModel { Name = "Greg Vergara", StudentId = "21-1751", StudentAge = "25", Address = "Novaliches, Quezon City", StudentCourse = "Electronics Engineering"}
            };

            return View(StudentInfoArray);
        }
    }
}