﻿using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.interfaces
{
	public interface IBlog
	{
		IEnumerable<Blog> Blogler { get; }
		Blog getBlogById(int id);
	}
}
