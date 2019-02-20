using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Haliyikama.Data.interfaces;
using Haliyikama.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Haliyikama.Controllers
{
    public class FiyatListController : Controller
    {
		private readonly IFiyatListesi _fiyatListesi;
		private readonly IAyarlar _ayarlar;


		public FiyatListController(IFiyatListesi fiyatListesi, IAyarlar ayarlar)
		{
			_fiyatListesi = fiyatListesi;
			_ayarlar = ayarlar;
		}
		public ViewResult Index()
        {
			var FiyatVM = new FiyatListesiViewModel {

				Fiyatlar = _fiyatListesi.Fiyatlar,
				Ayarlar = _ayarlar.ayarlar
		};
			

			return View(FiyatVM);
		}
    }
}