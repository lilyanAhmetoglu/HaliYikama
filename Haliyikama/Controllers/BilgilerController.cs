using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Haliyikama.Data.interfaces;
using Haliyikama.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Haliyikama.Controllers
{
    public class BilgilerController : Controller
    {
		private readonly IBlog _blog;
		private readonly IAyarlar _ayarlar;
		public BilgilerController(IBlog blog , IAyarlar ayarlar)
		{
			_blog = blog;
			_ayarlar = ayarlar;
		}
		public ViewResult Index()
        {
			var BlogVM = new BlogListViewModel
			{
				Blogler = _blog.Blogler,
				Ayarlar = _ayarlar.ayarlar

		  };
			

			return View(BlogVM);
		}
    }
}