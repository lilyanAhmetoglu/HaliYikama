using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.interfaces
{
	public interface IIlce
	{
		IEnumerable<Ilce> Ilceler { get;  }
		Ilce getIlceById(int id);
		List<Semt> getSemtByIlceID(int id);
	}
}
