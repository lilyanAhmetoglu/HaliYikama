using Haliyikama.Data.interfaces;
using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.mocks
{
	public class MockAltHizmet : IAltHizmet
	{
		private readonly IHizmet _hizmet = new MockHizmet();

		public IEnumerable<AltHizmet> AltHizmetler {
			get
			{
				return new List<AltHizmet>
				{
					new AltHizmet
					{
						Name = "AltHizmet1",
						Description ="Alt Hizmeti 1 yazi ",
						Hizmet = _hizmet.Hizmetler.First(),

					},
					new AltHizmet
					{
						Name ="AltHizmet2",
						Description = "Alt Hizmeti 2 Yazi",
						Hizmet = _hizmet.Hizmetler.First()
					}
				};
			}
			set => throw new NotImplementedException();
		}

		public AltHizmet GetAltHizmetById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
