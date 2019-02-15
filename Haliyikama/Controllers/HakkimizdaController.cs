using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Haliyikama.Data.interfaces;
using Haliyikama.Data.Models;
using Haliyikama.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Haliyikama.Controllers
{
    public class HakkimizdaController : Controller
    {
		private readonly IHakkimizda _hakkimizda;
        public HakkimizdaController(IHakkimizda hakkimizda)
		{
			_hakkimizda = hakkimizda;
		}

        public IActionResult Index()
        {
			HakkimizdaViewModel HakkimizdaVM = new HakkimizdaViewModel();
			HakkimizdaVM.Hakkimizda = _hakkimizda.Hakkimizda;
            return View(HakkimizdaVM);
        }
    }
}