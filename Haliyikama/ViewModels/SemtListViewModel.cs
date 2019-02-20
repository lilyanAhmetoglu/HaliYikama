using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.ViewModels
{
	public class SemtListViewModel
	{
		public IEnumerable<Semt> Semtler { get; set; }
		public IEnumerable<Ayarlar> Ayarlar { get; set; }
		public Semt semt { get; set; }
	}
}
