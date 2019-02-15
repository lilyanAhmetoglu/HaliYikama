using Haliyikama.Data.interfaces;
using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.Repositories
{
	public class HakkimizdaRepository : IHakkimizda
	{
		private readonly AppDbContext _appDbContext;

		public HakkimizdaRepository (AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}
		public IEnumerable<Hakkimizda> Hakkimizda => _appDbContext.Hakkimizda;
		public Hakkimizda getHakkimizdaById(int id) => _appDbContext.Hakkimizda.FirstOrDefault(p => p.HakkimizdaId == id);
		//IEnumerable<Hakkimizda> IHakkimizda.Hakkimizda { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



	}
}
