using Haliyikama.Data.interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Controllers
{
	public class HizmetController : Controller
	{
		private readonly IHizmet _hizmet;
		private readonly IAltHizmet _altHizmet;

		public HizmetController(IHizmet hizmet , IAltHizmet altHizmet)
		{
			_hizmet = hizmet;
			_altHizmet = altHizmet;
		}
		public ViewResult List()
		{
			var hizmetler = _hizmet.Hizmetler;
			return View(hizmetler);

		}
	}
}
