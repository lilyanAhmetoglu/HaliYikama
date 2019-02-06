using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.interfaces
{
	interface ISemt
	{
		IEnumerable<Semt> Semtler { get; set; }
		Semt getSemtById(int id);
	}
}
