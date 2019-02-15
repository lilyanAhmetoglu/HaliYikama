using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.Models
{
	public class Blog
	{
		public int BlogId { get; set; }
		public string Name { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public string ImageURL { get; set; }
		public DateTime DateOfPublish { get; set; }
	}
}
