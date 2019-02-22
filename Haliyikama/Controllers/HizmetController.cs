using Haliyikama.Data.interfaces;
using Haliyikama.ViewModels;
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
		private readonly IAyarlar _ayarlar;
		private readonly IAltHizmet _altHizmet;

		public HizmetController(IHizmet hizmet , IAltHizmet altHizmet, IAyarlar ayarlar)
		{
			_hizmet = hizmet;
			_altHizmet = altHizmet;
			_ayarlar = ayarlar;
		}
		public ViewResult Index()
		{
			//	var hizmetler = _hizmet.Hizmetler;
			var HizmetVM = new HizmetListViewModel {
				Hizmetler = _hizmet.Hizmetler ,
			    Ayarlar = _ayarlar.ayarlar
			  };
			
    		return View(HizmetVM);

		}
		public ViewResult Detail(int id) {
			var HizmetVM = new HizmetListViewModel
			{
				AltHizmetler = _hizmet.getAltHizmetlerById(id),
				hizmet = _hizmet.getHizmetById(id),
				Ayarlar = _ayarlar.ayarlar
			};
			return View(HizmetVM);
		}
	}
}
