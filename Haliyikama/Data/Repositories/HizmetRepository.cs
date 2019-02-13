using Haliyikama.Data.interfaces;
using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.Repositories
{
	public class HizmetRepository : IHizmet
	{
		private readonly AppDbContext _appDbContext;
		public HizmetRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;

		}
		public IEnumerable<Hizmet> Hizmetler => _appDbContext.Hizmetler;
		public IEnumerable<Hizmet> IsdsicountedHizmet => _appDbContext.Hizmetler.Where(p => p.IsDiscounted);
		public Hizmet getHizmetById(int id) => _appDbContext.Hizmetler.FirstOrDefault(p => p.HizmetId == id);

		//IEnumerable<Hizmet> IHizmet.Hizmetler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		//IEnumerable<Hizmet> IHizmet.IsdsicountedHizmet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		
		
	}
}
