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
		public BilgilerController(IBlog blog)
		{
			_blog = blog;
		}
		public IActionResult Index()
        {
			BlogListViewModel BlogVM = new BlogListViewModel();
			BlogVM.Blogler = _blog.Blogler;

			return View(BlogVM);
		}
    }
}