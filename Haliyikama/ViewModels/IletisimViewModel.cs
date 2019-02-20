using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.ViewModels
{
	public class IletisimViewModel
	{
		public IEnumerable<Iletisim> iletisim { get; set; }
		public IEnumerable<Ayarlar> Ayarlar { get; set; }
	}
}
