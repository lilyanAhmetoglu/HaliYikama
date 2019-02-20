using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.ViewModels
{
	public class HizmetListViewModel
	{
		public IEnumerable<Hizmet> Hizmetler{ get; set; }
		public IEnumerable<Ayarlar> Ayarlar { get; set; }

	}
}
