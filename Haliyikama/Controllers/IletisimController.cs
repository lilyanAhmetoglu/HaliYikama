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
		public IletisimController(IIletisim iletisim)
		{
			_iletisim = iletisim;
		}
		public IActionResult Index()
        {
			
			IletisimViewModel IletisimVM = new IletisimViewModel();
			IletisimVM.iletisim = _iletisim.iletisim;
            return View(IletisimVM);
        }
    }
}