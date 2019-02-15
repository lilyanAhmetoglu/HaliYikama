using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.Models
{
	public class Hizmet
	{
		public int HizmetId { get; set; }
		public string Name { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public int Price { get; set; }
		public int NewPrice { get; set; }
		public string ImageUrl { get; set; }
		public bool IsDiscounted { get; set; }
		public string URL { get; set; }
		public List<AltHizmet> AltHizmetler { get; set; }
	}
}
