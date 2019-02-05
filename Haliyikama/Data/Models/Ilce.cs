using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.Models
{
	public class Ilce
	{
		public int IlceId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public List<Semt> Semtler { get; set; }
	}
}
