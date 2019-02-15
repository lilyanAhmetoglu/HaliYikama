using Haliyikama.Data.interfaces;
using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haliyikama.Data.Repositories
{
	public class BlogRepository :IBlog
	{
		private readonly AppDbContext _appDbContext;
		public BlogRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public IEnumerable<Blog> Blogler => _appDbContext.Blog;

		public Blog getBlogById(int id) => _appDbContext.Blog.FirstOrDefault(p => p.BlogId == id);
	}

}
