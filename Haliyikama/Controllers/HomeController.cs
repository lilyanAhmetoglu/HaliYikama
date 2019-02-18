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
		public HomeController(ICarousel carousel)
		{
			_carousel = carousel;
		}


		public ViewResult Index()
        {
			var homeViewModel = new HomeViewModel
			{
				Carouseller = _carousel.Carouseller
			};
            return View(homeViewModel);
        }
		
	}
}