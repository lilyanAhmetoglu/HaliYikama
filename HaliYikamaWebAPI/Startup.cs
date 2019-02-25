using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Haliyikama.Data;
using Haliyikama.Data.interfaces;
using Haliyikama.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace HaliYikamaWebAPI
{
	public class Startup
	{
		private IConfigurationRoot _configurationRoot;
		public IConfiguration Configuration { get; }

		public Startup(IHostingEnvironment hostingEnvironment)
		{
			_configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath)
				.AddJsonFile("appsettings.Json")
				.Build();

		}
		

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
			services.AddDbContext<AppDbContext>(options =>
			options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));

			services.AddTransient<IHizmet, HizmetRepository>();
			services.AddTransient<IAltHizmet, AltHizmetRepository>();
			services.AddTransient<IIlce, IlceRepository>();
			services.AddTransient<ISemt, SemtRepository>();
			services.AddTransient<IHakkimizda, HakkimizdaRepository>();
			services.AddTransient<IFiyatListesi, FiyatListesiRepository>();
			services.AddTransient<IBlog, BlogRepository>();
			services.AddTransient<IIletisim, IletisimRepository>();
			services.AddTransient<ICarousel, CarouselRepository>();
			services.AddTransient<IReferens, ReferensRepository>();
			services.AddTransient<IAyarlar, AyarlarRepository>();

		
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			/*if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseHsts();
			}*/
			app.UseDeveloperExceptionPage();
			app.UseMvc();
			//app.UseDefaultFiles();
			app.UseStatusCodePages();
			app.UseStaticFiles();
		}
	}
}
