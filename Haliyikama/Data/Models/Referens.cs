using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.Models
{
	public class Referens
	{
		[Key]
		public int ReferenseId { get; set; }
		public string Name { get; set; }
		public string Position { get; set; }
		public string ImageURL { get; set;}
		public string Text { get; set; }
	}
}
