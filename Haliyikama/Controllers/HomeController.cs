using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Haliyikama.Data.interfaces;
using Haliyikama.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Haliyikama.Controllers
{
    public class HomeController : Controller
    {
		private readonly ICarousel _carousel;
		private readonly IReferens _referens;
		private readonly IHizmet _hizmet;
		private readonly IAyarlar _ayarlar;

		public HomeController(ICarousel carousel , IReferens referens , IHizmet hizmet, IAyarlar ayarlar)
		{
			_carousel = carousel;
			_referens = referens;
			_hizmet = hizmet;
			_ayarlar = ayarlar;
		}


		public ViewResult Index()
        {
			var homeViewModel = new HomeViewModel
			{
				Carouseller = _carousel.Carouseller,
				Referensler = _referens.Referensler,
				Hizmetler = _hizmet.Hizmetler,
				Ayarlar = _ayarlar.ayarlar
			 
			};
            return View(homeViewModel);
        }
		
	}
}