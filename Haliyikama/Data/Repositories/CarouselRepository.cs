using Haliyikama.Data.interfaces;
using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.Repositories
{
	public class CarouselRepository :ICarousel
	{
		private readonly AppDbContext _appDbContext;
		public CarouselRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public IEnumerable<Carousel> Carouseller => _appDbContext.Carouseller;
	}
}
