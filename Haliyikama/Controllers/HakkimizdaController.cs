using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Haliyikama.Data.interfaces;
using Haliyikama.Data.Models;
using Haliyikama.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Haliyikama.Controllers
{
    public class HakkimizdaController : Controller
    {
		private readonly IHakkimizda _hakkimizda;
		private readonly IAyarlar _ayarlar;

		public HakkimizdaController(IHakkimizda hakkimizda, IAyarlar ayarlar)
		{
			_hakkimizda = hakkimizda;
			_ayarlar = ayarlar;
		}

        public ViewResult Index()
        {
			var HakkimizdaVM = new HakkimizdaViewModel {
				Hakkimizda = _hakkimizda.Hakkimizda,
				Ayarlar = _ayarlar.ayarlar
			};
			
            return View(HakkimizdaVM);
        }
    }
}