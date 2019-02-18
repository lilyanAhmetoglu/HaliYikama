using Haliyikama.Data.interfaces;
using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.Repositories
{
	public class IletisimRepository : IIletisim
	{
		private readonly AppDbContext _appDbContext;
		public IletisimRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public IEnumerable<Iletisim> iletisim => _appDbContext.Iletisim;

	
	}
}
