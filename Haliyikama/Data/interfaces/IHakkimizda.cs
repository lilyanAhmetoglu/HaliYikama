using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.interfaces
{
	public interface IHakkimizda
	{
		IEnumerable<Hakkimizda> Hakkimizda { get; }
		Hakkimizda getHakkimizdaById(int id);
	}
}
