using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Haliyikama.Data.interfaces;
using Haliyikama.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Haliyikama.Controllers
{
    public class IletisimController : Controller
    {
		private readonly IIletisim _iletisim;
		private readonly IAyarlar _ayarlar;

		public IletisimController(IIletisim iletisim, IAyarlar ayarlar)
		{
			_iletisim = iletisim;
			_ayarlar = ayarlar;
		}
		public ViewResult Index()
        {

			var IletisimVM = new IletisimViewModel {
				iletisim = _iletisim.iletisim,
				Ayarlar = _ayarlar.ayarlar

			};
			
            return View(IletisimVM);
        }
    }
}