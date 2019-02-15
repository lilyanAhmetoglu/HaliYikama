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
		public FiyatListController(IFiyatListesi fiyatListesi)
		{
			_fiyatListesi = fiyatListesi;
		}
		public IActionResult Index()
        {
			FiyatListesiViewModel FiyatVM = new FiyatListesiViewModel();
			FiyatVM.Fiyatlar = _fiyatListesi.Fiyatlar;

			return View(FiyatVM);
		}
    }
}