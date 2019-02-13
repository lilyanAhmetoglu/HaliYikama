using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Haliyikama.Controllers
{
    public class FiyatListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}