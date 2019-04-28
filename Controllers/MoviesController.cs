using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new CMovie() { Name = "Shrek!" };

            return View(movie);
        }
    }
}