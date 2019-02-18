using Haliyikama.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data
{
	public class AppDbContext: DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}
		public DbSet<Hizmet> Hizmetler { get; set; }
		public DbSet<AltHizmet> AltHizmetler { get; set; }
		public DbSet<Ilce> Ilceler { get; set; }
		public DbSet<Semt> Semtler { get; set; }
		public DbSet<Hakkimizda> Hakkimizda { get; set; }
		public DbSet<FiyatListesi> FiyatListesi { get; set; }
		public DbSet<Blog> Blog { get; set; }
		public DbSet<Iletisim> Iletisim { get; set; }

 	}
}
