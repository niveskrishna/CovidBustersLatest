using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.Controllers
{
    public class MentalHealthAssesmentController : Controller
    {
       
        public IActionResult RoutineAssesment()
        {
            return View();
        }

        public IActionResult SleepDisorderAssesment()
        {
            return View();
        }

        public IActionResult AnxietyAssesment()
        {
            return View();
        }

        public IActionResult StressAssesment()
        {
            return View();
        }


        public IActionResult DepressionAssesment()
        {
            return View();
        }
    }
}