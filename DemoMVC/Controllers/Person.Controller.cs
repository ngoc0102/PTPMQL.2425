using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
{
        public PersonController()
        {
        }

        public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index (string Address , string Fullname , int Tuoi)
    {
    string strOutput = " Xin chào "+ Address+ " - " + Fullname + "-" + Tuoi;
    ViewBag.Message = strOutput;
    return View();
    }
}
}

