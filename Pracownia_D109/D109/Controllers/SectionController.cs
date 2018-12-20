using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace D109.Controllers
{
    public class SectionController : Controller
    {
        public IActionResult Mechatronic()
        {
            return View();
        }
        public IActionResult Mechatronic1()
        {
            return View("Views/Section/Mechatronic/Position1.cshtml");
        }
        public IActionResult Mechatronic2()
        {
            return View("Views/Section/Mechatronic/Position2.cshtml");
        }
        public IActionResult Mechatronic3()
        {
            return View("Views/Section/Mechatronic/Position3.cshtml");
        }
        public IActionResult Mechatronic4()
        {
            return View("Views/Section/Mechatronic/Position4.cshtml");
        }
        public IActionResult Mechatronic5()
        {
            return View("Views/Section/Mechatronic/Position5.cshtml");
        }
        public IActionResult Automation()
        {
            return View();
        }
        public IActionResult Automation1()
        {
            return View("Views/Section/Automation/Position1.cshtml");
        }
        public IActionResult Automation2()
        {
            return View("Views/Section/Automation/Position2.cshtml");
        }
        public IActionResult Automation3()
        {
            return View("Views/Section/Automation/Position3.cshtml");
        }
        public IActionResult Automation4()
        {
            return View("Views/Section/Automation/Position4.cshtml");
        }
        public IActionResult Automation5()
        {
            return View("Views/Section/Automation/Position5.cshtml");
        }
        public IActionResult Industry()
        {
            return View();
        }
        public IActionResult Room()
        {
            return View();
        }
        
    }
}