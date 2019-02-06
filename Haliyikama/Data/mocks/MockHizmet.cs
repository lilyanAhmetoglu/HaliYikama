using Haliyikama.Data.interfaces;
using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.mocks
{
	public class MockHizmet : IHizmet
	{
		public IEnumerable<Hizmet> Hizmetler {

			get
			{
				return new List<Hizmet>
				{
					new Hizmet {
						Name = "Hali Yikama",
						LongDescription ="Halı yıkama, geleneksel yöntemlerle yapılacak bir iş değildir. Firmamız, son teknoloji makinelerle halı yıkamaktadır, kusursuz bir halı temizliği sağlanmaktadır.",
						Price = 12,
						ImageUrl = "https://via.placeholder.com/150",
						IsDiscounted = true,
						NewPrice = 9,


					},
					new Hizmet {
						Name = "Step Halı Yıkama" ,
						LongDescription ="​Orjinal Step Halı Yıkama, Buharlı Temizlik, Step halısı modern desenleri ve çeşitleriyle göz dolduran bir halıdır.",
						Price = 11,
						ImageUrl = "https://via.placeholder.com/150",
						IsDiscounted = false,
						NewPrice = 0,
					}
				};
			}
			set => throw new NotImplementedException();
		}
		public IEnumerable<Hizmet> IsdsicountedHizmet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public Hizmet getHizmetById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
