using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.Models
{
	public class Semt
	{
		public int SemtId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public virtual Ilce Ilce { get; set; }
	}
}
