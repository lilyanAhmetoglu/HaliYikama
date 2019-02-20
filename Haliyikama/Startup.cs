using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Haliyikama.Data.interfaces;
using Haliyikama.Data.mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.SpaServices.StaticFiles;
using Microsoft.Extensions.Configuration;
using Haliyikama.Data;
using Microsoft.EntityFrameworkCore;
using Haliyikama.Data.Repositories;
using Haliyikama.Data.Models;

namespace Haliyikama
{
	public class Startup
	{

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

		private IConfigurationRoot _configurationRoot;

		public Startup(IHostingEnvironment hostingEnvironment)
		{
			_configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath)
				.AddJsonFile("appsettings.Json")
				.Build();

		}
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<AppDbContext>(options =>
			options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));

			services.AddTransient<IHizmet, HizmetRepository >();
			services.AddTransient<IAltHizmet, AltHizmetRepository>();
			services.AddTransient<IIlce, IlceRepository>();
			services.AddTransient<ISemt, SemtRepository>();
			services.AddTransient<IHakkimizda, HakkimizdaRepository>();
			services.AddTransient<IFiyatListesi , FiyatListesiRepository>();
			services.AddTransient<IBlog, BlogRepository>();
			services.AddTransient<IIletisim, IletisimRepository>();
			services.AddTransient<ICarousel, CarouselRepository>();
			services.AddTransient<IReferens, ReferensRepository>();
			services.AddTransient<IAyarlar, AyarlarRepository>();

			//services.AddSpaStaticFiles;
			services.AddMvc();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			/*if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.Run(async (context) =>
			{
				await context.Response.WriteAsync
				("Hello World!");
			});*/

			app.UseDeveloperExceptionPage();
			app.UseStatusCodePages();
			app.UseStaticFiles();
			//app.UseMvcWithDefaultRoute();
			app.UseMvc(
				 routes =>
				 {
					 routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
				 }
				);
			
			
			
		
		}
	}
}
