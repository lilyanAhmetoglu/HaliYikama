using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.interfaces
{
	interface IAltHizmet
	{ 

		IEnumerable<AltHizmet> AltHizmetler { get; set; }
		AltHizmet GetAltHizmetById(int id);
	}
}
