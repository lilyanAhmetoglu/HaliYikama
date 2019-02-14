using Haliyikama.Data.interfaces;
using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.Repositories
{
	public class SemtRepository : ISemt
	{
		private readonly AppDbContext _appDbContext;
		public SemtRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}
		public IEnumerable<Semt> Semtler => _appDbContext.Semtler;

		IEnumerable<Semt> ISemt.Semtler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public Semt getSemtById(int id) => _appDbContext.Semtler.FirstOrDefault(p => p.SemtId == id);
	}
}
