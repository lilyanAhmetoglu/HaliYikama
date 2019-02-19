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

		public HomeController(ICarousel carousel , IReferens referens , IHizmet hizmet)
		{
			_carousel = carousel;
			_referens = referens;
			_hizmet = hizmet;
		}


		public ViewResult Index()
        {
			var homeViewModel = new HomeViewModel
			{
				Carouseller = _carousel.Carouseller,
				Referensler = _referens.Referensler,
				Hizmetler= _hizmet.Hizmetler
			 
			};
            return View(homeViewModel);
        }
		
	}
}