using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HaliYikamaWebAPI.Controllers
{
    public class HizmetlerController : Controller
    {
		[Route("hizmetler")]
		public IActionResult Index()
        {
            return View();
        }

		[Route("hizmetler/alt-hizmetler")]
		public ViewResult AltHizmetler()
		{
			
			return View();
		}
        [Route("hizmetler/Hizmet-ekle")]
        public ViewResult HizmetEkle()
        {

            return View();
        }
    }
}