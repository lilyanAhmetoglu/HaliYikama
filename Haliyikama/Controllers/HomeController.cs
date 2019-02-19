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

		public HomeController(ICarousel carousel , IReferens referens)
		{
			_carousel = carousel;
			_referens = referens;
		}


		public ViewResult Index()
        {
			var homeViewModel = new HomeViewModel
			{
				Carouseller = _carousel.Carouseller,
				Referensler = _referens.Referensler
			 
			};
            return View(homeViewModel);
        }
		
	}
}