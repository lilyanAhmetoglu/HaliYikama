using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.ViewModels
{
	public class IlceListViewModel
	{
		public IEnumerable<Ilce> Ilceler { get; set; }
		public IEnumerable<Ayarlar> Ayarlar { get; set; }
	}
}
