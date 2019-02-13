using Haliyikama.Data.interfaces;
using Haliyikama.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.Repositories
{
	public class AltHizmetRepository : IAltHizmet
	{
		private readonly AppDbContext _appDpContext;
		public AltHizmetRepository(AppDbContext appDbContext)
		{
			_appDpContext = appDbContext;

		}
		public IEnumerable<AltHizmet> AltHizmetler => _appDpContext.AltHizmetler.Include(c => c.Hizmet);
		public AltHizmet GetAltHizmetById(int id) => _appDpContext.AltHizmetler.FirstOrDefault(p => p.AltHizmetId == id);

		IEnumerable<AltHizmet> IAltHizmet.AltHizmetler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		
	}
}
