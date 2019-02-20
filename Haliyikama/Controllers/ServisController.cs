using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Haliyikama.Data.interfaces;
using Haliyikama.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Haliyikama.Controllers
{
    public class ServisController : Controller
    {
		private readonly IIlce _ilce;
		private readonly ISemt _semt;
		private readonly IAyarlar _ayarlar;


		public ServisController(IIlce ilce , ISemt semt, IAyarlar ayarlar)
		{
			_ilce = ilce;
			_semt = semt;
			_ayarlar = ayarlar;

		}
        public ViewResult Index()
        {
			var IlceVM = new IlceListViewModel {
				Ilceler = _ilce.Ilceler,
				Ayarlar =_ayarlar.ayarlar

			};
			
            return View(IlceVM);
        }


		public ViewResult Details()
		{
		
			return View();

		}
	}
}