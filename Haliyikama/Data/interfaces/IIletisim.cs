﻿using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.interfaces
{
	public interface IIletisim
	{
		IEnumerable<Iletisim> iletisim { get; }
	}
}
