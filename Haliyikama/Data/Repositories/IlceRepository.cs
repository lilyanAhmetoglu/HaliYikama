using Haliyikama.Data.interfaces;
using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.Repositories
{
	public class IlceRepository : IIlce
	{
		private readonly AppDbContext _appDbContext;
		public IlceRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}
		public IEnumerable<Ilce> Ilceler => _appDbContext.Ilceler;

		public Ilce getIlceById(int id) => _appDbContext.Ilceler.FirstOrDefault(p => p.IlceId == id);
	}
}
