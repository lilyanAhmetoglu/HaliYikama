using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Haliyikama.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Haliyikama.Data.Models
{
	public class DbInitializer
	{
		public static void Seed(AppDbContext context)
		{
			
				
				if (!context.Hizmetler.Any())
				{
					context.Hizmetler.AddRange(Hizmetler.Select(c => c.Value));
				}
				if (!context.AltHizmetler.Any())
				{
					context.AddRange
					(

						new AltHizmet
						{
							Name = "Althizmet1",
							Description = "Yazi Burda",
							Hizmet = Hizmetler["HaliYikama"]
						},
						new AltHizmet
						{
							Name = "Althizmet2",
							Description = "Yazi Burda",
							Hizmet = Hizmetler["HaliYikama"]

						},
						new AltHizmet
						{
							Name = "Althizmet21",
							Description = "Yazi Burda",
							Hizmet = Hizmetler["HaliYikama2"]
						},
						new AltHizmet
						{
							Name = "Althizmet31",
							Description = "Yazi Burda",
							Hizmet = Hizmetler["HaliYikama3"]
						}
						);
				}



				//Ilceler And Semtler Data 
			if (!context.Ilceler.Any())
			{
				context.Ilceler.AddRange(Ilceler.Select(c => c.Value));
			}
			if (!context.Semtler.Any())
			{
				context.AddRange
					(
					new Semt
					{
						Name ="Basak Mah",
						Description ="yazi burda",
						Ilce  = Ilceler["Arnavutköy"]
						
					},
					new Semt
					{
						Name ="Beyan",
						Description="yazi burda",
						Ilce = Ilceler["Arnavutköy"]
					},
					new Semt
					{
						Name = "Beyan2",
						Description = "yazi burda",
						Ilce = Ilceler["Avcılar"]
					}
					);
			}
			context.SaveChanges();

			   
			
		}
		private static Dictionary<string, Hizmet> hizmetler;
		public static Dictionary<string, Hizmet> Hizmetler
		{
			get
			{
				if (hizmetler == null)
				{
					var genersList = new Hizmet[]
					{
						new Hizmet
						{
							Name = "HaliYikama",
							ShortDescription = " kiza yazi burda ",
							LongDescription ="Uzun Yazi Burda",
							Price = 12,
							NewPrice = 10,
							ImageUrl = "https://via.placeholder.com/150",
							IsDiscounted = false
						},
						new Hizmet
						{
							Name = "HaliYikama2",
							ShortDescription = " kiza yazi burda ",
							LongDescription ="Uzun Yazi Burda",
							Price = 10,
							NewPrice = 9,
							ImageUrl = "https://via.placeholder.com/150",
							IsDiscounted = true
						},
						new Hizmet
						{
							Name = "HaliYikama3",
							ShortDescription = " kiza yazi burda ",
							LongDescription ="Uzun Yazi Burda",
							Price = 12,
							NewPrice = 10,
							ImageUrl = "https://via.placeholder.com/150",
							IsDiscounted = false
						},
						new Hizmet
						{
							Name = "HaliYikama4",
							ShortDescription = " kiza yazi burda ",
							LongDescription ="Uzun Yazi Burda",
							Price = 10,
							NewPrice = 9,
							ImageUrl = "https://via.placeholder.com/150",
							IsDiscounted = true
						}
					};
					hizmetler = new Dictionary<string, Hizmet>();
					foreach (Hizmet genre in genersList)
					{
						hizmetler.Add(genre.Name, genre);
					}
				}
				return hizmetler;
			}
		}

		private static Dictionary<string, Ilce> ilceler;
		public static Dictionary<string, Ilce> Ilceler
		{
			get
			{
				if (ilceler == null)
				{
					var genersList = new Ilce[]
					{
						new Ilce
						{
							Name="Arnavutköy",
							ShortDescription="Kiza yazi",
							LongDescription="uzun yazi",
							ImageURL="http://orig11.deviantart.net/6356/f/2010/156/e/f/swallowed_by_nature_by_danutza88.jpg"

						},
						new Ilce
						{
							Name="Ataşehir",
							ShortDescription="Kiza yazi",
							LongDescription="uzun yazi",
							ImageURL="http://orig11.deviantart.net/6356/f/2010/156/e/f/swallowed_by_nature_by_danutza88.jpg"

						},
						new Ilce
						{
							Name="Avcılar",
							ShortDescription="Kiza yazi",
							LongDescription="uzun yazi",
							ImageURL="http://orig11.deviantart.net/6356/f/2010/156/e/f/swallowed_by_nature_by_danutza88.jpg"

						},
						new Ilce
						{
							Name="Bağcılar",
							ShortDescription="Kiza yazi",
							LongDescription="uzun yazi",
							ImageURL="http://orig11.deviantart.net/6356/f/2010/156/e/f/swallowed_by_nature_by_danutza88.jpg"

						},
						new Ilce
						{
							Name="Bahçelievler",
							ShortDescription="Kiza yazi",
							LongDescription="uzun yazi",
							ImageURL="http://orig11.deviantart.net/6356/f/2010/156/e/f/swallowed_by_nature_by_danutza88.jpg"

						},
						new Ilce
						{
							Name="Bakırköy",
							ShortDescription="Kiza yazi",
							LongDescription="uzun yazi",
							ImageURL="http://orig11.deviantart.net/6356/f/2010/156/e/f/swallowed_by_nature_by_danutza88.jpg"

						}

					};
					ilceler = new Dictionary<string, Ilce>();
					foreach (Ilce genre in genersList)
					{
						ilceler.Add(genre.Name, genre);
					}
				}
				return ilceler;
			}
		}
	}
}
