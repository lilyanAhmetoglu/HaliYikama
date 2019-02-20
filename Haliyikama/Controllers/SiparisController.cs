using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Haliyikama.Data.interfaces;
using Haliyikama.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Haliyikama.Controllers
{
    public class SiparisController : Controller
    {
		private readonly IAyarlar _ayarlar;
		public SiparisController( IAyarlar ayarlar)
		{
			_ayarlar = ayarlar;
		}


		public ViewResult Index()
        {
			var SiparisVM = new SiparisViewModel
			{
			
				Ayarlar = _ayarlar.ayarlar

			};

			return View(SiparisVM);
		}
    }
}