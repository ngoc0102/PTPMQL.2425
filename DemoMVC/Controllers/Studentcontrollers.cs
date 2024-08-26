using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class Studentcontroller : Controller
{
        public Studentcontroller()
        {
        }

        public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index (Student stt)
    {
    string strOutput = " Xin chào "+ stt.Fullname + " - " + stt.StudentID;
    ViewBag.Message = strOutput;
    return View();
    }
}
}

