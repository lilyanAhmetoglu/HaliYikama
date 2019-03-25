using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HaliYikamaWebAPI.Controllers
{
    public class IlcelerController : Controller
    {
        [Route("ilceler")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("ilceler/semtler")]
        public ViewResult Semtler()
        {

            return View();
        }
    }
}