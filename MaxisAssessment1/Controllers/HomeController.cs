using System.Diagnostics;
using MaxisAssessment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace MaxisAssessment1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
