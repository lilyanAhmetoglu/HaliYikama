using Haliyikama.Data.interfaces;
using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.Repositories
{
	public class FiyatListesiRepository : IFiyatListesi
	{
		private readonly AppDbContext _appDbContext;
		public FiyatListesiRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}
		public IEnumerable<FiyatListesi> Fiyatlar => _appDbContext.FiyatListesi;

		public FiyatListesi getFiyatById(int id) => _appDbContext.FiyatListesi.FirstOrDefault(p => p.FiyatId == id);
	}
}
