using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.Controllers
{
    public class RemediesController : Controller
    {
        public IActionResult DIYRemedies()
        {
            return View();
        }

        public IActionResult DIYRemediesRestlessness()
        {
            return View();
        }
    }
}