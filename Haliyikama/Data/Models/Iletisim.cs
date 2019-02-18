using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.Models
{
	public class Iletisim
	{
		public int IletisimId { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
		public string Phone1 { get; set; }
		public string Phone2 { get; set; }
		public string MapLink { get; set; }
		public string ShortDescription { get; set; }
	}
}
