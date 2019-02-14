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
		public ServisController(IIlce ilce , ISemt semt )
		{
			_ilce = ilce;
			_semt = semt;

		}
        public IActionResult Index()
        {
			IlceListViewModel IlceVM = new IlceListViewModel();
			IlceVM.Ilceler = _ilce.Ilceler;
            return View(IlceVM);
        }
    }
}