using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.interfaces
{
	interface IIlce
	{
		IEnumerable<Ilce> Ilceler { get; set; }
		Ilce getIlceById(int id);
	}
}
