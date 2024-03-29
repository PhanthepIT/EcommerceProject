using EcommerceProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EcommerceProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
