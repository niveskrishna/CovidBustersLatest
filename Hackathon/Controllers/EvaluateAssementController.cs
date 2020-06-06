using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.Controllers
{
    public class EvaluateAssementController : Controller
    {
        public IActionResult RoutineAssesment()
        {
            return View();
        }
    }
}