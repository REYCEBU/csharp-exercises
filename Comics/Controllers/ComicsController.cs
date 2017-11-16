using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Comics.Controllers
{
    public class ComicsController : Controller
    {
        // http://localhost:999/Comics?name=spider-man
        public IActionResult Index(string name)
        {
            return Content("<hi>comics</hi>" + name, "text/html");
        }
    }
}