using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// this model is for the service that we need to add to the site
namespace Haliyikama.Data.Models
{
	public class Labor
	{
		public int LaborId { get; set; }
		public string Name { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public int Price { get; set; }
		public int NewPrice { get; set; }
		public string ImageUrl { get; set; }
		public bool IsDiscounted { get; set; }
	}
}
