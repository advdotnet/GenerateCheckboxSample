using GenerateCheckboxSample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GenerateCheckboxSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(CheckboxViewModel vm)
        {
            if (ModelState.IsValid)
            {
                return View(vm);
            }
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
