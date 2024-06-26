﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovies.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(String name, int numTimes = 1)
        {
            ViewData["Message"] = "Hola: " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
