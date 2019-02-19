using Haliyikama.Data.interfaces;
using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.Repositories
{
	public class ReferensRepository : IReferens
	{
		private readonly AppDbContext _appDbContext;
		public ReferensRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public IEnumerable<Referens> Referensler => _appDbContext.Referensler ;
	}
}
