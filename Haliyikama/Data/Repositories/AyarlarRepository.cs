using Haliyikama.Data.interfaces;
using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.Repositories
{
	public class AyarlarRepository : IAyarlar
	{
		private readonly AppDbContext _appDbContext;
		public AyarlarRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public IEnumerable<Ayarlar> ayarlar => _appDbContext.Ayarlar;
	}
}
